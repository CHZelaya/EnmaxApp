namespace EnmaxApp
{
    //Declare private variables
    internal class Customer
    {
        private string firstName;
        private string lastName;
        private int accountNo;
        private double kwhused;
        private decimal billamount;




        //Constructor

        public Customer(string firstName, string lastName, int accountNo, double kwhUsed, decimal billamount)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.accountNo = accountNo;
            this.kwhused = kwhUsed;
            this.billamount = billamount;

        }


        //Getters and Setters
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }

        }

        public double Kwh
        {
            get { return kwhused; }
            set { kwhused = value; }
        }

        public decimal BillAmount
        {
            get { return billamount; }
            set { billamount = value; }
        }

        // Method to calculate the Kwh charge
        public double CalculateCharge()
        {
            return (kwhused * 0.07) + 12;
        }

        // Method to update BillAmount

        public void UpdateBillAmount()
        {
            BillAmount = (decimal)CalculateCharge();
        }

        //Override to display Cx information
        public override string ToString()
        {
            return $"{FirstName} {lastName} | kWh Used: {kwhused} | BillAmount: {billamount} | Account: {accountNo}";
        }








    }





}
