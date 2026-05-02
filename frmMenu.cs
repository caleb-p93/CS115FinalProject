using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.Windows.Forms;                        // using Windows Forms namespace

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMenu : Form           // frmMenu class
    {
        private List<OrderItem> orderList;         // list to store order items

        private string[] mainDishes =              // array of main dishes 
        {
            "Spaghetti",
            "Lasagna",
            "Fettuccine Alfredo",
            "Margherita Pizza",
            "Chicken Parmigiana",
            "Ravioli"
        };

        private string[] salads =                  // array of salads
        {
            "Caesar Salad",
            "Garden Salad"
        };

        private string[] beverages =               // array of beverages
        {
            "Iced Tea",
            "Soda",
            "Coffee"
        };

        private string[] desserts =                // array of desserts
        {
            "Tiramisu",
            "Cannoli",
            "Cheesecake"
        };

        private Dictionary<string, double> prices; // dictionary of item prices

        public frmMenu()                          // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize form window
            InitializeOrderList();                 // initialize order list
            InitializePrices();                    // initialize prices
            LoadCategories();                      // load menu categories
        }

        private void InitializeOrderList()         // method to initialize order list
        {
            orderList = new List<OrderItem>();     // create new list for order items
        }

        private void InitializePrices()            // method to initialize prices
        {
            prices = new Dictionary<string, double>();   // create new dictionary

            prices["Spaghetti"] = 12.99;           // spaghetti price
            prices["Lasagna"] = 14.99;             // lasagna price
            prices["Fettuccine Alfredo"] = 13.99;  // fettuccine price
            prices["Margherita Pizza"] = 11.99;    // pizza price
            prices["Chicken Parmigiana"] = 15.99;  // chicken parm price
            prices["Ravioli"] = 13.49;             // ravioli price
            prices["Caesar Salad"] = 8.99;         // caesar salad price
            prices["Garden Salad"] = 7.99;         // garden salad price
            prices["Iced Tea"] = 2.99;             // iced tea price
            prices["Soda"] = 2.49;                 // soda price
            prices["Coffee"] = 2.99;               // coffee price
            prices["Tiramisu"] = 6.99;             // tiramisu price
            prices["Cannoli"] = 5.99;              // cannoli price
            prices["Cheesecake"] = 6.49;           // cheesecake price
        }

        private void LoadCategories()              // method to load categories
        {
            cmbCategory.Items.Clear();             // clear category combo box
            cmbCategory.Items.Add("Main Dishes");  // add main dishes category
            cmbCategory.Items.Add("Salads");       // add salads category
            cmbCategory.Items.Add("Beverages");    // add beverages category
            cmbCategory.Items.Add("Desserts");     // add desserts category
            cmbCategory.SelectedIndex = 0;         // select first category
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)   // category changed event
        {
            LoadMenuItems();                       // load menu items for category
        }

        private void LoadMenuItems()               // method to load menu items
        {
            lstMenu.Items.Clear();                 // clear menu listbox

            string category = cmbCategory.SelectedItem.ToString();   // get selected category

            switch (category)                      // switch on category
            {
                case "Main Dishes":                // main dishes case
                    AddItemsToMenu(mainDishes);    // add main dishes
                    break;                         // break

                case "Salads":                     // salads case
                    AddItemsToMenu(salads);        // add salads
                    break;                         // break

                case "Beverages":                  // beverages case
                    AddItemsToMenu(beverages);     // add beverages
                    break;                         // break

                case "Desserts":                   // desserts case
                    AddItemsToMenu(desserts);      // add desserts
                    break;                         // break
            }
        }

        private void AddItemsToMenu(string[] items)   // method to add items to menu
        {
            foreach (string item in items)         // loop through items
            {
                lstMenu.Items.Add(item);           // add item to listbox
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)   // add button click event
        {
            try                                     // try block
            {
                string itemName = GetSelectedMenuItem();   // get selected item

                if (itemName == null)               // check if no item selected
                {
                    MessageBox.Show("Please select an item.");   // show message
                    return;                          // exit method
                }

                int quantity = GetSelectedQuantity();   // get selected quantity

                if (quantity <= 0)                   // check quantity
                {
                    MessageBox.Show("Please select a quantity greater than zero.");   // show message
                    return;                          // exit method
                }

                AddItemToOrder(itemName, quantity);  // add item to order
                RefreshOrderListBox();               // refresh order listbox
            }
            catch (Exception ex)                     // catch block
            {
                MessageBox.Show("Error adding item: " + ex.Message);   // show error message
            }
        }

        private string GetSelectedMenuItem()         // method to get selected menu item
        {
            return lstMenu.SelectedItem?.ToString(); // return selected item or null
        }

        private int GetSelectedQuantity()            // method to get selected quantity
        {
            return (int)nudQuantity.Value;           // return numeric up/down value
        }

        private void AddItemToOrder(string itemName, int quantity)   // method to add item to order
        {
            OrderItem existingItem = FindOrderItem(itemName);   // find existing item

            if (existingItem != null)              // check if item already exists
            {
                IncreaseQuantity(ref existingItem.Quantity, quantity);   // increase quantity
            }
            else                                   // otherwise
            {
                double price = prices[itemName];   // get price from dictionary
                orderList.Add(new OrderItem(itemName, quantity, price));   // add new order item
            }
        }

        private OrderItem FindOrderItem(string itemName)   // method to find order item
        {
            foreach (OrderItem item in orderList)  // loop through order list
            {
                if (item.Name == itemName)         // check name match
                {
                    return item;                   // return matching item
                }
            }

            return null;                           // return null if not found
        }

        private void IncreaseQuantity(ref int currentQuantity, int amountToAdd)   // method to increase quantity
        {
            currentQuantity += amountToAdd;        // add amount to current quantity
        }

        private void RefreshOrderListBox()         // method to refresh order listbox
        {
            lstOrder.Items.Clear();                // clear listbox

            foreach (OrderItem item in orderList)  // loop through order items
            {
                lstOrder.Items.Add(item.ToString());   // add formatted item
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)   // remove button click event
        {
            int index = lstOrder.SelectedIndex;    // get selected index

            if (index < 0 || index >= orderList.Count)   // check valid index
            {
                MessageBox.Show("Please select an item to remove.");   // show message
                return;                              // exit method
            }

            orderList.RemoveAt(index);             // remove item from list
            RefreshOrderListBox();                 // refresh listbox
        }

        private void btnCheckout_Click(object sender, EventArgs e)   // checkout button click event
        {
            if (orderList.Count == 0)              // check if order is empty
            {
                MessageBox.Show("Please add at least one item before checkout.");   // show message
                return;                            // exit method
            }

            frmCheckout checkout = new frmCheckout(orderList);   // create checkout form
            checkout.Show();                       // show checkout form
            this.Hide();                           // hide menu form
        }

        public void ResetForNewGuest()             // method to reset for new guest
        {
            orderList.Clear();                     // clear order list
            RefreshOrderListBox();                 // refresh listbox
            cmbCategory.SelectedIndex = 0;         // reset category
            nudQuantity.Value = 1;                 // reset quantity
            this.Show();                           // show menu form
        }
    }

    public class OrderItem                           // OrderItem class
    {
        public string Name { get; set; }             // item name property
        public int Quantity { get; set; }            // quantity property
        public double UnitPrice { get; set; }        // unit price property

        public OrderItem(string name, int quantity, double unitPrice)   // constructor
        {
            Name = name;                             // assign name
            Quantity = quantity;                     // assign quantity
            UnitPrice = unitPrice;                   // assign unit price
        }

        public double LineTotal()                    // method to calculate line total
        {
            return Quantity * UnitPrice;             // return quantity times price
        }

        public override string ToString()            // override ToString method
        {
            return $"{Name} x{Quantity} - {LineTotal():C}";   // formatted string
        }
    }
}
