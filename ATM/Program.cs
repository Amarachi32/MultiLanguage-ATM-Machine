namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RegistrationClass register = new RegistrationClass();
            register.PinCollection();
            MultiLanguage();
        }
        public static void MultiLanguage()
        {
            while (true)
            {

                Console.WriteLine("select any language of your Choice or q to cancel: \n if English press 1 \n if you want igbo press 2 \n if you want Chinese press 3 ");
                var input = Console.ReadLine().ToLower();
                if (input == "q")
                {
                    break;
                }


                try
                {
                    int languageselect = int.Parse(input);

                    switch (languageselect)
                    {
                        case 1:
                            English();
                            break;
                        case 2:
                            Igbo();
                            break;
                        case 3:
                            Chinese();
                            break;
                        default:
                            MultiLanguage();
                            break;
                    }


                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                /*catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }*/
                finally
                {
                    Console.WriteLine("enter correct format");
                }
            }




        }
        private static void English()
        {
           // RegistrationClass register = new RegistrationClass();
           

            AtmClass.AtmMachine atm = new(2000);
            Console.WriteLine("pls enter your name!");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}", userName);



            bool session = true;
            while (session)
            {
                Console.WriteLine("select Option (Please select either 1, 2 or 3 for now): \n press 1 for Withdrawal  \n press 2 for Deposit \n  press 3 for Balance check  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to Transfer money");//checkmate their choice
                try
                {
                    int ActivityOption = int.Parse(Console.ReadLine());
                    switch (ActivityOption)
                    {
                        case 1:
                            atm.Withdraw();
                            break;
                        case 2:
                            atm.Deposit();
                            break;
                        case 3:
                            atm.Balance();
                            break;
                        case 4:
                            atm.ChangePin();
                            break;
                        case 5:
                            atm.AirtimeTopUp();
                            break;
                        case 6:
                            atm.Transfer();
                            break;
                        default:
                            Console.WriteLine("invalid");
                            break;

                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }

        }
        private static void Igbo()
        {
            //RegistrationClass register = new();

            AtmClass.AtmMachine atm = new(2000);
            Console.WriteLine("Tinye Afa Gi!");
            string input = Console.ReadLine();
            //checked if it is InvalidCastException
            Console.WriteLine("Daalu {0}", input);//call the user here



            bool session = true;
            while (session)
            {
                Console.WriteLine("horo ihe i choro ime: \n tinye 1 ka i were ego  \n tinye 2 itinye ego \n  tinye 3 i mata ego ole i nwere  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to deposit money");//checkmate their choice
                int ActivityOption = int.Parse(Console.ReadLine()); 
                switch (ActivityOption)
                {
                    case 1:
                        atm.Withdraw();
                        break;
                    case 2:
                        atm.Deposit();
                        break;
                    case 3:
                        atm.Balance();
                        break;
                    case 4:
                        atm.ChangePin();
                        break;
                    case 5:
                        atm.AirtimeTopUp();
                        break;
                    case 6:
                        atm.Transfer();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }
        }
        private static void Chinese()
        {
           // RegistrationClass register = new();
            AtmClass.AtmMachine atm = new(2000);
            Console.WriteLine("nín shì wǒ men de hào mǎ");
            //var atm = new AtmMachine();
            Console.WriteLine("qǐng shū rù nín de míng zì！");
            Console.ReadLine();
            //checked if it is InvalidCastException
            Console.WriteLine("huān yíng  {0}");//call the user here



            bool session = true;
            while (session)
            {
                Console.WriteLine("xuǎn zé xuǎn xiàng: \n àn 1 tuì chū  \n àn 2 jìn xíng chuán shū \n  àn 3 jìn xíng yú é jiǎn chá  \n press 4 for Airtime top up \n press 5 to change pin \n press 6 to deposit money");//checkmate their choice
                int ActivityOption = int.Parse(Console.ReadLine()); //.ConvertToInt32()
                                                                    //bool sucess = Int32.TryParse(Console.ReadLine(), out ActivityOption);
                switch (ActivityOption)
                {
                    case 1:
                        atm.Withdraw();
                        break;
                    case 2:
                        atm.Transfer();
                        break;
                    case 3:
                        atm.Balance();
                        break;
                    case 4:
                        atm.ChangePin();
                        break;
                    case 5:
                        atm.AirtimeTopUp();
                        break;
                    case 6:
                        atm.Deposit();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("press \"Y\" to continue");
                string? input2 = Console.ReadLine();
                if (input2.ToUpper() != "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for banking with us");
                    session = false;

                }
            }
        }
    }




}