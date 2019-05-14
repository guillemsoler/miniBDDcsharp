using System;

namespace enterprise_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Program enterprise = new Program();
            int menu;

            Console.WriteLine("Intruduce 1 (add product), 2 (add client), 3(add manufacturer) ");
            menu = Convert.ToInt16(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    enterprise.Product();
                    break;
                case 2:
                    enterprise.Client();
                    break;
                case 3:
                    enterprise.Manufacturer();
                    break;
                
        }
            
        }
        private void Product()
        {
            Console.WriteLine("Introduce the product bar_code");
            Console.WriteLine("Introduce the product title");
            Console.WriteLine("Introduce the product manufacturer");
            Console.WriteLine("Introduce the product price");
        }
        private void Client()
        {
            Console.WriteLine("Introduce the client NIF");
            Console.WriteLine("Introduce the client name");
            Console.WriteLine("Introduce the client username");
            Console.WriteLine("Introduce the client password");
            Console.WriteLine("Introduce the client surname");
            Console.WriteLine("Introduce the client birth_date");
            Console.WriteLine("Introduce the client gender");
            Console.WriteLine("Introduce the client email");
            Console.WriteLine("Introduce the client phone");
            Console.WriteLine("Introduce the client credit_card");
        }
        private void Manufacturer()
        {
            Console.WriteLine("Introduce the manufacturer name");
        }
    }
}
