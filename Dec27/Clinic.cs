using System;
class PatientBill
{
   public string BillId;
   public string PatientName;
   public bool HasInsurence;
   public double  ConsultationFee;
   public  double LabCharges;
   public double MedicineCharges;
   public double GrossAmount;
   public double DiscountAmount;
   public double FinalPayable;

   public static PatientBill LastBill;
   public static bool HasLastBill = false;

   public void CreateNewBill()
    {
        Console.WriteLine("Enter Bill ID: ");
        BillId=Console.ReadLine();
         if (string.IsNullOrWhiteSpace(BillId))
        {
            Console.WriteLine("Bill Id cannot be empty.");
            return;
        }
        Console.WriteLine("Enter Patient Name: ");
        PatientName=Console.ReadLine();
        Console.WriteLine("Is the Patient insured? (Y/N): ");
         string Insurence=Console.ReadLine();
        if(Insurence=="Y"||Insurence=="y")
            HasInsurence=true;
        else if(Insurence=="N"||Insurence=="n")
            HasInsurence=false;
        else
        {
            Console.WriteLine("Invalid insurance option.");
            return;
        }
        Console.WriteLine("Enter Consultation Fee: ");
        ConsultationFee=double.Parse(Console.ReadLine());
        if(ConsultationFee<=0){
        Console.WriteLine("Consultation fee must be greater than 0");
        return;
        }
        Console.WriteLine("Enter Lab Charges: ");
        LabCharges=double.Parse(Console.ReadLine());
         if(LabCharges<0){
        Console.WriteLine("Lab Charges must be greater than or equal to 0");
        return;
        }
        Console.WriteLine("Enter Medicine Charges: ");
        MedicineCharges=double.Parse(Console.ReadLine());
        if(MedicineCharges<0){
        Console.WriteLine("Medicine Charges must be greater than or equal to 0");
        return;
        }

        GrossAmount=ConsultationFee+LabCharges+MedicineCharges;

        if(HasInsurence)
            DiscountAmount=GrossAmount*0.10;
        else
            DiscountAmount=0;

        FinalPayable = GrossAmount - DiscountAmount;

        LastBill=this;
        HasLastBill=true;

        Console.WriteLine("Bill created successfully.");
        Console.WriteLine("Gross Amount: " + GrossAmount);
        Console.WriteLine("Discount Amount: " + DiscountAmount);
        Console.WriteLine("Final Payable: " + FinalPayable);
    

    }
     public static void ViewLastBill()
    {
        if(!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("----------- Last Bill -----------");
        Console.WriteLine("BillId: " + LastBill.BillId);
        Console.WriteLine("Patient: " + LastBill.PatientName);
        Console.WriteLine("Insured: " + (LastBill.HasInsurence ? "Yes" : "No"));
        Console.WriteLine("Consultation Fee: " + LastBill.ConsultationFee);
        Console.WriteLine("Lab Charges: " + LastBill.LabCharges);
        Console.WriteLine("Medicine Charges: " + LastBill.MedicineCharges);
        Console.WriteLine("Gross Amount: " + LastBill.GrossAmount);
        Console.WriteLine("Discount Amount: " + LastBill.DiscountAmount);
        Console.WriteLine("Final Payable: " + LastBill.FinalPayable);
        Console.WriteLine("--------------------------------");
    }
     public static void ClearLastBill()
    {
        LastBill=null;
        HasLastBill=false;
        Console.WriteLine("Last bill cleared.");
    }


}



