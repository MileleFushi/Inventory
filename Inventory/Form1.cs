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
        private Point itemPosition = new Point(3, 3);
        private Point itemSize = new Point(50, 50);
        private int itemCount;
        private List<Item> itemList = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemCount = itemList.Count;
            
            itemList.Add(new Item("Item" + itemCount, "Item doesn't have description"));

            if (itemCount != 0 && itemCount % 6 != 0)
            {
                itemPosition.X += itemSize.X + 6;
            }
            else if (itemCount != 0 && itemCount % 6 == 0)
            {
                itemPosition.X = 3;
                itemPosition.Y += itemSize.Y + 6;
            }
            else { }

            itemList[itemCount].SetBounds(itemPosition.X, itemPosition.Y + inventoryComponent1.InventoryInPanel.AutoScrollPosition.Y, itemSize.X, itemSize.Y);
            inventoryComponent1.InventoryInPanel.Controls.Add(itemList[itemCount]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventoryComponent1.clearInventoryPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            itemList = inventoryComponent1.createItemList();
            inventoryComponent1.loadAllItems(itemList);
        }
    }
}
