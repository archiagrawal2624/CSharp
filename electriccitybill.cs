using System;

namespace billcal
{
    class Calu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Electricity Bill Calculator");
            Console.WriteLine("----------------------------");

            Console.Write("Enter units consumed (in kWh): ");
            double unitsConsumed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter basic rate per unit: ");
            double basicRatePerUnit = Convert.ToDouble(Console.ReadLine());

            double governmentFreeUnits = 200; // 200 units are government free
            double freeUnits = Math.Min(unitsConsumed, governmentFreeUnits);
            double chargeableUnits = unitsConsumed - freeUnits;
            double ratePerUnit = GetTieredRate(chargeableUnits);
            double freeUnitsCharge =governmentFreeUnits * basicRatePerUnit;

           

            Console.Write("Enter periodic pending charges: ");
            double periodicPendingCharges = Convert.ToDouble(Console.ReadLine());

            double gstRate = 18;

            double extraCost = 10;

            double subTotal = chargeableUnits * ratePerUnit + freeUnitsCharge;
            double gstAmount = ( periodicPendingCharges*(extraCost/100)) * (gstRate / 100);
            double Extraunits=periodicPendingCharges*(extraCost/100);
            double totalBill = subTotal + periodicPendingCharges + gstAmount+Extraunits;

            PrintBreakdownOfCharges(unitsConsumed, freeUnits, chargeableUnits, ratePerUnit, periodicPendingCharges, gstRate, extraCost, freeUnitsCharge, totalBill, basicRatePerUnit);
        }

        static double GetTieredRate(double unitsConsumed)
        {
            if (unitsConsumed <= 200)
                return 10; 
            else if (unitsConsumed <= 300)
                return 11; 
            else if (unitsConsumed <= 400)
                return 12; 
            else
                return 13; 
        }

        static void PrintBreakdownOfCharges(double unitsConsumed, double freeUnits, double chargeableUnits, double ratePerUnit, double periodicPendingCharges, double gstRate, double extraCost, double freeUnitsCharge, double totalBill, double basicRatePerUnit)
        {
            Console.WriteLine("Breakdown of Charges:");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Units Consumed: {unitsConsumed} kWh");
            Console.WriteLine($"Government Free Units: {freeUnits} kWh");
            Console.WriteLine($"Chargeable Units: {chargeableUnits} kWh");
            Console.WriteLine($"Basic Rate per Unit (Government Free): {basicRatePerUnit:F2} per kWh");
            Console.WriteLine($"Government Free Units Charge: {freeUnitsCharge:F2}");
            Console.WriteLine($"Rate per Unit: {ratePerUnit:F2} per kWh");
            Console.WriteLine($"Periodic Pending Charges: {periodicPendingCharges:F2}");
            Console.WriteLine($"Extra Cost: ({extraCost}%)");
            Console.WriteLine($"Sub-Total: {(chargeableUnits * ratePerUnit + freeUnitsCharge):F2}");
            Console.WriteLine($"GST ({gstRate}%): {(periodicPendingCharges*(extraCost/100)) * (gstRate / 100):F2}");
            Console.WriteLine($"Total Bill: {totalBill:F2}");
        }
    }
}