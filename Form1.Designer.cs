
namespace PictureViewer
{
    partial class Form1
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
            this.uiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uiPictureBox = new System.Windows.Forms.PictureBox();
            this.uiCheckbox = new System.Windows.Forms.CheckBox();
            this.uiFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.uiShowButton = new System.Windows.Forms.Button();
            this.uiClearButton = new System.Windows.Forms.Button();
            this.uiBackgroundButton = new System.Windows.Forms.Button();
            this.uiCloseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.uiTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).BeginInit();
            this.uiFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel
            // 
            this.uiTableLayoutPanel.ColumnCount = 2;
            this.uiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.uiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.uiTableLayoutPanel.Controls.Add(this.uiPictureBox, 0, 0);
            this.uiTableLayoutPanel.Controls.Add(this.uiCheckbox, 0, 1);
            this.uiTableLayoutPanel.Controls.Add(this.uiFlowLayoutPanel, 1, 1);
            this.uiTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel.Name = "uiTableLayoutPanel";
            this.uiTableLayoutPanel.RowCount = 2;
            this.uiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.uiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTableLayoutPanel.Size = new System.Drawing.Size(1018, 585);
            this.uiTableLayoutPanel.TabIndex = 0;
            // 
            // uiPictureBox
            // 
            this.uiPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uiTableLayoutPanel.SetColumnSpan(this.uiPictureBox, 2);
            this.uiPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPictureBox.Location = new System.Drawing.Point(3, 3);
            this.uiPictureBox.Name = "uiPictureBox";
            this.uiPictureBox.Size = new System.Drawing.Size(1012, 520);
            this.uiPictureBox.TabIndex = 0;
            this.uiPictureBox.TabStop = false;
            // 
            // uiCheckbox
            // 
            this.uiCheckbox.AutoSize = true;
            this.uiCheckbox.Location = new System.Drawing.Point(3, 529);
            this.uiCheckbox.Name = "uiCheckbox";
            this.uiCheckbox.Size = new System.Drawing.Size(60, 17);
            this.uiCheckbox.TabIndex = 1;
            this.uiCheckbox.Text = "Stretch";
            this.uiCheckbox.UseVisualStyleBackColor = true;
            this.uiCheckbox.CheckedChanged += new System.EventHandler(this.uiCheckbox_CheckedChanged);
            // 
            // uiFlowLayoutPanel
            // 
            this.uiFlowLayoutPanel.Controls.Add(this.uiShowButton);
            this.uiFlowLayoutPanel.Controls.Add(this.uiClearButton);
            this.uiFlowLayoutPanel.Controls.Add(this.uiBackgroundButton);
            this.uiFlowLayoutPanel.Controls.Add(this.uiCloseButton);
            this.uiFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.uiFlowLayoutPanel.Location = new System.Drawing.Point(155, 529);
            this.uiFlowLayoutPanel.Name = "uiFlowLayoutPanel";
            this.uiFlowLayoutPanel.Size = new System.Drawing.Size(860, 53);
            this.uiFlowLayoutPanel.TabIndex = 2;
            // 
            // uiShowButton
            // 
            this.uiShowButton.AutoSize = true;
            this.uiShowButton.Location = new System.Drawing.Point(769, 3);
            this.uiShowButton.Name = "uiShowButton";
            this.uiShowButton.Size = new System.Drawing.Size(88, 23);
            this.uiShowButton.TabIndex = 0;
            this.uiShowButton.Text = "Show a picture";
            this.uiShowButton.UseVisualStyleBackColor = true;
            this.uiShowButton.Click += new System.EventHandler(this.uiShowButton_Click);
            // 
            // uiClearButton
            // 
            this.uiClearButton.AutoSize = true;
            this.uiClearButton.Location = new System.Drawing.Point(669, 3);
            this.uiClearButton.Name = "uiClearButton";
            this.uiClearButton.Size = new System.Drawing.Size(94, 23);
            this.uiClearButton.TabIndex = 1;
            this.uiClearButton.Text = "Clear the picture";
            this.uiClearButton.UseVisualStyleBackColor = true;
            this.uiClearButton.Click += new System.EventHandler(this.uiClearButton_Click);
            // 
            // uiBackgroundButton
            // 
            this.uiBackgroundButton.AutoSize = true;
            this.uiBackgroundButton.Location = new System.Drawing.Point(520, 3);
            this.uiBackgroundButton.Name = "uiBackgroundButton";
            this.uiBackgroundButton.Size = new System.Drawing.Size(143, 23);
            this.uiBackgroundButton.TabIndex = 2;
            this.uiBackgroundButton.Text = "Set the background colour";
            this.uiBackgroundButton.UseVisualStyleBackColor = true;
            this.uiBackgroundButton.Click += new System.EventHandler(this.uiBackgroundButton_Click);
            // 
            // uiCloseButton
            // 
            this.uiCloseButton.AutoSize = true;
            this.uiCloseButton.Location = new System.Drawing.Point(439, 3);
            this.uiCloseButton.Name = "uiCloseButton";
            this.uiCloseButton.Size = new System.Drawing.Size(75, 23);
            this.uiCloseButton.TabIndex = 3;
            this.uiCloseButton.Text = "Close";
            this.uiCloseButton.UseVisualStyleBackColor = true;
            this.uiCloseButton.Click += new System.EventHandler(this.uiCloseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 585);
            this.Controls.Add(this.uiTableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.uiTableLayoutPanel.ResumeLayout(false);
            this.uiTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox)).EndInit();
            this.uiFlowLayoutPanel.ResumeLayout(false);
            this.uiFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTableLayoutPanel;
        private System.Windows.Forms.PictureBox uiPictureBox;
        private System.Windows.Forms.CheckBox uiCheckbox;
        private System.Windows.Forms.FlowLayoutPanel uiFlowLayoutPanel;
        private System.Windows.Forms.Button uiShowButton;
        private System.Windows.Forms.Button uiClearButton;
        private System.Windows.Forms.Button uiBackgroundButton;
        private System.Windows.Forms.Button uiCloseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

