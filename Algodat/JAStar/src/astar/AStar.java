package astar;

import java.awt.Color;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import shapes.ShapeLine;
import shapes.ShapePoint;

public class AStar
{
    
    public static void calculate(List<ShapeLine> lineList, Set<ShapePoint> pointSet, ShapePoint startPoint, ShapePoint endPoint)
    {
        
        Set<ShapePoint> closedList = new HashSet<ShapePoint>();
        Set<ShapePoint> openList = new HashSet<ShapePoint>();

        Debugger.DEBUG_MODE=true;
        
        ////////////////////////////////////////////////////////
        // Delete this and replace by algorithm
        //ArrayList<Shape> myShapeList = new ArrayList<Shape>();
        //myShapeList.addAll(lineList);
        //myShapeList.addAll(pointSet);
        //myShapeList.remove(startPoint);
        //myShapeList.remove(endPoint);
        //Collections.shuffle(myShapeList);
        //for (Shape x : myShapeList) {
        //	x.blink();
        //	x.setColor(Color.MAGENTA);
        //}
        ////////////////////////////////////////////////////////
        /*
         Nimm den Knoten aus der Open List mit minimaler
         Schätzung:
         – Expandiere diesen, das heisst:
         • Nimm ihn aus der open list,
         tu ihn in die closed list.
         • Gib alle nachfolger, die nicht in der closed list
         sind in die open list,
         – Falls ein nachfolger schon in der open list ist,
         nimm den pfad mit der besseren schätzung
         – Ansonsten nimm den Pfad über den
         exandierten Knoten
         – Falls Ziel erreicht: FERTIG
         */
        // wir fangen mit dem startpunkt an
        // und setzen die heuristic mit der entfernung zwischen start und endpunkt
        // die route ist null
        // wir setzen den startpunkt in die openlist
        //
        //
        startPoint.setHeuristics(startPoint.distance(endPoint));
        startPoint.setRoute(null);
        openList.add(startPoint);
        
        Debugger.info("Luftline zw. Start und Endpunkt : " + startPoint.getHeuristics() );
        
        while ( !closedList.contains(endPoint) && !openList.isEmpty())
        {
            ShapePoint expandPoint = AStar.findMininalPoint(openList);
            Debugger.debug("Found expandPoint : " + expandPoint.toString() );

            expandPoint.blink();
        
            savesetColor(expandPoint, startPoint, endPoint, Color.black);
            
            // nimm ihn aus der openlist
            openList.remove(expandPoint);
            
            // setz ihn in die closedlist
            closedList.add(expandPoint);
            
            // und ordentlich einfarbeln
            expandPoint.setColor(Color.BLACK);
            
            // so ginge es auch
            // for (int i = 0; lineList.size(); i++)
            // so schauts gleich besser aus
            for (ShapeLine line : lineList)
            {
             
                Debugger.debug ("Line mit Länge : " + line.length() );
                
                if (line.hasPoint(expandPoint))
                {
                    ShapePoint neighborPoint = line.traverse(expandPoint);
                    
                    Debugger.debug("Found neighborPoint : " + neighborPoint.toString() );
                    
                    line.blink();
                    
                    // drei möglichkeiten
                    // 1. neighbor ist in der closedlist
                    if (closedList.contains(neighborPoint))
                    {
                        // nix zu tun
                        neighborPoint.setColor(Color.BLACK);
                        AStar.savesetColor(expandPoint, startPoint, endPoint, Color.BLACK);
                    } // end if closedList
                    // 2. neighbor ist in der openlist
                    else if (openList.contains(neighborPoint))
                    {
                  
                        double lenExpandPoint = AStar.pathLength(expandPoint) + line.length();
                        double lenNeighborPoint = AStar.pathLength(neighborPoint);
                        
                        Debugger.debug("Pfadlänge Expandpoint + Länge der Linie : " + lenExpandPoint);
                        Debugger.debug("Pfalänge Neighorpoint : " + lenNeighborPoint);
                        
                        if ( lenNeighborPoint < lenExpandPoint )
                        {
                            Debugger.debug("Pfadlänge Neighorpoint < Pfadlänge Expandpoint. Daher neue Route setzen !");
                            neighborPoint.setRoute(line);
                            neighborPoint.setHeuristics(pathLength(neighborPoint) + neighborPoint.distance(endPoint));
                        }
                        else
                        {
                            Debugger.debug("Pfadlänge Neighorpoint > Pfadlänge Expandpoint. Daher keine neue Route setzen !");
                        }

                        
                    } // end if opedList
                    // 3. sonst ist neighbor in unknownlist
                    else
                    {
                        neighborPoint.setRoute(line);
                        
                        // etwas ausfuehrlicher bitte
                        double pathLength = AStar.pathLength(neighborPoint);
                        double distance = neighborPoint.distance(endPoint);
                        
                        neighborPoint.setHeuristics( pathLength + distance);
                        
                        // ich trottel ... hab darauf vergessen
                        openList.add(neighborPoint);
                        AStar.savesetColor(expandPoint, startPoint, endPoint, Color.WHITE);
                    }
            
                    //colorPath(neighborPoint, Color.MAGENTA);
                    
                } // end if shapeLine.hasPoint

            } // end for

            if ( closedList.contains(endPoint) )
            {
                // weg gefunden
                AStar.colorPath(endPoint, Color.BLACK);
                Debugger.info("Länge der kuerzersten Route : " + endPoint.getHeuristics());
                
            }
            else
            {
                // unmöglich
                
            }
        } // end while

        // gefundener weg anzeigen

    }
    
    private static void savesetColor(ShapePoint point, ShapePoint startPoint, ShapePoint endPoint, Color color)
    {
        if (!point.equals(startPoint) && !point.equals(endPoint))
        {
            point.setColor(color);
        }
        
    }
    
    private static void colorPath(ShapePoint end, Color c)
    {
        if (end.getRoute() != null)
        {
            end.getRoute().setColor(c);
            colorPath(end.getRoute().traverse(end), c);
        }
    }
    
    private static double pathLength(ShapePoint end)
    {
        if (end.getRoute() == null)
        {
            Debugger.debug("Pathlänge vom Endpoint : 0");
            return 0;
        } else
        {
            double a = end.getRoute().length();
            double b = pathLength(end.getRoute().traverse(end) );
            
            Debugger.debug("! Länge Route von Endpunkt ["+end.toString()+"] : " + a);
            Debugger.debug("! Länge Path von Endpunkt  ["+end.toString()+"] : " + b);
            
            return a + b;
        }
    }
    
    private static ShapePoint findMininalPoint(Set<ShapePoint> openList)
    {
        ShapePoint minimalPoint = null;
        for (ShapePoint x : openList)
        {
            if (x.getHeuristics() != 0.0)
            {
                if (minimalPoint == null)
                {
                    minimalPoint = x;
                } else if (minimalPoint.getHeuristics() > x.getHeuristics())
                {
                    minimalPoint = x;
                }
            }
        }
        return minimalPoint;
    }
    
}
