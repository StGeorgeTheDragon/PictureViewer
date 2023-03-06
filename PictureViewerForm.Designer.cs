namespace PictureViewer
{
    partial class PictureViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureViewerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.slideShow = new System.Windows.Forms.ToolStripButton();
            this.trash = new System.Windows.Forms.ToolStripButton();
            this.pause = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.themeDropDown,
            this.toolStripButton1,
            this.toolStripButton2,
            this.slideShow,
            this.trash,
            this.pause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 26);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 23);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click_1);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // themeDropDown
            // 
            this.themeDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.themeDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.themeDropDown.Image = ((System.Drawing.Image)(resources.GetObject("themeDropDown.Image")));
            this.themeDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeDropDown.Name = "themeDropDown";
            this.themeDropDown.Size = new System.Drawing.Size(63, 23);
            this.themeDropDown.Text = "Theme";
            this.themeDropDown.ToolTipText = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click_1);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::PictureViewer.Properties.Resources.backward;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Previous";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::PictureViewer.Properties.Resources.forward;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 23);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Next";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // slideShow
            // 
            this.slideShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.slideShow.Image = global::PictureViewer.Properties.Resources.play;
            this.slideShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.slideShow.Name = "slideShow";
            this.slideShow.Size = new System.Drawing.Size(24, 23);
            this.slideShow.Text = "toolStripButton3";
            this.slideShow.ToolTipText = "Slideshow";
            this.slideShow.Click += new System.EventHandler(this.slideShow_Click);
            // 
            // trash
            // 
            this.trash.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.trash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trash.Image = global::PictureViewer.Properties.Resources.trash;
            this.trash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(24, 23);
            this.trash.Text = "toolStripButton4";
            this.trash.ToolTipText = "Trash";
            // 
            // pause
            // 
            this.pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pause.Image = global::PictureViewer.Properties.Resources.Pause;
            this.pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(24, 23);
            this.pause.Text = "pause";
            this.pause.ToolTipText = "Pause";
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-9, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 501);
            this.panel1.TabIndex = 8;
            // 
            // PictureViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PictureViewerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PictureBox1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripButton slideShow;
        private ToolStripButton trash;
        private ToolStripDropDownButton themeDropDown;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripButton pause;
        private Panel panel1;
    }
}