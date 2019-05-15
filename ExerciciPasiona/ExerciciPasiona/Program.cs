using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciPasiona
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
            int menu = 0;


            using (var db = new enterpriseEntities())
            {

                menu = SelectOption(menu);

                switch (menu)
                {
                    case 1:
                        db.products.Add(Product());
                        db.SaveChanges();
                        menu = SelectOption(menu);
                        break;
                    case 2:
                        db.customers.Add(Client());
                        db.SaveChanges();
                        menu = SelectOption(menu);
                        break;
                    case 3:

                        db.manufacturers.Add(Manufacturer());
                        menu = SelectOption(menu);
                        break;
                    case 4:
                            
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Key error, introduce 1/2/3/4");
                        menu = SelectOption(menu);
                        break;
                }

            }
            
        }
        private int SelectOption(int menu)
        {

            Console.WriteLine("Intruduce 1 (add product), 2 (add client), 3(add manufacturer), 4(add order), 5(exit) ");
            menu = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            return menu;
        }
        private static products Product()
        {
            String titleV = "a";
            int manufacturerV = 0;
            decimal priceV = 0;

            Console.WriteLine("Introduce the product title");
            titleV = Console.ReadLine();
            Console.WriteLine("Introduce the product manufacturer");
            manufacturerV = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduce the product price");
            priceV = Convert.ToInt32(Console.ReadLine());
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
            String phoneV = "";
            String credit_cardV = "";

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

            /*return new orders
            {
                name = nameV,
                municipality = municipalityV
            };
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


                }*/

    }
}


