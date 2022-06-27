﻿using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public class BoletoPayment : Payment
  {
    public string BarCode { get; set; }

    public string BoletoNumber { get; set; }

    public BoletoPayment(
      string barCode,
      string boletoNumber,
      DateTime paidDate,
      DateTime expireDate,
      decimal total,
      decimal totalPaid,
      string ownerPayer,
      Document document,
      Address address,
      Email email
      ) : base(paidDate, expireDate, total, totalPaid, ownerPayer, document, address, email)
    {
      BarCode = barCode;
      BoletoNumber = boletoNumber;
    }
  }
}