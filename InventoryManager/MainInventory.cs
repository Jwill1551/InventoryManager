/*Joshua Williams
 * CST-117
 * ver.1.0
 */

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
    public partial class MainHome : Form
    {
        //Inventory Of All the Items stored, removed, and changed
        public static List<Item> collection = new List<Item>();

        //The Constructor of the Class
        public MainHome()
        {
            InitializeComponent();

            //Defualt Items in Storage
            Item pencil = new Item("pencil", "supplies", 0.50, 5, "yellow", "No");
            Item eraser = new Item("eraser", "supplies", 0.35, 8, "pink", "No");
            Item desk = new Item("desk", "office-supplies", 101.50, 1, "brown", "Yes");
            Item shoes = new Item("shoes", "clothes", 50.00, 1, "gray, and blue", "No");
            Item book = new Item("CS-book", "education", 25.25, 2, "white, gray", "No");
            Item jacket = new Item("Leather-Jacket", "clothes", 50.55, 3, "Brown, and Black", "No");
            Item monitor = new Item("HP-Monitor", "technology", 125.50, 2, "White, Gray", "Yes");
            Item jeans = new Item("Denim-Jeans", "clothes", 25.35, 4, "Navy-Bule", "No");

            collection.Add(pencil);
            collection.Add(eraser);
            collection.Add(book);
            collection.Add(shoes);
            collection.Add(desk);
            collection.Add(jacket);
            collection.Add(monitor);
            collection.Add(jeans);
        }

        private void MainHome_Load(object sender, EventArgs e)
        {
           
           
        }

        //Add New Items 
        private void addItemButton_Click(object sender, EventArgs e)
        {
            var AddItem = new AddItem();
            AddItem.Show();
        }

        //Remove Old Items
        private void button1_Click(object sender, EventArgs e)
        {
            var RemoveItem = new RemoveItemForm();
            RemoveItem.Show();
        }

        //Restocks an Item
        private void button2_Click(object sender, EventArgs e)
        {
            var RestockItem = new RestockItem();
            RestockItem.Show();
        }

        //Display all the items
        private void button3_Click(object sender, EventArgs e)
        {
            var DisplayItem = new DisplayItems();
            DisplayItem.Show();
        }

        //Searches for an item in the inventory
        private void button4_Click(object sender, EventArgs e)
        {
            var SearchForItem = new SearchForItem();
            SearchForItem.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Item: ItemDescription
        {
            //The class that contains all the central information for item objects
            public string name;
            public int inStock;
            private string warranty;

            public Item() { }

            public Item(string name, string category, double cost, int inStock, string color, string warranty)
            {
                this.name = name;
                this.category = category;
                this.inStock = inStock;
                this.cost = cost;
                this.color = color;
                this.warranty = warranty;
            }
        }

       public class ItemDescription
        {
            //A class that contain all the descriptions of the item objects 
            public string category;
            public double cost;
            public string color;
            private string desc;

            public void setDesc(string desc)
            {
                this.desc = desc;
            }

            public string getDesc()
            {
                return desc;
            }
        }

        
    }

}
