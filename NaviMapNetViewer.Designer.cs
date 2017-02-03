namespace NaviMapNet
{
    partial class NaviMapNetViewer
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.mapImage = new System.Windows.Forms.PictureBox();
            this.zoomLevels = new System.Windows.Forms.PictureBox();
            this.crossImage = new System.Windows.Forms.PictureBox();
            this.scaleImage = new System.Windows.Forms.PictureBox();
            this.selMapType = new System.Windows.Forms.ComboBox();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.White;
            this.imagePanel.Controls.Add(this.mapImage);
            this.imagePanel.Location = new System.Drawing.Point(37, 32);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(522, 367);
            this.imagePanel.TabIndex = 3;
            // 
            // mapImage
            // 
            this.mapImage.ErrorImage = null;
            this.mapImage.Location = new System.Drawing.Point(-34, 76);
            this.mapImage.Name = "mapImage";
            this.mapImage.Size = new System.Drawing.Size(243, 132);
            this.mapImage.TabIndex = 5;
            this.mapImage.TabStop = false;
            this.mapImage.MouseLeave += new System.EventHandler(this.mapImage_MouseLeave);
            this.mapImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseMove);
            this.mapImage.Click += new System.EventHandler(this.mapImage_Click);
            this.mapImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseDoubleClick);
            this.mapImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseClick);
            this.mapImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseDown);
            this.mapImage.MouseHover += new System.EventHandler(this.mapImage_MouseHover);
            this.mapImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapImage_MouseUp);
            this.mapImage.MouseEnter += new System.EventHandler(this.mapImage_MouseEnter);
            // 
            // zoomLevels
            // 
            this.zoomLevels.Location = new System.Drawing.Point(547, 302);
            this.zoomLevels.Name = "zoomLevels";
            this.zoomLevels.Size = new System.Drawing.Size(27, 237);
            this.zoomLevels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.zoomLevels.TabIndex = 7;
            this.zoomLevels.TabStop = false;
            this.zoomLevels.MouseLeave += new System.EventHandler(this.zoomLevels_MouseLeave);
            this.zoomLevels.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zoomLevels_MouseMove);
            this.zoomLevels.Click += new System.EventHandler(this.zoomLevels_Click);
            this.zoomLevels.Paint += new System.Windows.Forms.PaintEventHandler(this.zoomLevels_Paint);
            this.zoomLevels.MouseEnter += new System.EventHandler(this.zoomLevels_MouseEnter);
            // 
            // crossImage
            // 
            this.crossImage.BackColor = System.Drawing.Color.Transparent;
            this.crossImage.Location = new System.Drawing.Point(347, 424);
            this.crossImage.Name = "crossImage";
            this.crossImage.Size = new System.Drawing.Size(100, 50);
            this.crossImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.crossImage.TabIndex = 8;
            this.crossImage.TabStop = false;
            this.crossImage.Visible = false;
            // 
            // scaleImage
            // 
            this.scaleImage.BackColor = System.Drawing.Color.Transparent;
            this.scaleImage.Location = new System.Drawing.Point(252, 489);
            this.scaleImage.Name = "scaleImage";
            this.scaleImage.Size = new System.Drawing.Size(264, 50);
            this.scaleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scaleImage.TabIndex = 9;
            this.scaleImage.TabStop = false;
            // 
            // selMapType
            // 
            this.selMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selMapType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selMapType.FormattingEnabled = true;
            this.selMapType.Location = new System.Drawing.Point(3, 3);
            this.selMapType.Name = "selMapType";
            this.selMapType.Size = new System.Drawing.Size(172, 21);
            this.selMapType.TabIndex = 10;
            this.selMapType.Visible = false;
            this.selMapType.SelectedIndexChanged += new System.EventHandler(this.selMapType_SelectedIndexChanged);
            // 
            // NaviMapNetViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selMapType);
            this.Controls.Add(this.scaleImage);
            this.Controls.Add(this.crossImage);
            this.Controls.Add(this.zoomLevels);
            this.Controls.Add(this.imagePanel);
            this.Name = "NaviMapNetViewer";
            this.Size = new System.Drawing.Size(600, 600);
            this.Resize += new System.EventHandler(this.onControlResize);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox mapImage;
        private System.Windows.Forms.PictureBox zoomLevels;
        private System.Windows.Forms.PictureBox crossImage;
        private System.Windows.Forms.PictureBox scaleImage;
        private System.Windows.Forms.ComboBox selMapType;

    }
}
