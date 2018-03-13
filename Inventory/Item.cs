using System;
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

    public partial class Item : UserControl
    {
        private static String ENCODED_DEFAULT_IMAGE = DefaultItemIcon._ENCODED_DEFAULT_IMAGE;
        private static String ENCODED_ELEGANT_BLUE_IMAGE = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE;
        private static String ENCODED_WOOD_IMAGE = WoodenItemIcon._ENCODED_WOODEN_IMAGE;

        private String name
        {
            get { return name; }
            set { name = value; }
        }
        private String description
        {
            get { return description; }
            set { description = value; }
        }
        private Image image
        {
            get { return image; }
            set { image = value; }
        }
        private Dictionary<String, Object> attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }
        private List<String> preparedImage = new List<String>{"ENCODED_DEFAULT_IMAGE", "ENCODED_ELEGANT_BLUE_IMAGE", "ENCODED_WOOD_IMAGE"};

        public Item()
        {
            InitializeComponent();

            name = "Default";
            description = "   ";
            image = getDefaultIcon();
            this.BackgroundImage = image;
            attributes = null;
            Debug.WriteLine("Changed!");

        }

        public Item(String name, String description)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            image = getDefaultIcon();
            this.BackgroundImage = image;
            attributes = null;
        }

        public Item(String name, String description, Image image)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.image = image;
            this.BackgroundImage = image;
            attributes = null;
        }

        public Item(String name, String description, Image image, Dictionary<String, Object> attributes)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.image = image;
            this.BackgroundImage = image;
            this.attributes = attributes;
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
