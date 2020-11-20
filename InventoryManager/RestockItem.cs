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
    public partial class RestockItem : Form
    {
        public RestockItem()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            string response = restockItemTextBox.Text;
            restockItem(response);

            MessageBox.Show(response + " has been restocked!");
        }

        //Restocks an item in the inventory 
        public void restockItem(string name)
        {
            foreach (var item in MainHome.collection)
            {
                if (item.name == name)
                {
                    item.inStock = 5;
                    Console.WriteLine("There is now " + item.inStock + " " + item.name + "s in stock.");
                }
            }
        }
    }
}
