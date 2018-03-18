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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.ItemInfoPanel.Controls.Add(this.textBox2);
            this.ItemInfoPanel.Controls.Add(this.textBox1);
            this.ItemInfoPanel.Controls.Add(this.label1);
            this.ItemInfoPanel.Controls.Add(this.label2);
            this.ItemInfoPanel.Location = new System.Drawing.Point(18, 323);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(360, 156);
            this.ItemInfoPanel.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(350, 51);
            this.textBox2.TabIndex = 3;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
