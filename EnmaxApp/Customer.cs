namespace EnmaxApp
{
    //Declare private variables
    internal class Customer
    {
        // Properties
        private static int accountNumberCounter = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Corrected AccountNo property
        public int AccountNo { get; private set; }

        public double Kwh { get; set; }
        public decimal BillAmount { get; set; }

        // Constructor
        public Customer(string firstName, string lastName, double kwhUsed, decimal billamount)
        {
            AccountNo = GenerateAccountNumber(); // Calling Method to generate an account number.
            FirstName = firstName;
            LastName = lastName;
            Kwh = kwhUsed;
            BillAmount = UpdateBillAmount();
        }

        // Method to calculate the Kwh charge
        public double CalculateCharge()
        {
            return (Kwh * 0.07) + 12;
        }

        // Method to update BillAmount

        public decimal UpdateBillAmount()
        {
            return BillAmount = (decimal)CalculateCharge();
        }

        private int GenerateAccountNumber()
        {
            return ++accountNumberCounter;
        }

        //Override to display Cx information
        public override string ToString()
        {
            return $"{FirstName} {LastName} | kWh Used: {Kwh} | BillAmount: {BillAmount} | Account: {AccountNo}";
        }








    }





}
