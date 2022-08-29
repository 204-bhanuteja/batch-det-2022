using ConsoleAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
    internal class errorexception
    {
        public static void Main()
        {
            try
            {
                ConsoleAppDemo.Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                                  // Console.WriteLine(m.Print());

                ConsoleAppDemo.Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                ConsoleAppDemo.Emp e1 = new ConsoleAppDemo.Emp(1, "Jiyana", new DateTime(2020, 1, 5));
                //Console.WriteLine(e1.Print());

                Console.WriteLine("enter empid b.w 1001 - 25000");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id < 1001 || id > 25000)
                    throw new InvalidEmpIdException("Entered empid is not in the range...");

                Console.WriteLine("enter emp name");
                string name = Console.ReadLine();

                Console.WriteLine("enter doj");
                DateTime doj = DateTime.Parse(Console.ReadLine());

                ConsoleAppDemo.Emp e2 = new(id, name, doj);


                List<ConsoleAppDemo.Emp> list = new List<ConsoleAppDemo.Emp>();
                list.Add(m);
                list.Add(m1);
                list.Add(e1);
                foreach (ConsoleAppDemo.Emp x in list)
                    Console.WriteLine(x.Print());
            }
            catch (InvalidEmpIdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { }

        }
    }
}
