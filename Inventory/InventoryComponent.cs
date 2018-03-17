﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory
{
    public partial class InventoryComponent : UserControl
    {
        private static String ENCODED_DEFAULT_IMAGE = DefaultItemIcon._ENCODED_DEFAULT_IMAGE;
        private static String ENCODED_ELEGANT_BLUE_IMAGE = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE;
        private static String ENCODED_WOODEN_IMAGE = WoodenItemIcon._ENCODED_WOODEN_IMAGE;
        private static String ENCODED_GREEN_GRASS_IMAGE = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE;

        public static Color COLOR_MAIN_PANEL = Color.FromArgb(0, 215, 228, 242);
        public static Color COLOR_PANELS_INSIDE = Color.FromArgb(0, 185, 209, 234);

        private Point itemPosition = new Point(3, 3);
        private Point itemSize = new Point(50, 50);
        private int itemCount;
        private List<Item> itemList = new List<Item>();

        public InventoryComponent()
        {
            InitializeComponent();
        }

        private static Image getIconImage(String imageName)
        {

            String base64Image = imageName.Split(',')[1];
            byte[] imageBytes = Convert.FromBase64String(base64Image);

            try
            {
                string base64ImageRepresentation = Convert.ToBase64String(imageBytes);

                return Image.FromStream(new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)));
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void setSelectedIconColorToInterface(ComboBox cb)
        {

            switch (cb.GetItemText(cb.SelectedItem))
            {
                case "Default":
                    break;

                case "Blue Elegant":
                    COLOR_MAIN_PANEL = Color.FromArgb(0, 201, 201, 229);
                    COLOR_PANELS_INSIDE = Color.FromArgb(0, 152, 155, 211);
                    break;

                case "Wooden":
                    COLOR_MAIN_PANEL = Color.FromArgb(0, 229, 222, 201);
                    COLOR_PANELS_INSIDE = Color.FromArgb(0, 201, 180, 134);
                    break;
                    
                case "Green Grass":
                    COLOR_MAIN_PANEL = Color.FromArgb(0, 193, 234, 188);
                    COLOR_PANELS_INSIDE = Color.FromArgb(0, 144, 201, 134);
                    break;
            }
            
        }

        private String getSelectedIconName(ComboBox cb)
        {
            
            switch (cb.GetItemText(cb.SelectedItem))
            {
                case "Default":
                    return ENCODED_DEFAULT_IMAGE;

                case "Blue Elegant":
                    this.BackColor = Color.FromArgb(0, 201, 201, 229);
                    InventoryInPanel.BackColor = Color.FromArgb(0, 152, 155, 211);
                    ItemInfoPanel.BackColor = Color.FromArgb(0, 152, 155, 211);
                    ItemEditingPanel.BackColor = Color.FromArgb(0, 152, 155, 211);

                    return ENCODED_ELEGANT_BLUE_IMAGE;
                    
                case "Wooden":
                    this.BackColor = Color.FromArgb(0, 229, 222, 201);
                    InventoryInPanel.BackColor = Color.FromArgb(0, 201, 180, 134);
                    ItemInfoPanel.BackColor = Color.FromArgb(0, 201, 180, 134);
                    ItemEditingPanel.BackColor = Color.FromArgb(0, 201, 180, 134);

                    return ENCODED_WOODEN_IMAGE;
                    
                case "Green Grass":
                    this.BackColor = Color.FromArgb(0, 193, 234, 188);
                    InventoryInPanel.BackColor = Color.FromArgb(0, 144, 201, 134);
                    ItemInfoPanel.BackColor = Color.FromArgb(0, 144, 201, 134);
                    ItemEditingPanel.BackColor = Color.FromArgb(0, 144, 201, 134);

                    return ENCODED_GREEN_GRASS_IMAGE;
                    
            }

            return ENCODED_DEFAULT_IMAGE;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            itemCount = itemList.Count;
            
            itemList.Add(new Item("Item" + itemCount, "Item doesn't have description", getIconImage(getSelectedIconName(comboBox1))));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in itemList)
            {
                item.BackgroundImage = getIconImage(getSelectedIconName(comboBox1));   
            }

            setSelectedIconColorToInterface(comboBox1);

            this.BackColor = COLOR_MAIN_PANEL;
            InventoryInPanel.BackColor = COLOR_PANELS_INSIDE;
            ItemInfoPanel.BackColor = COLOR_PANELS_INSIDE;
            ItemEditingPanel.BackColor = COLOR_PANELS_INSIDE;

        }

    }
}
