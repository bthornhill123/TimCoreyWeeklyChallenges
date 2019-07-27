namespace ImageManipulator
{
    partial class Dashboard
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
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.selectedFileName = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.newFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newFileTypeLabel = new System.Windows.Forms.Label();
            this.newFileTypeDropdown = new System.Windows.Forms.ComboBox();
            this.processChangeButton = new System.Windows.Forms.Button();
            this.newImageSizeDropdown = new System.Windows.Forms.ComboBox();
            this.newImageSizeLabel = new System.Windows.Forms.Label();
            this.resizeImageLabel = new System.Windows.Forms.Label();
            this.resizeImageCheckbox = new System.Windows.Forms.CheckBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.Location = new System.Drawing.Point(32, 36);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(156, 29);
            this.selectedFileLabel.TabIndex = 0;
            this.selectedFileLabel.Text = "Selected File";
            // 
            // selectedFileName
            // 
            this.selectedFileName.Location = new System.Drawing.Point(205, 33);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(425, 35);
            this.selectedFileName.TabIndex = 1;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(636, 31);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(50, 39);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // newFileName
            // 
            this.newFileName.Location = new System.Drawing.Point(222, 76);
            this.newFileName.Name = "newFileName";
            this.newFileName.Size = new System.Drawing.Size(189, 35);
            this.newFileName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "New File Name";
            // 
            // newFileTypeLabel
            // 
            this.newFileTypeLabel.AutoSize = true;
            this.newFileTypeLabel.Location = new System.Drawing.Point(32, 136);
            this.newFileTypeLabel.Name = "newFileTypeLabel";
            this.newFileTypeLabel.Size = new System.Drawing.Size(171, 29);
            this.newFileTypeLabel.TabIndex = 5;
            this.newFileTypeLabel.Text = "New File Type";
            // 
            // newFileTypeDropdown
            // 
            this.newFileTypeDropdown.FormattingEnabled = true;
            this.newFileTypeDropdown.Location = new System.Drawing.Point(222, 133);
            this.newFileTypeDropdown.Name = "newFileTypeDropdown";
            this.newFileTypeDropdown.Size = new System.Drawing.Size(189, 37);
            this.newFileTypeDropdown.TabIndex = 6;
            // 
            // processChangeButton
            // 
            this.processChangeButton.Location = new System.Drawing.Point(222, 402);
            this.processChangeButton.Name = "processChangeButton";
            this.processChangeButton.Size = new System.Drawing.Size(336, 97);
            this.processChangeButton.TabIndex = 7;
            this.processChangeButton.Text = "Process";
            this.processChangeButton.UseVisualStyleBackColor = true;
            this.processChangeButton.Click += new System.EventHandler(this.ProcessChangeButton_Click);
            // 
            // newImageSizeDropdown
            // 
            this.newImageSizeDropdown.FormattingEnabled = true;
            this.newImageSizeDropdown.Location = new System.Drawing.Point(222, 239);
            this.newImageSizeDropdown.Name = "newImageSizeDropdown";
            this.newImageSizeDropdown.Size = new System.Drawing.Size(189, 37);
            this.newImageSizeDropdown.TabIndex = 9;
            this.newImageSizeDropdown.SelectedIndexChanged += new System.EventHandler(this.NewImageSizeDropdown_SelectedIndexChanged);
            // 
            // newImageSizeLabel
            // 
            this.newImageSizeLabel.AutoSize = true;
            this.newImageSizeLabel.Location = new System.Drawing.Point(32, 242);
            this.newImageSizeLabel.Name = "newImageSizeLabel";
            this.newImageSizeLabel.Size = new System.Drawing.Size(189, 29);
            this.newImageSizeLabel.TabIndex = 8;
            this.newImageSizeLabel.Text = "New Image Size";
            // 
            // resizeImageLabel
            // 
            this.resizeImageLabel.AutoSize = true;
            this.resizeImageLabel.Location = new System.Drawing.Point(32, 193);
            this.resizeImageLabel.Name = "resizeImageLabel";
            this.resizeImageLabel.Size = new System.Drawing.Size(160, 29);
            this.resizeImageLabel.TabIndex = 10;
            this.resizeImageLabel.Text = "Resize Image";
            // 
            // resizeImageCheckbox
            // 
            this.resizeImageCheckbox.AutoSize = true;
            this.resizeImageCheckbox.Location = new System.Drawing.Point(209, 201);
            this.resizeImageCheckbox.Name = "resizeImageCheckbox";
            this.resizeImageCheckbox.Size = new System.Drawing.Size(15, 14);
            this.resizeImageCheckbox.TabIndex = 11;
            this.resizeImageCheckbox.UseVisualStyleBackColor = true;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(495, 310);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(32, 29);
            this.heightLabel.TabIndex = 12;
            this.heightLabel.Text = "h:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(255, 307);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(37, 29);
            this.widthLabel.TabIndex = 13;
            this.widthLabel.Text = "w:";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(300, 304);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(189, 35);
            this.widthText.TabIndex = 14;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(533, 304);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(189, 35);
            this.heightText.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dimensions";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.resizeImageCheckbox);
            this.Controls.Add(this.resizeImageLabel);
            this.Controls.Add(this.newImageSizeDropdown);
            this.Controls.Add(this.newImageSizeLabel);
            this.Controls.Add(this.processChangeButton);
            this.Controls.Add(this.newFileTypeDropdown);
            this.Controls.Add(this.newFileTypeLabel);
            this.Controls.Add(this.newFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.selectedFileName);
            this.Controls.Add(this.selectedFileLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Dashboard";
            this.Text = "Image Manipulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFileLabel;
        private System.Windows.Forms.TextBox selectedFileName;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox newFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newFileTypeLabel;
        private System.Windows.Forms.ComboBox newFileTypeDropdown;
        private System.Windows.Forms.Button processChangeButton;
        private System.Windows.Forms.ComboBox newImageSizeDropdown;
        private System.Windows.Forms.Label newImageSizeLabel;
        private System.Windows.Forms.Label resizeImageLabel;
        private System.Windows.Forms.CheckBox resizeImageCheckbox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label2;
    }
}

