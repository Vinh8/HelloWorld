namespace Lab_6_1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.coneTypeLabel = new System.Windows.Forms.Label();
            this.sugarConeRadioButton = new System.Windows.Forms.RadioButton();
            this.waffleConeRadioButton = new System.Windows.Forms.RadioButton();
            this.iceCreamFlavorLabel = new System.Windows.Forms.Label();
            this.iceCreamFlavorComboBox = new System.Windows.Forms.ComboBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coneTypeLabel
            // 
            this.coneTypeLabel.AutoSize = true;
            this.coneTypeLabel.Location = new System.Drawing.Point(9, 237);
            this.coneTypeLabel.Name = "coneTypeLabel";
            this.coneTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.coneTypeLabel.TabIndex = 1;
            this.coneTypeLabel.Text = "Cone Type:";
            this.coneTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sugarConeRadioButton
            // 
            this.sugarConeRadioButton.AutoSize = true;
            this.sugarConeRadioButton.Checked = true;
            this.sugarConeRadioButton.Location = new System.Drawing.Point(77, 235);
            this.sugarConeRadioButton.Name = "sugarConeRadioButton";
            this.sugarConeRadioButton.Size = new System.Drawing.Size(81, 17);
            this.sugarConeRadioButton.TabIndex = 2;
            this.sugarConeRadioButton.TabStop = true;
            this.sugarConeRadioButton.Text = "Sugar Cone";
            this.sugarConeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sugarConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // waffleConeRadioButton
            // 
            this.waffleConeRadioButton.AutoSize = true;
            this.waffleConeRadioButton.Location = new System.Drawing.Point(164, 233);
            this.waffleConeRadioButton.Name = "waffleConeRadioButton";
            this.waffleConeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.waffleConeRadioButton.TabIndex = 3;
            this.waffleConeRadioButton.Text = "Waffle Cone";
            this.waffleConeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.waffleConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // iceCreamFlavorLabel
            // 
            this.iceCreamFlavorLabel.AutoSize = true;
            this.iceCreamFlavorLabel.Location = new System.Drawing.Point(9, 260);
            this.iceCreamFlavorLabel.Name = "iceCreamFlavorLabel";
            this.iceCreamFlavorLabel.Size = new System.Drawing.Size(90, 13);
            this.iceCreamFlavorLabel.TabIndex = 4;
            this.iceCreamFlavorLabel.Text = "Ice Cream Flavor:";
            this.iceCreamFlavorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iceCreamFlavorComboBox
            // 
            this.iceCreamFlavorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iceCreamFlavorComboBox.FormattingEnabled = true;
            this.iceCreamFlavorComboBox.Location = new System.Drawing.Point(105, 260);
            this.iceCreamFlavorComboBox.Name = "iceCreamFlavorComboBox";
            this.iceCreamFlavorComboBox.Size = new System.Drawing.Size(121, 21);
            this.iceCreamFlavorComboBox.TabIndex = 5;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(46, 300);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(54, 13);
            this.toppingsLabel.TabIndex = 6;
            this.toppingsLabel.Text = "Toppings:";
            this.toppingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.Location = new System.Drawing.Point(106, 300);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(120, 95);
            this.toppingsListBox.TabIndex = 7;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(250, 24);
            this.mainMenuStrip.TabIndex = 10;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_6_1.Properties.Resources.icecream;
            this.pictureBox1.Location = new System.Drawing.Point(42, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 402);
            this.Controls.Add(this.toppingsListBox);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.iceCreamFlavorComboBox);
            this.Controls.Add(this.iceCreamFlavorLabel);
            this.Controls.Add(this.waffleConeRadioButton);
            this.Controls.Add(this.sugarConeRadioButton);
            this.Controls.Add(this.coneTypeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Ice Cream Emporium";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label coneTypeLabel;
        private System.Windows.Forms.RadioButton sugarConeRadioButton;
        private System.Windows.Forms.RadioButton waffleConeRadioButton;
        private System.Windows.Forms.Label iceCreamFlavorLabel;
        private System.Windows.Forms.ComboBox iceCreamFlavorComboBox;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

