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
        private static String ENCODED_DEFAULT_IMAGE_NULL = DefaultItemIcon._ENCODED_DEFAULT_IMAGE_NULL;
        private static String ENCODED_DEFAULT_IMAGE_EMPTY = DefaultItemIcon._ENCODED_DEFAULT_IMAGE_EMPTY;
        private static String ENCODED_ELEGANT_BLUE_IMAGE_NULL = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE_NULL;
        private static String ENCODED_ELEGANT_BLUE_IMAGE_EMPTY = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE_EMPTY;
        private static String ENCODED_WOODEN_IMAGE_NULL = WoodenItemIcon._ENCODED_WOODEN_IMAGE_NULL;
        private static String ENCODED_WOODEN_IMAGE_EMPTY = WoodenItemIcon._ENCODED_WOODEN_IMAGE_EMPTY;
        private static String ENCODED_GREEN_GRASS_IMAGE_NULL = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE_NULL;
        private static String ENCODED_GREEN_GRASS_IMAGE_EMPTY = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE_EMPTY;

        private Color COLOR_MAIN_PANEL = Color.FromArgb(255, 215, 228, 242);
        private Color COLOR_PANELS_INSIDE = Color.FromArgb(255, 185, 209, 234);
        

        private Point itemPosition = new Point(3, 3);
        private Point itemSize = new Point(50, 50);
        private List<Item> itemList;



        public InventoryComponent()
        {
            InitializeComponent();
            setItems(createItemList());
            checkGroupsList();

            foreach(var item in itemList)
            {
                item.transparentClickablePanel1.Click += new System.EventHandler(this.mouseOnItemClick);
            }
            
        }
        
        public void clearInventoryPanel()
        {
            InventoryInPanel.Controls.Clear();
        }

        public void clearItemList()
        {
            clearInventoryPanel();
            itemList.Clear();
            checkGroupsList();
        }

        public List<Item> createItemList()
        {
            String iPath = "C:/Users/Iza/source/repos/Inventory-C-sharp/img/swordTest.png";
            String gPath = "D:/Projects/VisualStudioProjects/Inventory/Inventory/Resources/img/swordTest.png"; //Iza jesteś niesamowita <3

            List<Item> items = new List<Item> {
                new Item("Napierśnik Złotego Lwa", "Napierśnik bronił serce samego Thormunda Walecznego. " +
                "Budzi postrach wśród przeciwników jako, że jego powierzchnia nie została " +
                "ani razu skażona choćby najmniejszą rysą.", gPath,"Zbroja", null),
                new Item("Hełm Jednorożca", "Hełm noszony przez Elfich Rycerzy. Swoim blaskiem potrafi " +
                "oślepic wzroga na okres dwóch tur.", gPath, "Zbroja", null),
                new Item("Eliksir życia", "Potrafi poprawić Twoje " +
                "samopoczucie oraz wyleczyć Cię z ciężkich ran.", gPath, "Pożywienie", null),
                new Item("Miecz Izydora", "Dwuręczny miecz, którego " +
                "ostrze wysadzone jest runami, o których krążą legendy.", gPath, "Broń", null),
            };

            return items;
        }

        private void checkIfItemSelected()
        {
            foreach (var item in itemList)
            {
                if (item.selected)
                {

                    nameTextBox.Text = item.ItemName;
                    groupTextBox.Text = item.Group;
                    descriptionTextBox.Text = item.Description;
                    /*foreach (var pair in item.Attributes)
                    {
                        attributesTextBox.Text += "Atrybut: " + pair.Key + "\nEfekt: " + pair.Value + "\n";
                    }*/
                }
                else { }
            }
        }

        private void checkGroupsList()
        {
            if(getAllItemGroups().Count == 0)
            {
                groupsList.Visible = false;
            }
            else
            {
                groupsList.Visible = true;
                foreach (String group in getAllItemGroups())
                {
                    Console.WriteLine(group);
                    groupsList.Items.Add(group);
                }
            }
        }

        private List<String> getAllItemGroups()
        {
            List<String> groups = new List<String>();
            
            foreach (Item item in itemList)
            {
                if (item.Group != null && !groups.Contains(item.Group))
                {

                    groups.Add(item.Group);
                }
                
            }
            
            return groups;
        }

        public static Image getIconImage(String imageName)
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

        public void setSelectedIconColorToInterface(ComboBox cb)
        {

            switch (cb.GetItemText(cb.SelectedItem))
            {
                case "Default":
                    COLOR_MAIN_PANEL = Color.FromArgb(255, 215, 228, 242);
                    COLOR_PANELS_INSIDE = Color.FromArgb(255, 185, 209, 234);
                    break;

                case "Blue Elegant":
                    COLOR_MAIN_PANEL = Color.FromArgb(255, 185, 196, 255);
                    COLOR_PANELS_INSIDE = Color.FromArgb(255, 131, 142, 214);
                    break;

                case "Wooden":
                    COLOR_MAIN_PANEL = Color.FromArgb(255, 229, 222, 201);
                    COLOR_PANELS_INSIDE = Color.FromArgb(255, 201, 180, 134);
                    break;
                    
                case "Green Grass":
                    COLOR_MAIN_PANEL = Color.FromArgb(255, 193, 234, 188);
                    COLOR_PANELS_INSIDE = Color.FromArgb(255, 144, 201, 134);
                    break;
            }
            
        }

        public String getSelectedIconName(ComboBox cb)
        {
            
            switch (cb.GetItemText(cb.SelectedItem))
            {
                case "Default":
                    return ENCODED_DEFAULT_IMAGE_EMPTY;

                case "Blue Elegant":
                    return ENCODED_ELEGANT_BLUE_IMAGE_EMPTY;
                    
                case "Wooden":
                    return ENCODED_WOODEN_IMAGE_EMPTY;
                    
                case "Green Grass":
                    return ENCODED_GREEN_GRASS_IMAGE_EMPTY;
                    
            }

            return ENCODED_DEFAULT_IMAGE_NULL;
        }
        
        public void addItem(Item item)
        {
            itemList.Add(item);
            loadAllItems(itemList);
            checkGroupsList();
        }

        private List<Item> pickItemsByGroup(String group)
        {
            List<Item> items = new List<Item>();
            foreach(Item item in itemList)
            {
                if(item.Group != null)
                {
                    if(item.Group.Equals(group))
                    {
                        items.Add(item);
                    }
                }
            }

            return items;
        }

        public void setItems(List<Item> items)
        {
            itemList = new List<Item>(items);
            loadAllItems(items);
        }

        public void loadAllItems(List<Item> items)
        {
            clearInventoryPanel();

            itemPosition = new Point(0, 0);

            for (int i = 0; i < items.Count; i++)
            {
                
                if (i != 0 && i % 6 != 0)
                {
                    itemPosition.X += itemSize.X + 6;
                }
                else if (i != 0 && i % 6 == 0)
                {
                    itemPosition.X = 3;
                    itemPosition.Y += itemSize.Y + 6;
                }
                else { }

                items[i].SetBounds(itemPosition.X, itemPosition.Y + InventoryInPanel.AutoScrollPosition.Y, itemSize.X, itemSize.Y);
                InventoryInPanel.Controls.Add(items[i]);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var item in itemList)
            {
                item.BackgroundImage = getIconImage(getSelectedIconName(comboBox1));
            }
            
            
            setSelectedIconColorToInterface(comboBox1);

            BackColor = COLOR_MAIN_PANEL;
            InventoryInPanel.BackColor = COLOR_PANELS_INSIDE;
            ItemInfoPanel.BackColor = COLOR_PANELS_INSIDE;
            nameTextBox.BackColor = COLOR_PANELS_INSIDE;
            groupTextBox.BackColor = COLOR_PANELS_INSIDE;
            descriptionTextBox.BackColor = COLOR_PANELS_INSIDE;
            attributesTextBox.BackColor = COLOR_PANELS_INSIDE;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupsList.SelectedItems.Count != 0)
            {
                String selectedGroup = groupsList.SelectedItems[0].SubItems[0].Text;
                loadAllItems(pickItemsByGroup(selectedGroup));
            }
        }
        
        private void mouseOnItemClick(object sender, EventArgs e)
        {
            checkIfItemSelected();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                
                setItems(itemList);
            }
        }
    }

}
