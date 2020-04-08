namespace StudioPlatform
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.sc = new StudioPlatform.BrowserSettingContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlWindow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.tabControl1);
            this.pnlWindow.Size = new System.Drawing.Size(918, 547);
            this.pnlWindow.Controls.SetChildIndex(this.tabControl1, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(160, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 515);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(444, 509);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Active = false;
            this.btnStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = 0;
            this.btnStart.ButtonText = "Start";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStart.Iconimage")));
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = false;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = false;
            this.btnStart.IconZoom = 90D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(10, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.Green;
            this.btnStart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btnStart.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(424, 489);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(453, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(445, 509);
            this.panel3.TabIndex = 0;
            // 
            // btnKill
            // 
            this.btnKill.Active = false;
            this.btnKill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKill.BorderRadius = 0;
            this.btnKill.ButtonText = "Close";
            this.btnKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKill.DisabledColor = System.Drawing.Color.Gray;
            this.btnKill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKill.Iconimage")));
            this.btnKill.Iconimage_right = null;
            this.btnKill.Iconimage_right_Selected = null;
            this.btnKill.Iconimage_Selected = null;
            this.btnKill.IconMarginLeft = 0;
            this.btnKill.IconMarginRight = 0;
            this.btnKill.IconRightVisible = false;
            this.btnKill.IconRightZoom = 0D;
            this.btnKill.IconVisible = false;
            this.btnKill.IconZoom = 90D;
            this.btnKill.IsTab = false;
            this.btnKill.Location = new System.Drawing.Point(10, 10);
            this.btnKill.Margin = new System.Windows.Forms.Padding(10);
            this.btnKill.Name = "btnKill";
            this.btnKill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnKill.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKill.selected = false;
            this.btnKill.Size = new System.Drawing.Size(425, 489);
            this.btnKill.TabIndex = 0;
            this.btnKill.Text = "Close";
            this.btnKill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKill.Textcolor = System.Drawing.Color.White;
            this.btnKill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 547);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 431);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.sc);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(799, 386);
            this.panel8.TabIndex = 1;
            // 
            // sc
            // 
            this.sc.AutoScroll = true;
            this.sc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            this.sc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.sc.Size = new System.Drawing.Size(799, 386);
            this.sc.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 386);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 45);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(711, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(86, 43);
            this.panel9.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Active = false;
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(76, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 587);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LogoImage = ((System.Drawing.Image)(resources.GetObject("$this.LogoImage")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio Platform";
            this.TitleText = "Studio Platform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.pnlWindow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private Bunifu.Framework.UI.BunifuFlatButton btnKill;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private BrowserSettingContainer sc;
    }
}

