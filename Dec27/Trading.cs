using System;
namespace QuickMart{
class SaleTransaction
{
    public string InvoiceNo;
    public string CustomerName;
    public string ItemName;
    public int Quantity;
    public double PurchaseAmount;
    public double SellingAmount;
    public string ProfitOrLossStatus;
    public double ProfitOrLossAmount;
    public double ProfitMarginPercent;

    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction;

    public void CreateNewTransaction()
    {
        Console.WriteLine("Enter Invoice No: ");
        InvoiceNo=Console.ReadLine();
         if (string.IsNullOrWhiteSpace(InvoiceNo))
        {
            Console.WriteLine("Invoice No.cannot be empty.");
            return;
        }
        Console.WriteLine("Enter Customer Name: ");
        CustomerName=Console.ReadLine();
        Console.WriteLine("Enter Item Name: ");
        ItemName=Console.ReadLine();
        Console.WriteLine("Enter Quantity: ");
        Quantity=int.Parse(Console.ReadLine());
        if (Quantity <= 0)
        {
            Console.WriteLine("Quantity must be greater than 0");
            return;
        }
        Console.WriteLine("Enter Purchase Amount: (total)");
        PurchaseAmount=double.Parse(Console.ReadLine());
        if (PurchaseAmount <= 0)
        {
            Console.WriteLine("purchase Amount must be greater than 0");
            return;
        }
         Console.WriteLine("Enter Selling Amount: (total)");
        SellingAmount=double.Parse(Console.ReadLine());
        if (SellingAmount < 0)
        {
            Console.WriteLine("purchase Amount must be greater than or equal to 0");
            return;
        }
         CalculateProfitLoss();

        LastTransaction = this;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        PrintCalculation();
    }
     public void CalculateProfitLoss()
    {
        if (SellingAmount > PurchaseAmount)
        {
            ProfitOrLossStatus = "PROFIT";
            ProfitOrLossAmount = SellingAmount - PurchaseAmount;
        }
        else if (SellingAmount < PurchaseAmount)
        {
            ProfitOrLossStatus = "LOSS";
            ProfitOrLossAmount = PurchaseAmount - SellingAmount;
        }
        else
        {
            ProfitOrLossStatus = "BREAK-EVEN";
            ProfitOrLossAmount = 0;
        }

        ProfitMarginPercent = (ProfitOrLossAmount / PurchaseAmount) * 100;
    }
     public static void ViewLastTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        SaleTransaction t = LastTransaction;

        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine($"Invoice No: {t.InvoiceNo}");
        Console.WriteLine($"Customer: {t.CustomerName}");
        Console.WriteLine($"Item: {t.ItemName}");
        Console.WriteLine($"Quantity: {t.Quantity}");
        Console.WriteLine($"Purchase Amount: {t.PurchaseAmount}");
        Console.WriteLine($"Selling Amount: {t.SellingAmount}");
        Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount}");
        Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent}");
        Console.WriteLine("--------------------------------------------");
    }
 public static void RecalculateAndPrint()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        LastTransaction.CalculateProfitLoss();
        LastTransaction.PrintCalculation();
    }
     public void PrintCalculation()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"Status: {ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
        Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent}");
        Console.WriteLine("------------------------------------------------------");
    }

        }
}