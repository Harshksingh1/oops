 using System;
 namespace QuickMart{
 class Program{
    public static void Main (string[] args){
        
        // bool run = true;

        // while (run)
        // {
        //     Console.WriteLine("================== MediSure Clinic Billing ==================");
        //     Console.WriteLine("1. Create New Bill (Enter Patient Details)");
        //     Console.WriteLine("2. View Last Bill");
        //     Console.WriteLine("3. Clear Last Bill");
        //     Console.WriteLine("4. Exit");
        //     Console.Write("Enter your option: ");

        //     string choice = Console.ReadLine();
        //     Console.WriteLine();
        //     switch (choice)
        //     {
        //         case "1":
        //             PatientBill bill = new PatientBill();
        //             bill.CreateNewBill();
        //             break;

        //         case "2":
        //             PatientBill.ViewLastBill();
        //             break;

        //         case "3":
        //             PatientBill.ClearLastBill();
        //             break;

        //     }
        //     if (choice == "4")
        //     {
        //         Console.WriteLine("Thank You. Application Closed Normally");
        //         break;
        //     }
        // }

        bool run = true;

        while (run)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SaleTransaction st = new SaleTransaction();
                    st.CreateNewTransaction();
                    break;

                case "2":
                    SaleTransaction.ViewLastTransaction();
                    break;

                case "3":
                    SaleTransaction.RecalculateAndPrint();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                    break;
            }
        }

    }
 }
 }