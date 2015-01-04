package at.fhb.iti.algodat.ue1.grafics;

import java.awt.BorderLayout;
import java.awt.FlowLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

import at.fhb.iti.algodat.ue1.defs.Definitions;

public class BallApplication extends JFrame {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	private BallsController theBallsController;

	private JPanel jContentPane;
	private BallsPanel jBallsPanel;
	private JPanel jButtonPanel;
	private JButton jTossButton;
	private JButton jRemoveButton;
	private JButton jToss10Button;
	private JButton jRemove10Button;

	public BallApplication (BallsController bc) {
		super();
		theBallsController = bc;
		initialize();
	}

	private void initialize() {
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setSize(Definitions.SIZEX, Definitions.SIZEY);
		this.setResizable(false);
		this.setContentPane(getJontentPane());
		this.setTitle("Balls Flying Application");
		this.setVisible(true);
	}

	private JPanel getJontentPane() {
		
		if (jContentPane == null) {
			jContentPane = new JPanel() ;
			jContentPane.setLayout(new BorderLayout());
			jContentPane.add(getBallsPanel(),java.awt.BorderLayout.CENTER);
			jContentPane.add(getButtonPanel(),java.awt.BorderLayout.NORTH);
			
		}
		return jContentPane;
	}

	public BallsPanel getBallsPanel() {
		if (jBallsPanel == null ) {
			jBallsPanel = new BallsPanel();	
		}
		return jBallsPanel;
	}

	private JPanel getButtonPanel() {
		if (jButtonPanel == null ) {
			jButtonPanel = new JPanel();
			jButtonPanel.setLayout(new FlowLayout());
			jButtonPanel.add(getTossButton());
			jButtonPanel.add(getToss10Button());
			jButtonPanel.add(getRemoveButton());
			jButtonPanel.add(getRemove10Button());
		}
		return jButtonPanel;
	}

	private JButton getRemoveButton() {
		if (jRemoveButton == null) {
			jRemoveButton = new JButton();
			jRemoveButton.setText("Remove Ball");
			jRemoveButton.setActionCommand("Remove");
			jRemoveButton.addActionListener(theBallsController);
		}
		return jRemoveButton;
	}
	
	private JButton getRemove10Button() {
		if (jRemove10Button == null) {
			jRemove10Button = new JButton();
			jRemove10Button.setText("Remove 10 Balls");
			jRemove10Button.setActionCommand("Remove10");
			jRemove10Button.addActionListener(theBallsController);
		}
		return jRemove10Button;
	}
	

	private JButton getTossButton() {
		if (jTossButton == null ) {
			jTossButton = new JButton();
			jTossButton.setText("Toss Ball");
			jTossButton.setActionCommand("Toss");
			jTossButton.addActionListener(theBallsController);
		}
		return jTossButton;
	}

	private JButton getToss10Button() {
		if (jToss10Button == null ) {
			jToss10Button = new JButton();
			jToss10Button.setText("Toss 10 Balls");
			jToss10Button.setActionCommand("Toss10");
			jToss10Button.addActionListener(theBallsController);
		}
		return jToss10Button;
	}

}
