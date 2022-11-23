namespace ATM
{
    internal class RegistrationClass
    {

        public List<int> Pin;
        public void PinCollection()
        {
            Pinbag pass = new();
            Console.WriteLine("enter four digit pin");
            int input = int.Parse(Console.ReadLine());

            List<int> Pin = new List<int>() { 1111, 2222, 3333 };
           
                if (!Pin.Contains(input))
                {
                    Console.Clear();
                    Console.WriteLine("please register your pin");
                    register();

                }
           
            Console.WriteLine("login sucessfull");
        }
        /*        public RegistrationClass()
                {
                    Pin = new List<int>();
                }*/
        public void register()
        {
            Pinbag pass = new();
            Console.WriteLine("enter your username");
            string user = Console.ReadLine();
            Console.WriteLine("welcome {0}", user);

            Console.WriteLine("enter four digit number");
            string input = Console.ReadLine();
            if (input.Length != 4)
            {
                Console.WriteLine("invalid input");
            }
            else
            {

                int num = int.Parse(input);
                pass.AddPin(num);
                //pass.AddPin(Pin.Add(num));

                Console.WriteLine("registration successful");
            }
        }
       

    }
    class Pinbag
    {
        public Pinbag()
        {
            Pin = new List<int>();
        }
        public void AddPin(int num1)
        {
            Pin.Add(num1);
            //Console.WriteLine("successful");
            //Pin.
        }
        List<int> Pin;

    }
}
