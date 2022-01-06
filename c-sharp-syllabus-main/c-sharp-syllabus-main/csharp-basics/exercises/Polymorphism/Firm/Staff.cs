using System;

namespace Firm
{
    public class Staff
    {
        StaffMember[] staffList;

        public Staff()
        {
            staffList = new StaffMember[8];
            staffList[0] = new Executive("Sam", "123 Main Line",
                "555-0469", "123-45-6789", 2423.07);
            staffList[1] = new Employee("Carla", "456 Off Line",
                "555-0101", "987-65-4321", 1246.15);
            staffList[2] = new Employee("Woody", "789 Off Rocker",
                "555-0000", "010-20-3040", 1169.23);
            staffList[3] = new Hourly("Diane", "678 Fifth Ave.",
                "555-0690", "958-47-3625", 10.55);
            staffList[4] = new Volunteer("Norm", "987 Suds Blvd.",
                "555-8374");
            staffList[5] = new Volunteer("Cliff", "321 Duds Lane",
                "555-7282");
            staffList[6] = new Commision("Kristine", "Ranka dambis 7", "26577489", "210595-11298", 6.25, 0.2);
            staffList[7] = new Commision("Janis", "Ranka dambis 7", "29245767", "160592-18296", 9.75, 0.15);

            ((Executive) staffList[0]).AwardBonus(500.00);
            ((Hourly) staffList[3]).AddHours(40);
            ((Commision)staffList[6]).AddHours(35);
            ((Commision)staffList[6]).AddSales(400);
            ((Commision)staffList[7]).AddHours(40);
            ((Commision)staffList[7]).AddSales(950);
        }
        
        public void Payday()
        {
            foreach (var staff in staffList)
            {
                Console.WriteLine(staff);
                var amount = staff.Pay();
                if (amount == 0.00)
                    Console.WriteLine("Thanks!");
                else
                    Console.WriteLine("Paid: " + amount);
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadKey();
        }
    }
}