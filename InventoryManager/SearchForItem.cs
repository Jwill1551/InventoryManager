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
    public partial class SearchForItem : Form
    {
        public SearchForItem()
        {
            InitializeComponent();
        }

        //Grabs the user's input and searches for the item they specified
        private void searchButton_Click(object sender, EventArgs e)
        {
            string userResponse = searchItemTextBox.Text;
            searchForItem(userResponse);
        }

        //Search throught the list of items and retrieve an item
        public void searchForItem(string nameID)
        {
            foreach (var item in MainHome.collection)
            {
                if (item.name == nameID)
                {
                    MessageBox.Show("Name: " + "[" + item.name + "] " + "Category: " + "[" + item.category + "] " + "Stock: " + "[" + item.inStock + "] Cost: " + "[ $" + item.cost + "].");
                }
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
