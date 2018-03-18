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
            this.iconLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconLabel
            // 
            this.iconLabel.BackColor = System.Drawing.Color.Transparent;
            this.iconLabel.Location = new System.Drawing.Point(9, 8);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(31, 31);
            this.iconLabel.TabIndex = 0;
            this.iconLabel.Text = " ";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.iconLabel);
            this.MaximumSize = new System.Drawing.Size(50, 50);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(50, 50);
            this.Leave += new System.EventHandler(this.Item_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Item_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label iconLabel;
    }
}
