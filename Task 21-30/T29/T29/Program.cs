using System;
using System.Collections.Generic;

public interface ITransaction
{
    string ShowTransaction();
    float Money { get; set; }
}

public class PaidWithCash : ITransaction
{
    public int BillNumber { get; }
    public DateTime Date { get; }
    public float Money { get; set; }

    public PaidWithCash(int billNumber, DateTime date, float money)
    {
        BillNumber = billNumber;
        Date = date;
        Money = money;
    }

    public string ShowTransaction()
    {
        return $"Paid with cash: bill number {BillNumber} date {Date.ToShortDateString()} amount {Money} Euros";
    }
}

public class PaidWithCard : ITransaction
{
    public string CardNumber { get; }
    public DateTime Date { get; }
    public float Money { get; set; }

    public PaidWithCard(string cardNumber, DateTime date, float money)
    {
        CardNumber = cardNumber;
        Date = date;
        Money = money;
    }

    public string ShowTransaction()
    {
        return $"Transaction to bank: charge from card {CardNumber} date {Date.ToShortDateString()} amount {Money} Euros";
    }
}

public class CashRegister
{
    private float cashBalance = 0;
    private float cardTotal = 0;
    private float cashTotal = 0;
    private List<ITransaction> transactions = new List<ITransaction>();

    public void ProcessTransaction(ITransaction transaction)
    {
        transactions.Add(transaction);

        if (transaction is PaidWithCash cashTransaction)
        {
            cashBalance += cashTransaction.Money;
            cashTotal += cashTransaction.Money;
        }
        else if (transaction is PaidWithCard cardTransaction)
        {
            cardTotal += cardTransaction.Money;
        }
    }

    public float ShowTotalSales()
    {
        return cashTotal + cardTotal;
    }

    public float ShowCashBalance()
    {
        return cashBalance;
    }
}

class Program
{
    static void Main()
    {
        CashRegister cashRegister = new CashRegister();

        PaidWithCard cardPayment1 = new PaidWithCard("0001-0002", DateTime.Parse("2020-01-01"), 78.95f);
        PaidWithCard cardPayment2 = new PaidWithCard("0003-0004", DateTime.Parse("2020-01-01"), 45.65f);
        PaidWithCash cashPayment1 = new PaidWithCash(1, DateTime.Parse("2020-01-01"), 100f);
        PaidWithCash cashPayment2 = new PaidWithCash(2, DateTime.Parse("2020-01-01"), 50f);

        cashRegister.ProcessTransaction(cardPayment1);
        cashRegister.ProcessTransaction(cardPayment2);
        cashRegister.ProcessTransaction(cashPayment1);
        cashRegister.ProcessTransaction(cashPayment2);

        Console.WriteLine(cardPayment1.ShowTransaction());
        Console.WriteLine(cardPayment2.ShowTransaction());
        Console.WriteLine($"Total money at bank account: {cashRegister.ShowCashBalance()}");

        Console.WriteLine(cashPayment1.ShowTransaction());
        Console.WriteLine(cashPayment2.ShowTransaction());
        Console.WriteLine($"Total money in cash: {cashRegister.ShowCashBalance()}");

        float totalSales = cashRegister.ShowTotalSales();
        Console.WriteLine($"Total sales today {DateTime.Now.ToString("D")} is {totalSales:F2} Euros");

        Console.WriteLine("Program completed successfully. Press any key to quit.");
        Console.ReadKey();
    }
}
