namespace Inventory
{
    partial class InventoryComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryInPanel = new System.Windows.Forms.Panel();
            this.ItemInfoPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ItemInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryInPanel
            // 
            this.InventoryInPanel.AutoScroll = true;
            this.InventoryInPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InventoryInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryInPanel.Location = new System.Drawing.Point(18, 121);
            this.InventoryInPanel.Name = "InventoryInPanel";
            this.InventoryInPanel.Size = new System.Drawing.Size(360, 181);
            this.InventoryInPanel.TabIndex = 0;
            // 
            // ItemInfoPanel
            // 
            this.ItemInfoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ItemInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemInfoPanel.Controls.Add(this.descriptionLabel);
            this.ItemInfoPanel.Controls.Add(this.nameLabel);
            this.ItemInfoPanel.Location = new System.Drawing.Point(18, 323);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(360, 156);
            this.ItemInfoPanel.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(0, 27);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(36, 16);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Opis";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(0, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(337, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Blue Elegant",
            "Wooden",
            "Green Grass"});
            this.comboBox1.Location = new System.Drawing.Point(18, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InventoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemInfoPanel);
            this.Controls.Add(this.InventoryInPanel);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "InventoryComponent";
            this.Size = new System.Drawing.Size(398, 498);
            this.ItemInfoPanel.ResumeLayout(false);
            this.ItemInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InventoryInPanel;
        private System.Windows.Forms.Panel ItemInfoPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}
