// updated 5.2.26 - Mike - Fully rewritten to match Designer layout and Option B behavior
using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMenu : Form            // frmMenu class
    {
        private List<OrderItem> orderList;         // list to store order items
        private Dictionary<string, double> prices; // dictionary of item prices

        private string[] mainDishes =              // array of main dishes
        {
            "Spaghetti Marinara",
            "Fettuccine Alfredo",
            "Lasagna",
            "Cheese Pizza",
            "Pepperoni Pizza",
            "Chicken Parmesan",
            "Pasta Primavera",
            "Baked Ziti",
            "Meat Ravioli",
            "Shrimp Linguine"
        };

        private string[] salads =                  // array of salads
        {
            "Caesar Salad",
            "Caprese Salad",
            "Garden Salad",
            "Arugula Salad",
            "Greek Salad",
            "Antipasto Salad"
        };

        private string[] beverages =               // array of beverages
        {
            "Coffee",
            "Espresso",
            "Lemonade",
            "Iced Tea",
            "Wine"
        };

        private string[] desserts =                // array of desserts
        {
            "Tiramisu",
            "Cannoli",
            "Panna Cotta",
            "Gelato",
            "Cheesecake"
        };

        public frmMenu()                           // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize window
            InitializeOrderList();                 // initialize order list
            InitializePrices();                    // initialize prices
            LoadMenuItems();                       // load menu items into listboxes
            WireEvents();                          // wire button events
        }

        private void WireEvents()                  // method to wire events
        {
            btnSubmitOrder.Click += btnSubmitOrder_Click;   // wire submit order button
            btnMenuClear.Click += btnMenuClear_Click;       // wire clear all button
            button1.Click += button1_Click;                 // wire remove item button
            btnRequestCheck.Click += btnRequestCheck_Click; // wire request check button
        }

        private void InitializeOrderList()         // method to initialize order list
        {
            orderList = new List<OrderItem>();     // create new order list
        }

        private void InitializePrices()            // method to initialize prices
        {
            prices = new Dictionary<string, double>();   // create dictionary

            prices["Spaghetti Marinara"] = 11.99;  // price
            prices["Fettuccine Alfredo"] = 12.99;  // price
            prices["Lasagna"] = 13.99;             // price
            prices["Cheese Pizza"] = 10.99;        // price
            prices["Pepperoni Pizza"] = 11.49;     // price
            prices["Chicken Parmesan"] = 14.99;    // price
            prices["Pasta Primavera"] = 11.99;     // price
            prices["Baked Ziti"] = 12.49;          // price
            prices["Meat Ravioli"] = 13.49;        // price
            prices["Shrimp Linguine"] = 15.99;     // price

            prices["Caesar Salad"] = 7.99;         // price
            prices["Caprese Salad"] = 8.49;        // price
            prices["Garden Salad"] = 6.99;         // price
            prices["Arugula Salad"] = 7.49;        // price
            prices["Greek Salad"] = 8.99;          // price
            prices["Antipasto Salad"] = 6.49;      // price

            prices["Coffee"] = 2.49;               // price
            prices["Espresso"] = 1.99;             // price
            prices["Lemonade"] = 2.99;             // price
            prices["Iced Tea"] = 2.49;             // price
            prices["Wine"] = 2.99;                 // price

            prices["Tiramisu"] = 6.99;             // price
            prices["Cannoli"] = 5.99;              // price
            prices["Panna Cotta"] = 6.49;          // price
            prices["Gelato"] = 5.49;               // price
            prices["Cheesecake"] = 7.99;           // price
        }

        private void LoadMenuItems()               // method to load menu items
        {
            lstMainDishes.Items.Clear();           // clear main dishes list
            lstSalads.Items.Clear();               // clear salads list
            lstBeverages.Items.Clear();            // clear beverages list
            lstDesserts.Items.Clear();             // clear desserts list

            foreach (string item in mainDishes)    // loop main dishes
                lstMainDishes.Items.Add(item);     // add item

            foreach (string item in salads)        // loop salads
                lstSalads.Items.Add(item);         // add item

            foreach (string item in beverages)     // loop beverages
                lstBeverages.Items.Add(item);      // add item

            foreach (string item in desserts)      // loop desserts
                lstDesserts.Items.Add(item);       // add item
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)   // submit order click
        {
            AddSelectedItem(lstMainDishes, numMainDishes);   // add main dish
            AddSelectedItem(lstSalads, numSalads);           // add salad
            AddSelectedItem(lstBeverages, numBeverages);     // add beverage
            AddSelectedItem(lstDesserts, numDesserts);       // add dessert

            RefreshOrderListBox();                           // refresh order listbox
        }

        private void AddSelectedItem(ListBox list, NumericUpDown qty)   // add selected item
        {
            if (list.SelectedItem == null)                   // check if item selected
                return;                                      // exit if none

            int quantity = (int)qty.Value;                   // get quantity

            if (quantity <= 0)                               // check quantity
                return;                                      // exit if invalid

            string itemName = list.SelectedItem.ToString();  // get item name
            double price = prices[itemName];                 // get price

            OrderItem existing = FindOrderItem(itemName);    // find existing item

            if (existing != null)                            // if exists
                existing.Quantity += quantity;               // increase quantity
            else                                             // otherwise
                orderList.Add(new OrderItem(itemName, quantity, price));   // add new item
        }

        private OrderItem FindOrderItem(string name)         // find order item
        {
            foreach (OrderItem item in orderList)            // loop items
                if (item.Name == name)                       // check match
                    return item;                             // return item

            return null;                                     // return null
        }

        private void RefreshOrderListBox()                   // refresh order listbox
        {
            lstCurrentOrder.Items.Clear();                   // clear listbox

            foreach (OrderItem item in orderList)            // loop items
                lstCurrentOrder.Items.Add(item.ToString());  // add formatted item
        }

        private void button1_Click(object sender, EventArgs e)   // remove item click
        {
            int index = lstCurrentOrder.SelectedIndex;        // get selected index

            if (index < 0 || index >= orderList.Count)        // validate index
            {
                MessageBox.Show("Please select an item to remove.");   // show message
                return;                                      // exit
            }

            orderList.RemoveAt(index);                        // remove item
            RefreshOrderListBox();                            // refresh listbox
        }

        private void btnMenuClear_Click(object sender, EventArgs e)   // clear all click
        {
            orderList.Clear();                                // clear order list
            RefreshOrderListBox();                            // refresh listbox
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)   // request check click
        {
            if (orderList.Count == 0)                         // check empty order
            {
                MessageBox.Show("Please add at least one item before checkout.");   // show message
                return;                                      // exit
            }

            frmCheckout checkout = new frmCheckout(orderList);   // create checkout form
            checkout.Show();                                   // show checkout form
            this.Hide();                                       // hide menu form
        }
    }

    public class OrderItem                               // OrderItem class
    {
        public string Name { get; set; }                 // item name property
        public int Quantity { get; set; }                // quantity property
        public double UnitPrice { get; set; }            // unit price property

        public OrderItem(string name, int quantity, double price)   // constructor
        {
            Name = name;                                 // assign name
            Quantity = quantity;                         // assign quantity
            UnitPrice = price;                           // assign price
        }

        public double LineTotal()                        // calculate line total
        {
            return Quantity * UnitPrice;                 // return total
        }

        public override string ToString()                // override ToString
        {
            return $"{Name} x{Quantity} - {LineTotal():C}";   // formatted string
        }
    }
}
