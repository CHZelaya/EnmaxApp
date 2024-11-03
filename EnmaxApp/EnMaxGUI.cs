namespace EnmaxApp
{
    public partial class EnMaxGUI : Form
    {
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
            string TextBox_AccountNo_Text = TextBox_AccountNo.Text;
            int parsedAccountNumber;
            int.TryParse(TextBox_AccountNo_Text, out parsedAccountNumber);

            // Parse TextBox_kwh.Text to a double
            string TextBox_kwhUsed_Text = TextBox_Kwh.Text;
            double parsedkwhUsed;
            double.TryParse(TextBox_kwhUsed_Text, out parsedkwhUsed);



            Customer newCustomer = new Customer
                (
                TextBox_FName.Text,
                TextBox_LName.Text,
                parsedAccountNumber,
                parsedkwhUsed
                );

            MessageBox.Show("Customer Added!");

            TextBox_FName.Clear();
            TextBox_LName.Clear();
            TextBox_AccountNo.Clear();
            TextBox_Kwh.Clear();

            // Add the new customer to your list 
            customers.Add(newCustomer);
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
                double totalCost = CalculateTotalCost(selectedCustomer);

                TextBox_TotalDue.Text = $"{totalCost:c}";
            }
        }

        /// <summary>
        /// Calculate total cost of Customers bill
        /// </summary>
        /// <param name="selectedCustomer"></param>
        /// <returns>Total cost: Total of kwH used * 0.07 + 12 Administration fee</returns>
        private static double CalculateTotalCost(Customer selectedCustomer)
        {
            return (selectedCustomer.Kwh * 0.07) + 12;
        }
    }
}
