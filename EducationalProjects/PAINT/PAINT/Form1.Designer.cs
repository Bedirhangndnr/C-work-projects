
namespace PAINT
{
    partial class MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Black_Btn = new System.Windows.Forms.ToolStripButton();
            this.Red_Btn = new System.Windows.Forms.ToolStripButton();
            this.Gold_Btn = new System.Windows.Forms.ToolStripButton();
            this.PenSize = new System.Windows.Forms.ToolStripDropDownButton();
            this.PenSize_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.PenSize_20 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.squareBtn = new System.Windows.Forms.ToolStripButton();
            this.triangleBtn = new System.Windows.Forms.ToolStripButton();
            this.Board_PB = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.eraseBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_MenuItem,
            this.Open_Menu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.Size = new System.Drawing.Size(103, 22);
            this.Save_MenuItem.Text = "Save";
            this.Save_MenuItem.Click += new System.EventHandler(this.Save_MenuItem_Click);
            // 
            // Open_Menu
            // 
            this.Open_Menu.Name = "Open_Menu";
            this.Open_Menu.Size = new System.Drawing.Size(103, 22);
            this.Open_Menu.Text = "Open";
            this.Open_Menu.Click += new System.EventHandler(this.Open_Menu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Black_Btn,
            this.Red_Btn,
            this.Gold_Btn,
            this.PenSize,
            this.lineBtn,
            this.squareBtn,
            this.triangleBtn,
            this.eraseBtn,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Black_Btn
            // 
            this.Black_Btn.AutoSize = false;
            this.Black_Btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Black_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Black_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Black_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black_Btn.Name = "Black_Btn";
            this.Black_Btn.Size = new System.Drawing.Size(50, 28);
            this.Black_Btn.Text = "Black";
            this.Black_Btn.Click += new System.EventHandler(this.Black_Btn_Click);
            // 
            // Red_Btn
            // 
            this.Red_Btn.AutoSize = false;
            this.Red_Btn.BackColor = System.Drawing.Color.Red;
            this.Red_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Red_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Red_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red_Btn.Name = "Red_Btn";
            this.Red_Btn.Size = new System.Drawing.Size(50, 28);
            this.Red_Btn.Text = "Red";
            this.Red_Btn.Click += new System.EventHandler(this.Red_Btn_Click);
            // 
            // Gold_Btn
            // 
            this.Gold_Btn.AutoSize = false;
            this.Gold_Btn.AutoToolTip = false;
            this.Gold_Btn.BackColor = System.Drawing.Color.Gold;
            this.Gold_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Gold_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gold_Btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gold_Btn.Name = "Gold_Btn";
            this.Gold_Btn.Size = new System.Drawing.Size(50, 28);
            this.Gold_Btn.Text = "Gold";
            this.Gold_Btn.Click += new System.EventHandler(this.Gold_Btn_Click);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = false;
            this.PenSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PenSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PenSize_5,
            this.PenSize_10,
            this.PenSize_15,
            this.PenSize_20});
            this.PenSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(60, 28);
            this.PenSize.Text = "PenSize";
            this.PenSize.Click += new System.EventHandler(this.PenSize_Click);
            // 
            // PenSize_5
            // 
            this.PenSize_5.Name = "PenSize_5";
            this.PenSize_5.Size = new System.Drawing.Size(86, 22);
            this.PenSize_5.Text = "5";
            this.PenSize_5.Click += new System.EventHandler(this.PenSize_5_Click);
            // 
            // PenSize_10
            // 
            this.PenSize_10.Name = "PenSize_10";
            this.PenSize_10.Size = new System.Drawing.Size(86, 22);
            this.PenSize_10.Text = "10";
            this.PenSize_10.Click += new System.EventHandler(this.PenSize_10_Click);
            // 
            // PenSize_15
            // 
            this.PenSize_15.Name = "PenSize_15";
            this.PenSize_15.Size = new System.Drawing.Size(86, 22);
            this.PenSize_15.Text = "15";
            this.PenSize_15.Click += new System.EventHandler(this.PenSize_15_Click);
            // 
            // PenSize_20
            // 
            this.PenSize_20.Name = "PenSize_20";
            this.PenSize_20.Size = new System.Drawing.Size(86, 22);
            this.PenSize_20.Text = "20";
            this.PenSize_20.Click += new System.EventHandler(this.PenSize_20_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBtn.Image = ((System.Drawing.Image)(resources.GetObject("lineBtn.Image")));
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(23, 22);
            this.lineBtn.Text = "lineBtn";
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squareBtn.Image = ((System.Drawing.Image)(resources.GetObject("squareBtn.Image")));
            this.squareBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(23, 22);
            this.squareBtn.Text = "squareBtn";
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleBtn.Image = ((System.Drawing.Image)(resources.GetObject("triangleBtn.Image")));
            this.triangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(23, 22);
            this.triangleBtn.Text = "triangleBtn";
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // Board_PB
            // 
            this.Board_PB.Location = new System.Drawing.Point(0, 77);
            this.Board_PB.Name = "Board_PB";
            this.Board_PB.Size = new System.Drawing.Size(800, 372);
            this.Board_PB.TabIndex = 2;
            this.Board_PB.TabStop = false;
            this.Board_PB.Click += new System.EventHandler(this.Board_PB_Click);
            this.Board_PB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseDown);
            this.Board_PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseMove);
            this.Board_PB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Board_PB_MouseUp);
            // 
            // eraseBtn
            // 
            this.eraseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(23, 22);
            this.eraseBtn.Text = "eraseBtn";
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Board_PB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Board_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_Menu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Black_Btn;
        private System.Windows.Forms.ToolStripButton Red_Btn;
        private System.Windows.Forms.ToolStripButton Gold_Btn;
        private System.Windows.Forms.ToolStripDropDownButton PenSize;
        private System.Windows.Forms.ToolStripMenuItem PenSize_5;
        private System.Windows.Forms.ToolStripMenuItem PenSize_10;
        private System.Windows.Forms.ToolStripMenuItem PenSize_15;
        private System.Windows.Forms.ToolStripMenuItem PenSize_20;
        private System.Windows.Forms.PictureBox Board_PB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton lineBtn;
        private System.Windows.Forms.ToolStripButton squareBtn;
        private System.Windows.Forms.ToolStripButton triangleBtn;
        private System.Windows.Forms.ToolStripButton eraseBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

