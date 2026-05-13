/*
Group Name: Foundational Devs
Students Names: Michael Roberts, Caleb Perkins, Andy G Mendoza
Final Project
Description:  
This is the menu.  
How to interact with the menu:
1.  Select the items from each/any of the item type sections.
2.  Press the "Add Selected Items" button to move those items to the current order listbox.
3.  Once you have the desired items in your order listbox press the "Submit Order" Button.
4.  You can reorder more items.  You can also select and remove specific items or clear your order listbox prior to submitting. 
6.  When ready to check out press the "Request Check" Button.  This will take you to the Checkout page.  
*/

using System;                                      // using System namespace
using System.Collections.Generic;                  // using generic collections
using System.Windows.Forms;                        // using Windows Forms namespace
using System.Drawing;                              // using drawing namespace for Rectangle and Size

namespace DeliciosoERistorante                     // project namespace
{
    public partial class frmMenu : Form            // frmMenu class
    {
        private List<OrderItem> orderList;         // list to store all ordered items
        private Dictionary<string, double> prices; // dictionary of item prices

        private Dictionary<Control, Rectangle> originalBounds = new Dictionary<Control, Rectangle>(); // dictionary for proportional resizing
        private Size originalFormSize;             // store original form size for scaling

        public frmMenu()                           // constructor
        {
            InitializeComponent();                 // initialize form components
            this.WindowState = FormWindowState.Maximized;   // maximize window
            InitializeOrderList();                 // initialize order list
            InitializePrices();                    // initialize prices
            WireEvents();                          // wire button events
        }

        private void frmMenu_Load(object sender, EventArgs e)   // load event for proportional resizing
        {
            originalFormSize = this.Size;          // store original form size

            foreach (Control c in this.Controls)   // loop through controls
                originalBounds[c] = c.Bounds;      // store original bounds
        }

        private void frmMenu_Resize(object sender, EventArgs e) // resize event for proportional scaling
        {
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)   // prevent divide by zero
                return;                                  // exit if invalid

            float xRatio = (float)this.Width / originalFormSize.Width;   // compute width ratio
            float yRatio = (float)this.Height / originalFormSize.Height; // compute height ratio

            foreach (Control c in this.Controls)         // loop through controls
            {
                Rectangle r = originalBounds[c];         // get original bounds

                c.SetBounds(                             // set new proportional bounds
                    (int)(r.X * xRatio),                 // new X
                    (int)(r.Y * yRatio),                 // new Y
                    (int)(r.Width * xRatio),             // new Width
                    (int)(r.Height * yRatio)             // new Height
                );
            }
        }

        private void WireEvents()                  // method to wire events
        {
            btnAddItems.Click += btnAddItems_Click;         // wire add selected items button
            btnSubmitOrder.Click += btnSubmitOrder_Click;   // wire submit order button
            btnMenuClear.Click += btnMenuClear_Click;       // wire clear all button
            btnRemoveItem.Click += btnRemoveItem_Click;     // wire remove item button
            btnRequestCheck.Click += btnRequestCheck_Click; // wire request check button
        }

        private void InitializeOrderList()         // method to initialize order list
        {
            orderList = new List<OrderItem>();     // create new order list
        }

        private void InitializePrices()            // method to initialize prices
        {
            prices = new Dictionary<string, double>();   // create dictionary

            prices["Spaghetti Marinara"] = 11.99;  
            prices["Fettuccine Alfredo"] = 12.99;  
            prices["Lasagna"] = 13.99;             
            prices["Cheese Pizza"] = 10.99;        
            prices["Pepperoni Pizza"] = 11.49;     
            prices["Chicken Parmesan"] = 14.99;    
            prices["Pasta Primavera"] = 11.99;     
            prices["Baked Ziti"] = 12.49;          
            prices["Meat Ravioli"] = 13.49;        
            prices["Shrimp Linguine"] = 15.99;     

            prices["Caesar Salad"] = 7.99;         
            prices["Caprese Salad"] = 8.49;        
            prices["Garden Salad"] = 6.99;         
            prices["Arugula Salad"] = 7.49;        
            prices["Greek Salad"] = 8.99;          
            prices["Antipasto Salad"] = 6.49;      

            prices["Coffee"] = 2.49;               
            prices["Espresso"] = 1.99;             
            prices["Lemonade"] = 2.99;             
            prices["Iced Tea"] = 2.49;             
            prices["Wine"] = 2.99;                 

            prices["Tiramisu"] = 6.99;             
            prices["Cannoli"] = 5.99;              
            prices["Panna Cotta"] = 6.49;         
            prices["Gelato"] = 5.49;               
            prices["Cheesecake"] = 7.99;           
        }

        private void btnAddItems_Click(object sender, EventArgs e)   // add selected items click
        {
            AddItemFromCategory(lstMainDishes, numMainDishes);   // add main dish
            AddItemFromCategory(lstSalads, numSalads);           // add salad
            AddItemFromCategory(lstBeverages, numBeverages);     // add beverage
            AddItemFromCategory(lstDesserts, numDesserts);       // add dessert

            RefreshOrderListBox();                               // refresh order listbox
        }

        private void AddItemFromCategory(ListBox list, NumericUpDown qty)   // add item helper
        {
            if (list.SelectedItem == null)                       // check if item selected
                return;                                          // exit if none

            int quantity = (int)qty.Value;                       // get quantity

            if (quantity <= 0)                                   // check quantity
                return;                                          // exit if invalid

            string rawText = list.SelectedItem.ToString();        // get raw listbox text
            string itemName = ExtractName(rawText);               // extract item name
            double price = prices[itemName];                      // get price

            OrderItem existing = FindOrderItem(itemName);         // find existing item

            if (existing != null)                                // if exists
            {
                existing.Quantity += quantity;                   // increase quantity
                existing.Status = "Pending";                     // mark as pending
            }
            else                                                 // otherwise
            {
                orderList.Add(new OrderItem(itemName, quantity, price, "Pending"));   // add new item
            }

            qty.Value = 0;                                       // reset quantity
            list.ClearSelected();                                // clear selection
        }

        private string ExtractName(string raw)                   // extract item name
        {
            int tabIndex = raw.IndexOf("\t");                    // find tab
            if (tabIndex > 0)                                    // if found
                return raw.Substring(0, tabIndex).Trim();        // return name only

            return raw.Trim();                                   // fallback
        }

        private OrderItem FindOrderItem(string name)             // find order item
        {
            foreach (OrderItem item in orderList)                // loop items
                if (item.Name == name)                           // check match
                    return item;                                 // return item

            return null;                                         // return null
        }

        private void RefreshOrderListBox()                       // refresh order listbox
        {
            lstCurrentOrder.Items.Clear();                       // clear listbox

            foreach (OrderItem item in orderList)                // loop items
                lstCurrentOrder.Items.Add(item.ToString());      // add formatted item
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)   // remove item click
        {
            int index = lstCurrentOrder.SelectedIndex;                 // get selected index

            if (index < 0 || index >= orderList.Count)                 // validate index
            {
                MessageBox.Show("Please select an item to remove.");   // show message
                return;                                                // exit
            }

            orderList.RemoveAt(index);                                 // remove item
            RefreshOrderListBox();                                     // refresh listbox
        }

        private void btnMenuClear_Click(object sender, EventArgs e)   // clear all click
        {
            orderList.Clear();                                   // clear order list
            RefreshOrderListBox();                               // refresh listbox
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)   // submit order click
        {
            bool hasPending = false;                             // track pending items

            foreach (OrderItem item in orderList)                // loop items
            {
                if (item.Status == "Pending")                    // check pending
                {
                    item.Status = "Submitted";                   // convert to submitted
                    hasPending = true;                           // mark found
                }
            }

            if (!hasPending)                                     // if nothing to submit
            {
                MessageBox.Show("There are no pending items to submit.");   // show message
                return;                                          // exit
            }

            MessageBox.Show("Your order has been submitted!");   // show confirmation
            RefreshOrderListBox();                               // refresh listbox
            ClearSelectionsOnly();                               // clear selections only
        }

        private void ClearSelectionsOnly()                       // clear selections method
        {
            numMainDishes.Value = 0;                             // reset quantities
            numSalads.Value = 0;
            numBeverages.Value = 0;
            numDesserts.Value = 0;

            lstMainDishes.ClearSelected();                       // clear selections
            lstSalads.ClearSelected();
            lstBeverages.ClearSelected();
            lstDesserts.ClearSelected();
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)   // request check click
        {
            if (orderList.Count == 0)                            // check empty order
            {
                MessageBox.Show("Please add at least one item before checkout.");   // show message
                return;                                          // exit
            }

            List<OrderItem> cleanList = BuildCleanList();        // build clean list
            frmCheckout checkout = new frmCheckout(cleanList);   // pass clean list
            checkout.Show();                                      // show checkout form
            this.Hide();                                          // hide menu form
        }

        private List<OrderItem> BuildCleanList()                 // build clean list method
        {
            Dictionary<string, OrderItem> merged = new Dictionary<string, OrderItem>();   // merged items

            foreach (OrderItem item in orderList)                // loop items
            {
                if (!merged.ContainsKey(item.Name))             // if not merged yet
                {
                    merged[item.Name] = new OrderItem(item.Name, item.Quantity, item.UnitPrice, "");   // add clean
                }
                else                                             // otherwise
                {
                    merged[item.Name].Quantity += item.Quantity; // merge quantities
                }
            }

            return new List<OrderItem>(merged.Values);           // return merged list
        }
    }

    public class OrderItem                                   // OrderItem class
    {
        public string Name { get; set; }                     // item name property
        public int Quantity { get; set; }                    // quantity property
        public double UnitPrice { get; set; }                // unit price property
        public string Status { get; set; }                   // status property

        public OrderItem(string name, int quantity, double price, string status)   // constructor
        {
            Name = name;                                     // assign name
            Quantity = quantity;                             // assign quantity
            UnitPrice = price;                               // assign price
            Status = status;                                 // assign status
        }

        public double LineTotal()                            // calculate line total
        {
            return Quantity * UnitPrice;                     // return total
        }

        public override string ToString()                    // override ToString
        {
            if (string.IsNullOrEmpty(Status))                // hide tags for receipts
                return $"{Name} x{Quantity} - {LineTotal():C}";

            string tag = Status == "Submitted"               // choose tag
                ? "(Submitted)"                              // submitted tag
                : "(Pending until submitted)";               // pending tag

            return $"{Name} x{Quantity} - {LineTotal():C} {tag}";   // formatted string
        }
    }
}
