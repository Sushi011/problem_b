using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Rate = 0;
            double NumberOfDays;
            double Refri = 0;
            double CostOfStay;
            double CostOfBed = 0;
            String AvailRefrigerator;
            String AvailExtraBed;
            String GetRoomType = "";
            String RoomType;

            Console.WriteLine("Welcome to Easy Living Resort Hotel");
            Console.WriteLine("--------------------------------------------");
        //Display Menu
            Console.WriteLine("Room Type\t\t\tDaily Rate\n");
            Console.WriteLine("G- Garden Pool View\t\t$ 125.00");
            Console.WriteLine("P- Pool View\t\t\t$ 145.00");
            Console.WriteLine("L- Lake Veiw\t\t\t$ 185.00");

         //Ask for Room Type 
            Console.Write("Please select your room type: ");
            RoomType = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------");
           
            if (RoomType == "G" || RoomType == "g")
            {
                Rate = 125;
                GetRoomType = "Garden Pool View";
            }
            else if (RoomType == "P" || RoomType == "p")
            {
                Rate = 145;
                GetRoomType = "Pool View";
            }
            else if (RoomType == "L" || RoomType == "L")
            {
                Rate = 185;
                GetRoomType = "Lake View";
            }
            else
            {
                Console.WriteLine("Envalid input");
            }

            int GetRate = Convert.ToInt32(Rate);
            String GetRoom = Convert.ToString(GetRoomType);

         //Ask for Number of Days staying 
            Console.Write("Number of Days Staying: ");
            NumberOfDays = Convert.ToInt32(Console.ReadLine());
            CostOfStay = GetRate * NumberOfDays;

         //Ask for Reff in the room
            Console.Write("Would you want a Refrigerator in the room? [ Yes ][ No ] ");
            AvailRefrigerator = Console.ReadLine();

            if (AvailRefrigerator == "Yes" || AvailRefrigerator == "yes")
            {
                Refri = 2.50;
            }
            else if (AvailRefrigerator == "No" || AvailRefrigerator == "no")
            {
                Refri = 0.00;
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            double GetRef = Convert.ToDouble(Refri);
            double RefCost = GetRef * NumberOfDays;

         //Ask for Extra Bed 
            Console.Write("Would you want an Extra Bed in the Room? [Yes][No] ");
            AvailExtraBed = Console.ReadLine();

            if (AvailExtraBed == "Yes" || AvailExtraBed == "yes")
            {
                if (RoomType == "G" || RoomType == "g")
                {
                    CostOfBed = 15.00;
                }
                else if (RoomType == "P" || RoomType == "p")
                {
                    CostOfBed = 15.00;
                }
                else if (RoomType == "L" || RoomType == "l")
                {
                    CostOfBed = 20.00;
                }
            }
            else if (AvailExtraBed == "No" || AvailExtraBed == "no")
            {
                CostOfBed = 0.00;
            }
        //Computation for Bed and total
            double GetCostOfBed = Convert.ToDouble(CostOfBed);
            double Bed = GetCostOfBed * NumberOfDays;
            double GetTotal = CostOfStay + RefCost + Bed;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");

         //Recipt 
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Room Type: ");
            Console.WriteLine("\n\t" + GetRoomType + "\t {0}", String.Format ( "{0:C} ", CostOfStay));
            Console.WriteLine("\tRefrigerator\t\t {0} ", String.Format( "{0:C} ", RefCost));
            Console.WriteLine("\tExtra Bed\t\t {0} ", String.Format("{0:C} ", Bed));
            Console.WriteLine("\tNumber of Days\t\t {0} ", String.Format ( "{0:C} ", NumberOfDays));

            Console.WriteLine("\tYour Total Bill is\t {0} ", String.Format("{0:C} ", GetTotal));

            Console.ReadKey();
        }
    }
}
