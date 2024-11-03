namespace EnmaxApp
{

    public partial class EnMaxGUI : Form
    {
        const int TOTAL_CUSTOMERS = 0;
        double TOTAL_KWH = 0;
        const decimal AVERAGE_BILL = 0m;

        //Vital Methods

        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Displays the newly added customer in the ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ListBox_DisplayInfo.Items.Clear();

            foreach (var customer in customers)
            {
                ListBox_DisplayInfo.Items.Add(customer);
            }
            ListBox_DisplayInfo.DisplayMember = "ToString";
        }

        //Initialize Component
        public EnMaxGUI()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event Handler linked to the button, main function is to add a new Customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddCustomer_Click(object sender, EventArgs e)
        {
            // Parse TextBox_AccountNo.Text into an Int.
            //string TextBox_AccountNo_Text = TextBox_AccountNo.Text;
            //int parsedAccountNumber;
            //int.TryParse(TextBox_AccountNo_Text, out parsedAccountNumber);

            // Parse TextBox_kwh.Text to a double
            string TextBox_kwhUsed_Text = TextBox_Kwh.Text;
            double parsedkwhUsed;
            double.TryParse(TextBox_kwhUsed_Text, out parsedkwhUsed);


            Customer newCustomer = new Customer
                (
                TextBox_FName.Text,
                TextBox_LName.Text,
                parsedkwhUsed,
                0
                );

            TOTAL_KWH += parsedkwhUsed;


            newCustomer.UpdateBillAmount();

            MessageBox.Show("Customer Added!");

            TextBox_FName.Clear();
            TextBox_LName.Clear();
            TextBox_Kwh.Clear();

            // Add the new customer to your list 
            customers.Add(newCustomer);

            //NOTE TO SELF:
            //Create variables CustomerAdded & KWHUsed and simply accumulate customers and add KWH per Customer.
        }


        private void Button_DisplayData_Click(object sender, EventArgs e)
        {
            // Call UpdateListBox
            UpdateListBox();

            //Display Total kWh used
            DisplayTotalKwh();
        }

        /// <summary>
        /// Display Total cost for Customer item when clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_DisplayInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox_DisplayInfo.SelectedItem != null)
            {
                // Get the Selected Customer kWh
                Customer selectedCustomer = (Customer)ListBox_DisplayInfo.SelectedItem;

                // Grab the bill amount and display it in the appropriate Text box.
                TextBox_TotalDue.Text = $"{selectedCustomer.BillAmount:c}";
                TextBox_AccountNo.Text = $"{selectedCustomer.AccountNo}";


            }
        }

        private void DisplayTotalKwh()
        {
            TextBox_Totalkwh.Text = ($"{TOTAL_KWH}");

        }
    }
}
