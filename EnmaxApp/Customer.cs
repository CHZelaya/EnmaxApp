namespace EnmaxApp
{
    internal class Customer
    {
        // Properties
        private static int accountNumberCounter = 0;
        private static int totalCustomers = 0;
        private static decimal averageBill = 0m;
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

            totalCustomers++;
            averageBill += BillAmount;
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

        //Method to Generate an Account Number
        private static int GenerateAccountNumber()
        {
            return ++accountNumberCounter;
        }

        // Method to get the total number of customers
        public static int GetTotalCustomers()
        {
            return totalCustomers; // Return the total number of customers
        }

        // Method to generate the average bill.
        public static decimal GenerageAverageBill()
        {

            return (averageBill / totalCustomers);
        }

        //Override to display Cx information
        public override string ToString()
        {
            return $"{FirstName} {LastName} | kWh Used: {Kwh} | Account: {AccountNo}";
        }








    }





}
