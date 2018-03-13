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
using System.Diagnostics;

namespace Inventory

{

    public partial class Inventory : UserControl
    {
        private static String ENCODED_DEFAULT_IMAGE = DefaultItemIcon._ENCODED_DEFAULT_IMAGE;
        private static String ENCODED_ELEGANT_BLUE_IMAGE = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE;
        private static String ENCODED_WOOD_IMAGE = WoodenItemIcon._ENCODED_WOODEN_IMAGE;

        private String name;
        private String description;
        private Image image;
        private Dictionary<String, Object> attributes;
        private List<String> preparedImage = new List<String>{"ENCODED_DEFAULT_IMAGE", "ENCODED_ELEGANT_BLUE_IMAGE", "ENCODED_WOOD_IMAGE"};

        public Inventory()
        {
            InitializeComponent();

            name = "Default";
            description = "   ";
            image = getDefaultIcon();
            this.BackgroundImage = image;
            attributes = null;
            Debug.WriteLine("Changed!");

        }

        public Inventory(String name, String description)
        {
            this.name = name;
            this.description = description;
            image = getDefaultIcon();
            attributes = null;
        }

        public Inventory(String name, String description, Image image)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            attributes = null;
        }

        public Inventory(String name, String description, Image image, Dictionary<String, Object> attributes)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this.attributes = attributes;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description {
            get => description;
            set => description = value;
        }

        public Image Image {
            get => image;
            set => image = value;
        }

        public Dictionary<string, object> Attributes {
            get => attributes;
            set => attributes = value;
        }

        private static Image getDefaultIcon()
        {

            String base64Image = ENCODED_DEFAULT_IMAGE.Split(',')[1];
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
        
    }
}
