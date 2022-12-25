namespace Lab_6_1
{
    partial class AboutForm
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
            this.copyRightLogoLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // copyRightLogoLabel
            // 
            this.copyRightLogoLabel.AutoSize = true;
            this.copyRightLogoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyRightLogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLogoLabel.Location = new System.Drawing.Point(111, 12);
            this.copyRightLogoLabel.Name = "copyRightLogoLabel";
            this.copyRightLogoLabel.Size = new System.Drawing.Size(295, 50);
            this.copyRightLogoLabel.TabIndex = 1;
            this.copyRightLogoLabel.Text = "Joe\'s Ice Cream emporium \r\nCopyright 2016 by W. Whitlock\r\n";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(219, 75);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // aboutPictureBox
            // 
            this.aboutPictureBox.Image = global::Lab_6_1.Properties.Resources.icecream;
            this.aboutPictureBox.Location = new System.Drawing.Point(12, 12);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(87, 86);
            this.aboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutPictureBox.TabIndex = 0;
            this.aboutPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 106);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.copyRightLogoLabel);
            this.Controls.Add(this.aboutPictureBox);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aboutPictureBox;
        private System.Windows.Forms.Label copyRightLogoLabel;
        private System.Windows.Forms.Button closeButton;
    }
}