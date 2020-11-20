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
    public partial class AddItem : Form
    {

        public AddItem()
        {
            InitializeComponent();    
        }

        private void AddItem_Load(object sender, EventArgs e){}
         
        //Prompts the user to add a new item 
        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string category = categoryTextBox.Text;
            string cost = priceTextBox.Text;
            double price = Convert.ToDouble(cost);
            string inStock = qtyTextBox.Text;
            int qty = Convert.ToInt32(inStock);
            string color = colorTextBox.Text;
            string warranty = warrantyTextBox.Text;

            MainHome.Item item = new MainHome.Item(name, category, price, qty, color, warranty);

            addItem(item);

            MessageBox.Show("A " + item.name + " was added to the inventory!");
        }

        //A method that adds an object to the static list array 
        public void addItem(MainHome.Item obj)
        {
            MainHome.collection.Add(obj);
        }

        //Closes the current window being used
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
