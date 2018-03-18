namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inventoryComponent1 = new Inventory.InventoryComponent();
            this.item1 = new Inventory.Item();
            this.SuspendLayout();
            // 
            // inventoryComponent1
            // 
            this.inventoryComponent1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inventoryComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryComponent1.Location = new System.Drawing.Point(190, 34);
            this.inventoryComponent1.MaximumSize = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.MinimumSize = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.Name = "inventoryComponent1";
            this.inventoryComponent1.Size = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.TabIndex = 0;
            // 
            // item1
            // 
            this.item1.Attributes = null;
            this.item1.AutoSize = true;
            this.item1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("item1.BackgroundImage")));
            this.item1.Description = "   ";
            this.item1.Image = ((System.Drawing.Image)(resources.GetObject("item1.Image")));
            this.item1.ItemName = "Default";
            this.item1.Location = new System.Drawing.Point(66, 124);
            this.item1.MaximumSize = new System.Drawing.Size(50, 50);
            this.item1.MinimumSize = new System.Drawing.Size(50, 50);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(50, 50);
            this.item1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 580);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.inventoryComponent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryComponent inventoryComponent1;
        private Item item1;
    }
}

