package at.fhb.iti.algodat.ue2.bankomat.model;

import at.fhb.iti.algodat.ue2.bankomat.grafics.BankomatView;

import static at.fhb.iti.algodat.ue2.bankomat.model.BankomatState.*;

public class BankomatModelImplementation implements BankomatModel
{

  private BankomatView theView;
  private BankomatState theState;
  private boolean cardInside = false;
  private int pinCode;
  private static final int originalPIN = 0000;
  private int amount;

  /**
   * 
   * @param view 
   */
  public void setView(BankomatView view)
  {
    theView = view;
    setBankomatState(IDLE);
    pinCode = 0;
    amount = 0;
  }

  /**
   * 
   * @param digit 
   */
  public void pressButtonDigit(int digit)
  {
    //if (cardInside && (theState == CARD_INSERTED))
    if (theState == CARD_INSERTED)
    {
      theView.setText("");
    }
    
    //if (cardInside)
    //{
      switch (theState)
      {
        case CARD_INSERTED:
          // TODO Do something according to state
          pinCode = pinCode + digit;
          setBankomatState(PINCODE_INPUT_DIGIT_1);
          theView.setText("X---");
          break;
        case PINCODE_INPUT_DIGIT_1:
          // TODO Do something according to state
          pinCode = pinCode * 10 + digit;
          setBankomatState(PINCODE_INPUT_DIGIT_2);
          theView.setText("XX--");
          break;
        case PINCODE_INPUT_DIGIT_2:
          // TODO Do something according to state
          pinCode = pinCode * 10 + digit;
          setBankomatState(PINCODE_INPUT_DIGIT_3);
          theView.setText("XXX-");
          break;
        case PINCODE_INPUT_DIGIT_3:
          // TODO Do something according to state
          pinCode = pinCode * 10 + digit;
          setBankomatState(PINCODE_INPUT_DIGIT_4);
          theView.setText("XXXX");
          break;
        case PINCODE_CORRECT:
          if (digit != 0)
          {
            amount = digit;
            setBankomatState(AMOUNT_INPUT_DIGIT_1);
            theView.setText("" + amount);
          }
          break;
        case AMOUNT_INPUT_DIGIT_1:
          amount = amount * 10 + digit;
          setBankomatState(AMOUNT_INPUT_DIGIT_2);
          theView.setText("" + amount);
          break;
        case AMOUNT_INPUT_DIGIT_2:
          amount = amount * 10 + digit;
          setBankomatState(AMOUNT_INPUT_DIGIT_3);
          theView.setText("" + amount);
          break;
        case AMOUNT_INPUT_DIGIT_3:
          amount = amount * 10 + digit;
          setBankomatState(AMOUNT_INPUT_DIGIT_4);
          theView.setText("" + amount);
          break;
        default:
          break;
      }
    //}  // end of if
  }// end method

  /**
   * 
   */
  public void pressButtonCancel()
  {
      switch (theState)
      {
        case CARD_INSERTED:
          theView.setText("Abbruch des Vorgangs. Bitte Karte entnehmen.");
          theView.setKartenButtonLabel("Karte entnehmen");
          setBankomatState(CARD_REMOVED);
          break;
        case PINCODE_INPUT_DIGIT_1:
        case PINCODE_INPUT_DIGIT_2:
        case PINCODE_INPUT_DIGIT_3:
        case PINCODE_INPUT_DIGIT_4:
          pinCode = 0;
          setBankomatState(CARD_INSERTED);
          theView.setText("Bitte geben Sie Ihre 4-stellige PIN ein");
          break;
        case PINCODE_CORRECT:
          theView.setText("Abbruch des Vorgangs. Bitte Karte entnehmen.");
          theView.setKartenButtonLabel("Karte entnehmen");
          setBankomatState(CANCEL);
          break;
        case AMOUNT_INPUT_DIGIT_1:
        case AMOUNT_INPUT_DIGIT_2:
        case AMOUNT_INPUT_DIGIT_3:
        case AMOUNT_INPUT_DIGIT_4:
          amount = 0;
          setBankomatState(PINCODE_CORRECT);
          theView.setText("Bitte Geldbetrag erneut eingeben.");
          break;
        default:
          break;
      } // end switch
  }// end method

  /**
   * 
   * 
   */
  public void pressButtonDelete()
  {
    String s = "";
    switch (theState)
    {
      case PINCODE_INPUT_DIGIT_1:
        pinCode = 0;
        setBankomatState(CARD_INSERTED);
        Debug.debug(theState);
        theView.setText("----");
        break;
      case PINCODE_INPUT_DIGIT_2:
        pinCode = (int) (pinCode / 10);
        setBankomatState(PINCODE_INPUT_DIGIT_1);
        theView.setText("X---");
        break;
      case PINCODE_INPUT_DIGIT_3:
        pinCode = (int) (pinCode / 10);
        setBankomatState(PINCODE_INPUT_DIGIT_2);
        theView.setText("XX--");
        break;
      case PINCODE_INPUT_DIGIT_4:
        pinCode = (int) (pinCode / 10);
        setBankomatState(PINCODE_INPUT_DIGIT_3);
        theView.setText("XXX-");
        break;
      case AMOUNT_INPUT_DIGIT_1:
        amount = 0;
        setBankomatState(PINCODE_CORRECT);
        theView.setText("");
        break;
      case AMOUNT_INPUT_DIGIT_2:
        amount = (int) (amount / 10);
        setBankomatState(AMOUNT_INPUT_DIGIT_1);
        s = theView.getText();
        if (s.length() > 1)
        {
          theView.setText("" + s.substring(0, s.length() - 1));
        } else
        {
          theView.setText("");
        }
        break;
      case AMOUNT_INPUT_DIGIT_3:
        amount = (int) (amount / 10);
        setBankomatState(AMOUNT_INPUT_DIGIT_2);
        s = theView.getText();
        if (s.length() > 1)
        {
          theView.setText("" + s.substring(0, s.length() - 1));
        } else
        {
          theView.setText("");
        }
        break;
      case AMOUNT_INPUT_DIGIT_4:
        amount = (int) (amount / 10);
        setBankomatState(AMOUNT_INPUT_DIGIT_3);
        s = theView.getText();
        if (s.length() > 1)
        {
          theView.setText("" + s.substring(0, s.length() - 1));
        } else
        {
          theView.setText("");
        }
        break;
      default:
        break;
    }// end switch
  }// end method

  /**
   *
   */
  public void pressButtonEnter()
  {
    // Eingabe des PIN beendet und bestaetigt (Enter)
    if (theState == PINCODE_INPUT_DIGIT_4)
    {
      if (pinCode == originalPIN)
      {
        theView.setText("PIN ist korrekt! Bitte Geldbetrag eingeben.");
        setBankomatState(PINCODE_CORRECT);
      } else
      {
        theView.setText("PIN ist falsch! Bitte erneut versuchen.");
        pinCode = 0;
        setBankomatState(CARD_INSERTED);
      }
    }
    // Geldbetrag eingeben, max 4 stellen lang
    if ( (theState == AMOUNT_INPUT_DIGIT_1) || 
         (theState == AMOUNT_INPUT_DIGIT_2) || 
         (theState == AMOUNT_INPUT_DIGIT_3) || 
         (theState == AMOUNT_INPUT_DIGIT_4) )
    {
      theView.setText("Bitte zuerst Karte entnehmen.");
      theView.setKartenButtonLabel("Karte entnehmen");
      setBankomatState(CARD_REMOVED);
    }
  }// end method

  /**
   *
   */
  public void pressButtonMoney()
  {
    if (theState == CASH_DISPENSE)
    {
      theView.setText("Auf Wiedersehen!");
      theView.setKartenButtonLabel("Karte einlegen");
      theView.setGeldladeText("");
      setBankomatState(IDLE);
      pinCode = 0;
      amount = 0;
    }
  }// end method

  /**
   *
   */
  public void pressButtonCard()
  {
    switch (theState)
    {
      case IDLE:
          theView.setKartenButtonLabel("Karte eingelegt");
          theView.setKartenText("Karte ist im Bankomat");
          cardInside = true;
          setBankomatState(CARD_INSERTED);
          theView.setText("Bitte geben Sie Ihre 4-stellige PIN ein");
        break;
      case PINCODE_CORRECT:
        theView.setKartenText("Kartenschacht leer");
        cardInside = false;
        setBankomatState(IDLE);
        pinCode = 0;
        amount = 0;
        theView.setKartenButtonLabel("Karte einlegen");
        theView.setText("Willkommen beim Bankomaten!");
        break;
      case CANCEL:
        theView.setKartenText("Kartenschacht leer");
        cardInside = false;
        setBankomatState(IDLE);
        theView.setKartenButtonLabel("Karte einlegen");
        theView.setText("Willkommen beim Bankomaten!");
      case CARD_REMOVED:
        theView.setKartenText("Kartenschacht leer");
        cardInside = false;
        if (amount > 0)
        {
          theView.setKartenButtonLabel("Karte entfernt");
          theView.setGeldladeText("Betrag: " + amount + " €");
          setBankomatState(CASH_DISPENSE);
          theView.setText("Bitte Geldbetrag aus Lade entnehmen.");         
        } 
        else
        {
          setBankomatState(IDLE);
          theView.setKartenButtonLabel("Karte einlegen");
          theView.setText("Willkommen beim Bankomaten!");
        }
        break;
      default:
        break;
    }
  } // end method
  
  /**
   * 
   * @param state 
   */
  private void setBankomatState (BankomatState state)
  {
    BankomatState oldState = theState;
    theState = state;
    
    Debug.debug(oldState, theState);
  }
} // end class
