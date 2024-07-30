using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IProgram
    {
         void Ready();
         void Ready2();
    }

    class Ready_Van:IProgram
    {
        public static int Counter = 0;
        bool option;
        
        public  void Ready()
        {
            var GoingVan = Van.vanList.FirstOrDefault(b => b.Station == "Rawalpindi" && (b.Technology == "EFI" || b.Technology == "Euro"));
            Console.WriteLine("\n" + GoingVan.Num + "   " + GoingVan.Model + "    " + GoingVan.Technology + "    " + GoingVan.Station);

            while (!option)
            {
                Console.WriteLine("\nTotal Passengers are : " + Counter);
                Console.WriteLine("\nAre you Passenger : ");
                var input = Console.ReadLine();
                if (String.Equals("Yes", input, StringComparison.OrdinalIgnoreCase))
                {
                    if (Counter <= 15)
                    {
                        Console.WriteLine(Counter++ + " Paasenger");
                        
                    }
                    else
                    {
                        Console.WriteLine("This Van is Full And Ready To Go");
                        Counter = 0;
                        option = true;
                        Van.vanList.Remove(GoingVan);
                        break;
                        //return null;
                    }


                }


            }

        }

        public void Ready2()
        {
            var GoingVan2 = Van.vanList.FirstOrDefault(b => b.Station == "Rawalpindi");

            Console.WriteLine("\n" + GoingVan2.Num + "   " + GoingVan2.Model + "    " + GoingVan2.Technology + "    " + GoingVan2.Station);

            while (!option)
            {
                Console.WriteLine("\nTotal Passengers are : " + Counter);
                Console.WriteLine("\nAre you Passenger : ");
                var input = Console.ReadLine();
                if (String.Equals("Yes", input, StringComparison.OrdinalIgnoreCase))
                {
                    if (Counter <= 15)
                    {
                        Console.WriteLine(Counter++ + " Paasenger");
                    }
                    else
                    {
                        Console.WriteLine("This Van is Full And Ready To Go");
                        Counter = 0;
                        option = true;
                        Van.vanList.Remove(GoingVan2);
                        break;
                    }


                }


            }

        }





    }


   
}
