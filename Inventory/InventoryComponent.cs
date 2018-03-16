using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class InventoryComponent : UserControl
    {
        private Point itemPosition = new Point(3, 3);
        private Point itemSize = new Point(50, 50);
        private int itemCount;
        private List<Item> itemList = new List<Item>();

        public InventoryComponent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemCount = itemList.Count;

            itemList.Add(new Item());
            Console.WriteLine(itemCount);
            if (itemCount != 0 && itemCount % 6 != 0)
            {
                itemPosition.X += itemSize.X + 6;
            }
            else if (itemCount != 0 && itemCount % 6 == 0)
            {
                itemPosition.X = 3;
                itemPosition.Y += itemSize.X + 6;
            }
            else { }

            itemList[itemCount].SetBounds(itemPosition.X, itemPosition.Y, itemSize.X, itemSize.Y);

            InventoryInPanel.Controls.Add(itemList[itemCount]);
        }

    }
}
