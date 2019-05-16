using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class Program
    {
        static void Main(string[] args)
        {
            Program enterprise = new Program();
            enterprise.Controller();


        }

        private void Controller()
        {
            int menu;
           

            using (var db = new enterpriseEntities())
            {

                menu = SelectOption();

                do
                {
                    switch (menu)
                    {
                        case 1:
                            db.products.Add(Product());
                            db.SaveChanges();
                            break;
                        case 2:
                            db.customers.Add(Client());
                            db.SaveChanges();
                            break;
                        case 3:

                            db.manufacturers.Add(Manufacturer());
                            db.SaveChanges();
                            break;
                        case 4:
                            MostrarProductes();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Key error, introduce 1/2/3/4");
                            break;
                    }
                    menu = SelectOption();
                } while (menu!=5);

            }

        }
        private int SelectOption()
        {
            int menu;

            Console.WriteLine("Intruduce 1 (add product), 2 (add client), 3(add manufacturer), 4(show product), 5(show  5(exit) ");
            menu = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            return menu;
        }
        private static products Product()
        {
            String titleV = "a";
            int manufacturerV = 0;
            decimal priceV = 0;

            try
            {
            Console.WriteLine("Introduce the product title");
            titleV = Console.ReadLine();
            Console.WriteLine("Introduce the product manufacturer");
            manufacturerV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce the product price");
            priceV = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Incorrect value");
                System.Threading.Thread.Sleep(1200);
                Console.Clear();
                Product();
            }
            Console.Clear();
            Console.WriteLine("Added succesfully");
            System.Threading.Thread.Sleep(600);
            Console.Clear();

            return new products
            {
                title = titleV,
                manufacturer = manufacturerV,
                price = priceV
            };
        }
        private static customers Client()
        {
            String nifV = "";
            String nameV = "";
            String surnameV = "";
            DateTime birth_dateV = Convert.ToDateTime("01/01/2000");
            String genderV = "";
            String emailV = "";
            String phoneV;
            String credit_cardV;

            Console.WriteLine("Introduce the client NIF");
            nifV = Console.ReadLine();
            Console.WriteLine("Introduce the client name");
            nameV = Console.ReadLine();
            Console.WriteLine("Introduce the client surname");
            surnameV = Console.ReadLine();
            Console.WriteLine("Introduce the client birth_date");
            birth_dateV = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Introduce the client gender");
            genderV = Console.ReadLine();
            Console.WriteLine("Introduce the client email");
            emailV = Console.ReadLine();
            Console.WriteLine("Introduce the client phone");
            phoneV = Console.ReadLine();
            Console.WriteLine("Introduce the client credit_card");
            credit_cardV = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Added succesfully");
            System.Threading.Thread.Sleep(600);
            Console.Clear();

            return new customers
            {
                nif = nifV,
                name = nameV,
                surname = surnameV,
                birth_date = birth_dateV,
                gender = genderV,
                email = emailV,
                phone_number = phoneV,
                credit_card = credit_cardV
            };
        }
        private static manufacturers Manufacturer()
        {
            String nameV = " ";
            String municipalityV = " ";

            Console.WriteLine("Introduce the manufacturer name");
            nameV = Console.ReadLine();
            Console.WriteLine("Introduce the manufacturer municipality");
            municipalityV = Console.ReadLine();
            Console.WriteLine("Added succesfully");
            System.Threading.Thread.Sleep(600);
            Console.Clear();

            return new manufacturers
            {
                name = nameV,
                municipality = municipalityV
            };
        }
        /*
        private static buys Buy()
        {
            String productV = " ";
            String customerV = " ";
            DateTime buyDateV = Convert.ToDateTime(Console.ReadLine());
            String units = " ";



            Console.WriteLine("Introduce the manufacturer name");
            nameV = Console.ReadLine();
            Console.WriteLine("Introduce the manufacturer municipality");
            municipalityV = Console.ReadLine();
            Console.WriteLine("Added succesfully");
            System.Threading.Thread.Sleep(600);
            Console.Clear();

            return new orders
            {
                name = nameV,
                municipality = municipalityV
            };
               */
        private void MostrarProductes()
        {
            using (var db = new enterpriseEntities())
            {
                var query = from ms in db.manufacturers
                            select ms;

                foreach (manufacturers manufacture in query)

                {

                    Console.Write(manufacture.id_manufacturer + " " + manufacture.name);

                    Console.WriteLine();

                }

                Console.Write("Press any key to return menu: ");
                Console.ReadKey();

                Console.Clear();

            }
        }

        
    }
}
