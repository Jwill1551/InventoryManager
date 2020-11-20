using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class DisplayItems : Form
    {
        public DisplayItems()
        {
            InitializeComponent();
        }

        //Gives all the items in the inventory
        private void displayAllitemsButton_Click(object sender, EventArgs e)
        {
           checkInventory();
        }
        
        //Displays a list of all the items in the inventory
            public void checkInventory()
            {

            StringBuilder builder = new StringBuilder();
                foreach (var item in MainHome.collection)
                {
                   builder.Append("Name: " + "[" + item.name + "] " + "Category: " + "[" + item.category + "] " + "Stock: " + "[" + item.inStock + "] Cost: " + "[ $" + item.cost + "].").Append("|--------|");
                }

                string result = builder.ToString();
                displayBox.Text = result;

                int numOfItems = MainHome.collection.Count;
                MessageBox.Show("Number of Items in Inventory: " + numOfItems);
            }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
