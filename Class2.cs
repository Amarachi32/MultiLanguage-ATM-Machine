using System;

namespace ATM
{
    public class AtmMachine
    {

        public decimal Balance()
        {

            Console.WriteLine("Your AccountBalance is {0}", _amount);//
            return _amount;

        }


        public decimal Withdraw()
        {

            Console.WriteLine("input your account number");
            Console.WriteLine("select or enter amount not more than 20,000");
            string? inpur = Console.ReadLine();
            decimal MoneyToWithdraw = Convert.ToInt32(inpur);//check user input

            if (MoneyToWithdraw < _amount)
            {
                _amount -= MoneyToWithdraw;
                Console.WriteLine("Withdrwal successful \n your available balance is: {0}", _amount);//

            }
            return _amount;
        }

        public decimal Deposit()
        {
            Console.WriteLine("enter amount to deposit");
            decimal myDeposit = int.Parse(Console.ReadLine());
            if (myDeposit != null)
            {
                _amount += myDeposit;
                Console.WriteLine("Deposit of {0} is successful :  total : {1}", myDeposit, _amount);
            }
            else
            {
                Console.WriteLine("invalid");
                Deposit();
            }

            return _amount;
        }

        public decimal Transfer()
        {
            Console.WriteLine("input beneficiary account number");
            Console.ReadLine();
            Console.WriteLine("select beneficiary account name");
            Console.ReadLine();
            Console.WriteLine("enter amount to transfer");
            decimal AmountToTransfer = Convert.ToInt32(Console.ReadLine());

            if (AmountToTransfer < _amount)
            {
                _amount -= AmountToTransfer;
                Console.WriteLine("Transfer of {0} is successful :  total : {1}", AmountToTransfer, _amount);
            }

            return _amount;
        }



        public void AirtimeTopUp()
        {

        }
        public void ChangePin()
        {

        }



        private string _name;
        private string _accountNumber;
        private decimal _amount;

        public AtmMachine(decimal amount)
        {
            _amount = amount;
        }


    }

}
