namespace StudioPlatform
{
    partial class BrowserSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserSetting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddress = new UBTStandardLibrary.UBTTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFolder = new UBTStandardLibrary.UBTTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelectFolder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 30);
            this.panel1.TabIndex = 0;
            // 
            // lblIndex
            // 
            this.lblIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(0, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIndex.Size = new System.Drawing.Size(438, 30);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "0";
            this.lblIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 36);
            this.panel2.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Hint = "Address";
            this.txtAddress.Index = -1;
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(0, 0);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(436, 34);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "Address";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 40);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtFolder);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 38);
            this.panel5.TabIndex = 1;
            // 
            // txtFolder
            // 
            this.txtFolder.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFolder.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFolder.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFolder.BorderThickness = 2;
            this.txtFolder.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFolder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFolder.Hint = "Select Folder";
            this.txtFolder.Index = -1;
            this.txtFolder.isPassword = false;
            this.txtFolder.Location = new System.Drawing.Point(0, 0);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.MaxLength = 32767;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(350, 38);
            this.txtFolder.TabIndex = 0;
            this.txtFolder.Text = "Select Folder";
            this.txtFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSelectFolder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(86, 38);
            this.panel4.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Active = false;
            this.btnSelectFolder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectFolder.BorderRadius = 0;
            this.btnSelectFolder.ButtonText = "Select";
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectFolder.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelectFolder.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSelectFolder.Iconimage")));
            this.btnSelectFolder.Iconimage_right = null;
            this.btnSelectFolder.Iconimage_right_Selected = null;
            this.btnSelectFolder.Iconimage_Selected = null;
            this.btnSelectFolder.IconMarginLeft = 0;
            this.btnSelectFolder.IconMarginRight = 0;
            this.btnSelectFolder.IconRightVisible = false;
            this.btnSelectFolder.IconRightZoom = 0D;
            this.btnSelectFolder.IconVisible = false;
            this.btnSelectFolder.IconZoom = 90D;
            this.btnSelectFolder.IsTab = false;
            this.btnSelectFolder.Location = new System.Drawing.Point(5, 5);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectFolder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelectFolder.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelectFolder.selected = false;
            this.btnSelectFolder.Size = new System.Drawing.Size(76, 28);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select";
            this.btnSelectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectFolder.Textcolor = System.Drawing.Color.White;
            this.btnSelectFolder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // BrowserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BrowserSetting";
            this.Size = new System.Drawing.Size(438, 106);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelectFolder;
        private System.Windows.Forms.Panel panel5;
        private UBTStandardLibrary.UBTTextBox txtFolder;
        private UBTStandardLibrary.UBTTextBox txtAddress;
    }
}
