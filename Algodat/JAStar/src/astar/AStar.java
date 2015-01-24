package astar;

import java.awt.Color;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import modelcontroller.DrawModel;
import modelcontroller.commands.DrawModelResetCommand;
import shapes.Shape;
import shapes.ShapeLine;
import shapes.ShapePoint;

public class AStar
{
    
    public static void calculate(List<ShapeLine> lineList, Set<ShapePoint> pointSet, ShapePoint startPoint, ShapePoint endPoint)
    {
        
        Set<ShapePoint> closedList = new HashSet<ShapePoint>();
        Set<ShapePoint> openList = new HashSet<ShapePoint>();

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
        
        while ( !closedList.contains(endPoint) && !openList.isEmpty())
        {
            ShapePoint expandPoint = AStar.findMininalPoint(openList);
            System.out.println("Found expand : " + expandPoint.toString() );

            expandPoint.blink();
            savesetColor(expandPoint, startPoint, endPoint, Color.black);
            
            // nimm ihn aus der openlist
            openList.remove(expandPoint);
            // setz ihn in die closedlist
            closedList.add(expandPoint);

            // so ginge es auch
            // for (int i = 0; lineList.size(); i++)
            // so schauts gleich besser aus
            for (ShapeLine line : lineList)
            {
                
                if (line.hasPoint(expandPoint))
                {
                    ShapePoint neighborPoint = line.traverse(expandPoint);
                    
                    System.out.println("Found neighbor : " + neighborPoint.toString() );
                    
                    line.blink();
                    // drei möglichkeiten
                    // 1. neighbor ist in der closedlist
                    if (closedList.contains(neighborPoint))
                    {
                        // nix zu tun
                    } // end if closedList
                    // 2. neighbor ist in der openlist
                    else if (openList.contains(neighborPoint))
                    {
                        
                        double lenExpandPoint = AStar.pathLength(expandPoint) + line.length();
                        double lenNeighborPoint = AStar.pathLength(neighborPoint);
                        
                        if ( lenNeighborPoint < lenExpandPoint )
                        {
                            neighborPoint.setRoute(line);
                            neighborPoint.setHeuristics(pathLength(neighborPoint) + neighborPoint.distance(endPoint));
                        }

                        
                    } // end if opedList
                    // 3. sonst ist neighbor in unknownlist
                    else
                    {
                        // unknown list
                        neighborPoint.setRoute(line);
                        neighborPoint.setHeuristics(AStar.pathLength(neighborPoint) + neighborPoint.distance(endPoint));
                        
                        // ich trottel ...
                        openList.add(neighborPoint);
                        AStar.savesetColor(expandPoint, startPoint, endPoint, Color.GRAY);
                    }
            
                    //colorPath(neighborPoint, Color.MAGENTA);
                    
                } // end if shapeLine.hasPoint

            } // end for

            if ( closedList.contains(endPoint) )
            {
                // weg gefunden
                AStar.colorPath(endPoint, Color.black);
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
            return 0;
        } else
        {
            return end.getRoute().length() + pathLength(end.getRoute().traverse(end));
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
