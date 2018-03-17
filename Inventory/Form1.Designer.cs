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
            this.inventoryComponent1 = new Inventory.InventoryComponent();
            this.SuspendLayout();
            // 
            // inventoryComponent1
            // 
            this.inventoryComponent1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inventoryComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryComponent1.Location = new System.Drawing.Point(150, 12);
            this.inventoryComponent1.MaximumSize = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.MinimumSize = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.Name = "inventoryComponent1";
            this.inventoryComponent1.Size = new System.Drawing.Size(400, 500);
            this.inventoryComponent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 580);
            this.Controls.Add(this.inventoryComponent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InventoryComponent inventoryComponent1;
    }
}

