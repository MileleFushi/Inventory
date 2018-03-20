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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.attributesTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsList = new System.Windows.Forms.ListView();
            this.ItemInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryInPanel
            // 
            this.InventoryInPanel.AutoScroll = true;
            this.InventoryInPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InventoryInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryInPanel.Location = new System.Drawing.Point(24, 149);
            this.InventoryInPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InventoryInPanel.Name = "InventoryInPanel";
            this.InventoryInPanel.Size = new System.Drawing.Size(479, 222);
            this.InventoryInPanel.TabIndex = 0;
            // 
            // ItemInfoPanel
            // 
            this.ItemInfoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ItemInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemInfoPanel.Controls.Add(this.descriptionTextBox);
            this.ItemInfoPanel.Controls.Add(this.groupTextBox);
            this.ItemInfoPanel.Controls.Add(this.nameTextBox);
            this.ItemInfoPanel.Controls.Add(this.attributesTextBox);
            this.ItemInfoPanel.Location = new System.Drawing.Point(24, 398);
            this.ItemInfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(479, 191);
            this.ItemInfoPanel.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(4, 80);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(267, 103);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // groupTextBox
            // 
            this.groupTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupTextBox.Location = new System.Drawing.Point(4, 43);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTextBox.Multiline = true;
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.ReadOnly = true;
            this.groupTextBox.Size = new System.Drawing.Size(267, 29);
            this.groupTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(4, 6);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(267, 29);
            this.nameTextBox.TabIndex = 4;
            // 
            // attributesTextBox
            // 
            this.attributesTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.attributesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesTextBox.Location = new System.Drawing.Point(280, 6);
            this.attributesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attributesTextBox.Multiline = true;
            this.attributesTextBox.Name = "attributesTextBox";
            this.attributesTextBox.ReadOnly = true;
            this.attributesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attributesTextBox.Size = new System.Drawing.Size(190, 177);
            this.attributesTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Blue Elegant",
            "Wooden",
            "Green Grass"});
            this.comboBox1.Location = new System.Drawing.Point(24, 77);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupsList
            // 
            this.groupsList.Location = new System.Drawing.Point(24, 127);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(479, 24);
            this.groupsList.TabIndex = 7;
            this.groupsList.UseCompatibleStateImageBehavior = false;
            this.groupsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // InventoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupsList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ItemInfoPanel);
            this.Controls.Add(this.InventoryInPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(533, 615);
            this.MinimumSize = new System.Drawing.Size(533, 615);
            this.Name = "InventoryComponent";
            this.Size = new System.Drawing.Size(531, 613);
            this.ItemInfoPanel.ResumeLayout(false);
            this.ItemInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel InventoryInPanel;
        private System.Windows.Forms.Panel ItemInfoPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox attributesTextBox;
        private System.Windows.Forms.ListView groupsList;
    }
}
