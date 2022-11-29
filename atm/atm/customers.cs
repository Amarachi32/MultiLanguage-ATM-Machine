using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class customers
    {
        private int _pin;//abstract
        public int Pin { get { return _pin; } set { _pin = value; } }
        public string Name { get; set; }
        public int AccountNumber { get; set; }

        public List<customers> PinBox;
        public customers()
        {
            PinBox = new List<customers>();
            //PinBox.Add(Pin);
            //Collection();
        }
        //public abstract void CutomerDetails();

    }

    public class EsteemedCustomer : customers
    {

        public  void CutomerDetails()//override
        {
          enter:

            Console.WriteLine("Please enter first name:");
            try
            {
                Name = Convert.ToString(Console.ReadLine());
                if(string.IsNullOrEmpty(Name) )
                {
                    Console.WriteLine("your name is required");
                    goto enter;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto enter;
            }

            Console.WriteLine("Please enter 4 digit pin:");
         enterpin:
            string Pin = Console.ReadLine();


            if (Pin.Length == 4 && int.TryParse(Pin, out int pinNumber))
            {
                if (!PinBox.Contains(new customers
                {
                    Name = Name,
                    AccountNumber = AccountNumber,
                    Pin = pinNumber,
                })) {
                    Console.WriteLine("Pin not recognized");

                    Console.WriteLine("press enter to Register your Pin");
                    Console.ReadKey();
                    register();

                    //SelectLanguage();
                }
                else {
                    Console.WriteLine("\nLogin successful\n");
                    Console.WriteLine($"\nWelcome back....\n");
                }

                //return pinNumber;
            }
            else
            {
                Console.WriteLine("invalid input: try again");
                goto enterpin;
            }

            throw new NotImplementedException();

            //Console.WriteLine("Customer Id: {0}", Pin);
            //Console.WriteLine("First Name: {0}", Name);
        }
        public void collection()
        {
            List<customers> pinBox = new List<customers>();
            pinBox.Add(new customers
            {
                Name = Name,
                AccountNumber = AccountNumber,
                Pin = Pin,
            });
            foreach (var customers in pinBox)
            {
                Console.WriteLine(customers);
            }
        }
        public void register()
        {

            Console.WriteLine("Enter new 4 digit pin:");
        //Pin = Convert.ToInt32(Console.ReadLine());
        enterpin:
            string Pin = Console.ReadLine();


            if (Pin.Length == 4 && int.TryParse(Pin, out int pinNumber))
            {

                PinBox.Add(new customers
                {
                    Name = Name,
                    AccountNumber = AccountNumber,
                    Pin = pinNumber,
                }); //add to list
                Console.WriteLine("registration Successful");
                Console.WriteLine("press enter to login");
                Console.ReadKey();
                Console.Clear();

            //login

            //Pin = Convert.ToInt32(Console.ReadLine());
            loginpin:
                Console.WriteLine("login with 4 digit pin:");
                int pass = Convert.ToInt32(Console.ReadLine());
                if (pass == pinNumber)
                {
                    Console.WriteLine("login successful");
                    Console.WriteLine("\n Welcome Awesome Person \n press enter to carryout your transaction");
                    Console.ReadKey();
                    entryPoint();
                    SelectLanguage();
                }
                else
                {
                    //Console.Clear();

                    Console.WriteLine("Pin mismatched");
                    goto loginpin;

                }

                //return pinNumber;


            }
            else
            {
                Console.WriteLine("invalid input");
                goto enterpin;
            }
        }


        static void entryPoint()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Genesys ATM\n");
            Console.WriteLine("Choose your preferred language\n Horo Asusu i choro \nWählen Sie Ihre bevorzugte Sprache");
            Console.WriteLine("\nPress\\pia\\Drücken Sie \n\n1. English\n\n2. Igbo\n\n3. German\n");

        }
        public void SelectLanguage()
        {
        SelectLanguage:
            
            try
            {
               string  action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        EnglishLanguage AtmEng = new EnglishLanguage();
                        break;
                    case "2":
                        IgboLanguage AtmIgbo = new IgboLanguage();
                        break;
                    case "3":
                         //GermanLanguage AtmGerman = new GermanLanguage();
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        goto SelectLanguage;
                }
                if (string.IsNullOrEmpty(action) && (action != "1" || action != "2" || action != "3"))
                {
                    //Console.WriteLine("invalid input");
                    goto SelectLanguage;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

/*        public void login(){
        loginpin:
            Console.WriteLine("login with 4 digit pin:");
            int pass = Convert.ToInt32(Console.ReadLine());
            if (pass == pinNumber)
            {
                Console.WriteLine("login successful");
                Console.WriteLine("\n Welcome Awesome Person \n press enter to carryout your transaction");
                Console.ReadKey();
                entryPoint();
                SelectLanguage();
            }
            else
            {
                //Console.Clear();

                Console.WriteLine("Pin mismatched");
                goto loginpin;

            }
        }*/
    }

    /*public class Users(){

    }*/


}
