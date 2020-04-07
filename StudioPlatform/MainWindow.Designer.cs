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
            this.pnlBrowsers = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWindow
            // 
            this.pnlWindow.Controls.Add(this.pnlBrowsers);
            this.pnlWindow.Size = new System.Drawing.Size(918, 547);
            this.pnlWindow.Controls.SetChildIndex(this.pnlBrowsers, 0);
            // 
            // pnlBrowsers
            // 
            this.pnlBrowsers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlBrowsers.ColumnCount = 3;
            this.pnlBrowsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlBrowsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlBrowsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlBrowsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowsers.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowsers.Name = "pnlBrowsers";
            this.pnlBrowsers.RowCount = 2;
            this.pnlBrowsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlBrowsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlBrowsers.Size = new System.Drawing.Size(915, 547);
            this.pnlBrowsers.TabIndex = 5;
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
            this.pnlWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlBrowsers;
    }
}

