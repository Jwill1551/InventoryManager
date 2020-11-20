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
    public partial class RemoveItemForm : Form
    {
        public RemoveItemForm()
        {
            InitializeComponent();
        }

        //Propmts the user to remove an item from the Inventory
        private void removeButton_Click(object sender, EventArgs e)
        {
            string userRes = removeItemTextBox.Text;
            removeItem(userRes);

            MessageBox.Show("A " + userRes + " was removed from the Inventory");
        }

        //A method that will check the list array for an item and then delete it
        public void removeItem(string nameID)
        {
            for (int i = 0; i < MainHome.collection.Count; i++)
            {
                if (MainHome.collection[i].name == nameID)
                {
                    MainHome.collection.RemoveAt(i);
                }
            }
        }

        //Closes the current window being used
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
