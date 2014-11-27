package at.fhb.iti.algodat.ue2.bankomat.grafics;

public interface BankomatView {
	
	public void setText (String text);

	public void addText (String text);
	
	public String getText();
	
	public void setKartenText (String text);
	
	public void setKartenButtonLabel (String text);
	
	public void setGeldladeText (String text);

}
