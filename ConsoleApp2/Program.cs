using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
   
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                     Welcome to Bus Terminal          ");
            Console.WriteLine("------------------------------------------------------");
            while (true)
            {

                Console.WriteLine("Your Are Driver or Passenger");
                var input = Console.ReadLine();
                var readyVan = new Ready_Van();
                switch (input)
                {
                    case "Driver":
                        Console.WriteLine("Please enter the Van Details ");
                        Console.WriteLine("Enter the Registration Number : ");
                        var num = Console.ReadLine();
                        Console.WriteLine("Enter the Model of Van : ");
                        var model = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Technology : ");
                        var tech = Console.ReadLine();
                        Console.WriteLine("Enter the Next Station : ");
                        var Station = Console.ReadLine();
                        Van.vanList.Add(new Van(num, model, tech, Station));
                        //Van.vanList.Add(new Van(num, model, tech));

                        String path = @"D:Vehicles.txt";
                        using (FileStream filestream = new FileStream(path, FileMode.Append))
                        {
                            using (StreamWriter writer = new StreamWriter(filestream))
                            {
                                foreach (var z in Van.vanList)
                                {
                                    writer.Write("\n" + z.Num + "  " + z.Model + "   " + z.Technology + "    " + z.Station);
                                }
                            }
                        }
                        break;

                    case "Passenger":
                        Console.WriteLine("\n Rainy Day or Sunny Day");
                        var option = Console.ReadLine();
                        switch (option)
                        {
                            case "Rainy":
                                if (Van.vanList == null)
                                {
                                    Console.WriteLine("\nSorry There is No Van Avilible");
                                }
                                else if (Van.vanList != null)
                                {
                                    
                                    readyVan.Ready();
                                }
                                break;

                            case "Sunny":
                                if (Van.vanList == null)
                                {
                                    Console.WriteLine("\nSorry There is No Van Avilible");
                                }
                                else if (Van.vanList != null)
                                {
                                    readyVan.Ready2();
                                }
                                break;

                            default:
                                Console.WriteLine("\nYour Enter invalid Option");
                                break;
                        }
                        break;

                    case "Vans":
                        foreach(var a in Van.vanList)
                        {
                            Console.WriteLine("\n" + a.Num + "   " + a.Model + "    " +a.Technology + "    " + a.Station);

                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }


            }

            Console.Read();
           

        }
    }
}
