﻿using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public class PayPalPayment : Payment
  {
    public string TransactionCode { get; set; }

    public PayPalPayment(
      string transactionCode,
      DateTime paidDate,
      DateTime expireDate,
      decimal total,
      decimal totalPaid,
      string ownerPayer,
      Document document,
      Address address,
      Email email) : base(paidDate, expireDate, total, totalPaid, ownerPayer, document, address, email)
    {
      TransactionCode = transactionCode;
    }
  }
}