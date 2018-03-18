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
        private static String ENCODED_WOODEN_IMAGE = WoodenItemIcon._ENCODED_WOODEN_IMAGE;
        private static String ENCODED_GREEN_GRASS_IMAGE = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE;
        
        private String name;
        private String description;
        private Image image;
        private Dictionary<String, Object> attributes;

        private Boolean selected;
        private Image tempImage;
        private Boolean firstClick;

        public Item()
        {
            InitializeComponent();

            name = "Default";
            description = "   ";
            image = getDefaultIcon();
            this.BackgroundImage = image;
            attributes = null;
            selected = false;
            firstClick = true;

        }

        public Item(String name, String description)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            image = getDefaultIcon();
            this.BackgroundImage = image;
            attributes = null;
            selected = false;
            firstClick = true;
        }

        public Item(String name, String description, Image image)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.image = image;
            this.BackgroundImage = image;
            attributes = null;
            selected = false;
            firstClick = true;
        }

        public Item(String name, String description, Image image, Dictionary<String, Object> attributes)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.image = image;
            this.BackgroundImage = image;
            this.attributes = attributes;
            selected = false;
            firstClick = true;
        }

        public string ItemName {
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

        public static Image AdjustBrightness(Image Image, int Value)
        {
            System.Drawing.Bitmap TempBitmap = new Bitmap(Image);
            float FinalValue = (float)Value / 255.0f;
            System.Drawing.Bitmap NewBitmap = new System.Drawing.Bitmap(TempBitmap.Width, TempBitmap.Height);
            System.Drawing.Graphics NewGraphics = System.Drawing.Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix ={
                     new float[] {1, 0, 0, 0, 0},
                     new float[] {0, 1, 0, 0, 0},
                     new float[] {0, 0, 1, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            System.Drawing.Imaging.ColorMatrix NewColorMatrix = new System.Drawing.Imaging.ColorMatrix(FloatColorMatrix);
            System.Drawing.Imaging.ImageAttributes Attributes = new System.Drawing.Imaging.ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, System.Drawing.GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();

            return NewBitmap;
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

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            selected = true;
            
            if (firstClick)
            {
                tempImage = BackgroundImage;
                BackgroundImage = AdjustBrightness(BackgroundImage, 50);
                firstClick = false;
            }
        }

        private void Item_Leave(object sender, EventArgs e)
        {
            selected = false;
            BackgroundImage = tempImage;
            firstClick = true;
        }
    }
}
