namespace EnmaxApp
{

    public partial class EnMaxGUI : Form
    {
        int TOTAL_CUSTOMERS = 0;
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
            //Validation and error handling
            if (!ValidatorUtils.IsPresent(TextBox_FName) ||
                !ValidatorUtils.IsPresent(TextBox_LName) ||
                !ValidatorUtils.IsNonNegative(TextBox_Kwh) ||
                !ValidatorUtils.IsAlphabetic(TextBox_FName) ||
                !ValidatorUtils.IsAlphabetic(TextBox_LName)

                )
            {
                //If any validation fails, exit the method
                return;
            }

            // Parse kWh input after validation

            // Parse TextBox_kwh.Text to a double
            string TextBox_kwhUsed_Text = TextBox_Kwh.Text;
            double parsedkwhUsed;
            if (!double.TryParse(TextBox_kwhUsed_Text, out parsedkwhUsed))
            {
                MessageBox.Show("Please enter a valid, non negative number for kWh used.");
                return;
            }
            try
            {
                Customer newCustomer = new Customer
                    (
                        TextBox_FName.Text,
                        TextBox_LName.Text,
                        parsedkwhUsed,
                        0
                    );

                TOTAL_KWH += parsedkwhUsed;
                //Display Total kWh used
                DisplayTotalKwh();
                UpdateCustomerTotalDislay();
                UpdateAverageBillDisplay();


                newCustomer.UpdateBillAmount();
                Customer.GetTotalCustomers();

                MessageBox.Show("Customer Added!");

                TextBox_FName.Clear();
                TextBox_LName.Clear();
                TextBox_Kwh.Clear();

                // Add the new customer to your list 
                customers.Add(newCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the customer: {ex.Message}");
            }


        }


        private void Button_DisplayData_Click(object sender, EventArgs e)
        {
            // Call UpdateListBox
            UpdateListBox();



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

        /// <summary>
        /// Update the TextBox display on the GUI with the Total number of Customers
        /// </summary>
        private void UpdateCustomerTotalDislay()
        {
            TextBox_TotalCustomers.Text = Customer.GetTotalCustomers().ToString();
        }

        /// <summary>
        /// Update the TextBox display on the GUI with the Average bill.
        /// </summary>
        private void UpdateAverageBillDisplay()
        {
            TextBox_AverageBill.Text = Customer.GenerageAverageBill().ToString("c");
        }
    }
}
