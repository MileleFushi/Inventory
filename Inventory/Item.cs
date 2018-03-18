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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Inventory

{
    public partial class Item : UserControl
    {
        private static String ENCODED_DEFAULT_IMAGE_NULL = DefaultItemIcon._ENCODED_DEFAULT_IMAGE_NULL;
        private static String ENCODED_DEFAULT_IMAGE_EMPTY = DefaultItemIcon._ENCODED_DEFAULT_IMAGE_EMPTY;
        private static String ENCODED_ELEGANT_BLUE_IMAGE_NULL = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE_NULL;
        private static String ENCODED_ELEGANT_BLUE_IMAGE_EMPTY = BlueElegantItemIcon._ENCODED_ELEGANT_BLUE_IMAGE_EMPTY;
        private static String ENCODED_WOODEN_IMAGE_NULL = WoodenItemIcon._ENCODED_WOODEN_IMAGE_NULL;
        private static String ENCODED_WOODEN_IMAGE_EMPTY = WoodenItemIcon._ENCODED_WOODEN_IMAGE_EMPTY;
        private static String ENCODED_GREEN_GRASS_IMAGE_NULL = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE_NULL;
        private static String ENCODED_GREEN_GRASS_IMAGE_EMPTY = GreenGrassItemIcon._ENCODED_GREEN_GRASS_IMAGE_EMPTY;

        private String name;
        private String description;
        private Image image;
        private Image itemImage;
        private String group;
        private Dictionary<String, Object> attributes;

        private Boolean selected;
        private Image tempImage;
        private Boolean firstClick;

        public Item()
        {
            InitializeComponent();

            name = "Default";
            description = "   ";
            image = getIcon(ENCODED_DEFAULT_IMAGE_NULL);
            itemImage = null;
            this.group = group;
            group = "   ";
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
            image = getIcon(ENCODED_DEFAULT_IMAGE_NULL);
            itemImage = null;
            this.group = group;
            group = "   ";
            this.BackgroundImage = image;
            attributes = null;
            selected = false;
            firstClick = true;
        }

        public Item(String name, String description, String itemImagePath)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            image = getIcon(ENCODED_DEFAULT_IMAGE_EMPTY);
            this.itemImage = itemImage;
            addImageToIcon(itemImagePath);
            this.group = group;
            group = "   ";
            this.BackgroundImage = image;
            attributes = null;
            selected = false;
            firstClick = true;
        }

        public Item(String name, String description, String itemImagePath, String group, Dictionary<String, Object> attributes)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            image = getIcon(ENCODED_DEFAULT_IMAGE_EMPTY);
            this.itemImage = itemImage;
            addImageToIcon(itemImagePath);
            this.group = group;
            group = "   ";
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
        public Image ItemImage
        {
            get => itemImage;
            set => itemImage = value;
        }
        public String Group
        {
            get => group;
            set => group = value;
        }
        public Dictionary<string, object> Attributes {
            get => attributes;
            set => attributes = value;
        }

        public void addImageToIcon(String imagePath)
        {
            itemImage = Image.FromFile(imagePath);
            iconLabel.Image = ResizeImage(itemImage, 31, 31);
        }

        public static Image adjustBrightness(Image Image, int Value)
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

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static Image getIcon(String iconName)
        {

            String base64Image = iconName.Split(',')[1];
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
                BackgroundImage = adjustBrightness(BackgroundImage, 50);
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
