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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemInfoPanel = new System.Windows.Forms.Panel();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ItemEditingPanel = new System.Windows.Forms.Panel();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.InventoryInPanel.SuspendLayout();
            this.ItemInfoPanel.SuspendLayout();
            this.ItemEditingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryInPanel
            // 
            this.InventoryInPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InventoryInPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryInPanel.Controls.Add(this.vScrollBar1);
            this.InventoryInPanel.Controls.Add(this.label1);
            this.InventoryInPanel.Location = new System.Drawing.Point(18, 121);
            this.InventoryInPanel.Name = "InventoryInPanel";
            this.InventoryInPanel.Size = new System.Drawing.Size(360, 181);
            this.InventoryInPanel.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(338, -2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 181);
            this.vScrollBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "< -- dlugosc 6ciu ikon -- >";
            // 
            // ItemInfoPanel
            // 
            this.ItemInfoPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ItemInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemInfoPanel.Controls.Add(this.vScrollBar2);
            this.ItemInfoPanel.Location = new System.Drawing.Point(18, 323);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(178, 156);
            this.ItemInfoPanel.TabIndex = 1;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(340, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(19, 95);
            this.vScrollBar2.TabIndex = 0;
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
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ItemEditingPanel
            // 
            this.ItemEditingPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ItemEditingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemEditingPanel.Controls.Add(this.vScrollBar3);
            this.ItemEditingPanel.Location = new System.Drawing.Point(202, 323);
            this.ItemEditingPanel.Name = "ItemEditingPanel";
            this.ItemEditingPanel.Size = new System.Drawing.Size(178, 158);
            this.ItemEditingPanel.TabIndex = 7;
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(340, 0);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(19, 95);
            this.vScrollBar3.TabIndex = 0;
            // 
            // InventoryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ItemEditingPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ItemInfoPanel);
            this.Controls.Add(this.InventoryInPanel);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "InventoryComponent";
            this.Size = new System.Drawing.Size(398, 498);
            this.InventoryInPanel.ResumeLayout(false);
            this.InventoryInPanel.PerformLayout();
            this.ItemInfoPanel.ResumeLayout(false);
            this.ItemEditingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InventoryInPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel ItemInfoPanel;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel ItemEditingPanel;
        private System.Windows.Forms.VScrollBar vScrollBar3;
    }
}
