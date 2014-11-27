package at.fhb.iti.algodat.ue2.bankomat.model;

public enum BankomatState
{
  IDLE,
  CANCEL,
  PINCODE_INPUT_DIGIT_1,
  PINCODE_INPUT_DIGIT_2,
  PINCODE_INPUT_DIGIT_3,
  PINCODE_INPUT_DIGIT_4,
  PINCODE_CORRECT,
  AMOUNT_INPUT_DIGIT_1,
  AMOUNT_INPUT_DIGIT_2,
  AMOUNT_INPUT_DIGIT_3,
  AMOUNT_INPUT_DIGIT_4,
  CARD_INSERTED,
  CARD_REMOVED,
  CASH_DISPENSE;
}
