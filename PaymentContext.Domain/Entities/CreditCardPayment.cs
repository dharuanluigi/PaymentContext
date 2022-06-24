﻿namespace PaymentContext.Domain.Entities
{
  public class CreditCardPayment : Payment
  {
    public string CardHolderName { get; set; }

    public string CardNumber { get; set; }

    public string LastTransactionNumber { get; set; }

    public CreditCardPayment(
      string cardHolderName,
      string cardNumber,
      string lastTransactionNumber,
      DateTime paidDate,
      DateTime expireDate,
      decimal total, decimal
      totalPaid,
      string ownerPayer,
      string document,
      string address,
      string email) : base(paidDate, expireDate, total, totalPaid, ownerPayer, document, address, email)
    {
      CardHolderName = cardHolderName;
      CardNumber = cardNumber;
      LastTransactionNumber = lastTransactionNumber;
    }
  }
}