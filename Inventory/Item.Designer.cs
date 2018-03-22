namespace Inventory
{
    partial class Item
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.transparentClickablePanel1 = new Inventory.TransparentClickablePanel();
            this.SuspendLayout();
            // 
            // transparentClickablePanel1
            // 
            this.transparentClickablePanel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentClickablePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.transparentClickablePanel1.ForeColor = System.Drawing.Color.Transparent;
            this.transparentClickablePanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentClickablePanel1.Name = "transparentClickablePanel1";
            this.transparentClickablePanel1.Size = new System.Drawing.Size(50, 50);
            this.transparentClickablePanel1.TabIndex = 1;
            this.transparentClickablePanel1.Click += new System.EventHandler(this.transparentClickablePanel1_Click);
            this.transparentClickablePanel1.Leave += new System.EventHandler(this.transparentClickablePanel1_Leave);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.transparentClickablePanel1);
            this.MaximumSize = new System.Drawing.Size(50, 50);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        public TransparentClickablePanel transparentClickablePanel1;
    }
}
