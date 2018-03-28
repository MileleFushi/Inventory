using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private Point itemPosition = InventoryComponent.itemPosition;
        private Point itemSize = InventoryComponent.itemSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventoryComponent1.groupsList.Clear();
            inventoryComponent1.addItem(new Item("Przedmiot " + InventoryComponent.itemList.Count, "Przedmiot nie posiada opisu.", null, "Brak", new Dictionary<string, string>() { { "Brak", "   " } }));
            foreach (var item in InventoryComponent.itemList)
            {
                item.transparentClickablePanel1.Click += new System.EventHandler(inventoryComponent1.mouseOnItemClick);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventoryComponent1.clearItemList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryComponent.itemList = inventoryComponent1.createItemList();
            foreach (var item in InventoryComponent.itemList)
            {
                item.transparentClickablePanel1.Click += new System.EventHandler(inventoryComponent1.mouseOnItemClick);
            }
            inventoryComponent1.setItems(InventoryComponent.itemList);
        }
    }
}
