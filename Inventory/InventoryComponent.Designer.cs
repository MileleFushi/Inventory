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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Wszystkie");
            this.InventoryInPanel = new System.Windows.Forms.Panel();
            this.ItemInfoPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.attributesTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsList = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryInPanel
            // 
            this.InventoryInPanel.AutoScroll = true;
            this.InventoryInPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InventoryInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryInPanel.Location = new System.Drawing.Point(20, 115);
            this.InventoryInPanel.Name = "InventoryInPanel";
            this.InventoryInPanel.Size = new System.Drawing.Size(360, 164);
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
            this.ItemInfoPanel.Location = new System.Drawing.Point(20, 300);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(360, 156);
            this.ItemInfoPanel.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 65);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(201, 84);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // groupTextBox
            // 
            this.groupTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupTextBox.Location = new System.Drawing.Point(3, 35);
            this.groupTextBox.Multiline = true;
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.ReadOnly = true;
            this.groupTextBox.Size = new System.Drawing.Size(201, 24);
            this.groupTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(3, 5);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(201, 24);
            this.nameTextBox.TabIndex = 4;
            // 
            // attributesTextBox
            // 
            this.attributesTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.attributesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesTextBox.Location = new System.Drawing.Point(210, 5);
            this.attributesTextBox.Multiline = true;
            this.attributesTextBox.Name = "attributesTextBox";
            this.attributesTextBox.ReadOnly = true;
            this.attributesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attributesTextBox.Size = new System.Drawing.Size(143, 144);
            this.attributesTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Blue Elegant",
            "Wooden",
            "Green Grass"});
            this.comboBox1.Location = new System.Drawing.Point(20, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupsList
            // 
            this.groupsList.Location = new System.Drawing.Point(20, 80);
            this.groupsList.Margin = new System.Windows.Forms.Padding(2);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(360, 30);
            this.groupsList.TabIndex = 7;
            this.groupsList.UseCompatibleStateImageBehavior = false;
            this.groupsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(297, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(83, 30);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // InventoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupsList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ItemInfoPanel);
            this.Controls.Add(this.InventoryInPanel);
            this.MaximumSize = new System.Drawing.Size(400, 475);
            this.MinimumSize = new System.Drawing.Size(400, 475);
            this.Name = "InventoryComponent";
            this.Size = new System.Drawing.Size(398, 473);
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
        private System.Windows.Forms.ListView listView1;
    }
}
