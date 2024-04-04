using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private double totalCost = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double discount = 0;
            int totalQuantity = 0;

            // Parse quantity from textbox
            if (!int.TryParse(gotongBatangas.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity!");
                return;
            }

            // Calculate total cost
            totalQuantity += quantity;
            totalCost += (70 * quantity); // Gotong Batangas price

            // Apply discount if applicable
            if (totalQuantity > 5)
            {
                discount = totalCost * 0.1;
                totalCost -= discount;
            }

            // Display receipt
            MessageBox.Show($"\nTotal Cost: {totalCost:C}\nHave a great day, feel free to come back anytime. Have a wonderful day!", "Thank you for dining with us! Here is the total cost of your order:");
            this.Close();
        }
    }
}
        