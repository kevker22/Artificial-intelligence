namespace Eigene_KI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.wiki_Info = new System.Windows.Forms.TextBox();
            this.Dateibrowser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ordneransicht_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_time.Location = new System.Drawing.Point(9, 507);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(129, 16);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "-Timelololololololololol";
            this.lbl_time.UseWaitCursor = true;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_date.Location = new System.Drawing.Point(9, 523);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(129, 16);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "-Datelololololololololol";
            this.lbl_date.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(346, 107);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(391, 250);
            this.webBrowser1.TabIndex = 3;
            // 
            // wiki_Info
            // 
            this.wiki_Info.Location = new System.Drawing.Point(16, 107);
            this.wiki_Info.MaxLength = 50;
            this.wiki_Info.Multiline = true;
            this.wiki_Info.Name = "wiki_Info";
            this.wiki_Info.ReadOnly = true;
            this.wiki_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wiki_Info.Size = new System.Drawing.Size(324, 158);
            this.wiki_Info.TabIndex = 4;
            this.wiki_Info.UseWaitCursor = true;
            this.wiki_Info.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dateibrowser
            // 
            this.Dateibrowser.AutoSize = true;
            this.Dateibrowser.BackColor = System.Drawing.Color.Transparent;
            this.Dateibrowser.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateibrowser.ForeColor = System.Drawing.Color.Black;
            this.Dateibrowser.Location = new System.Drawing.Point(354, 80);
            this.Dateibrowser.Name = "Dateibrowser";
            this.Dateibrowser.Size = new System.Drawing.Size(112, 24);
            this.Dateibrowser.TabIndex = 5;
            this.Dateibrowser.Text = "Dateibrowser";
            this.Dateibrowser.UseWaitCursor = true;
            this.Dateibrowser.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wikipedia suche";
            this.label1.UseWaitCursor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LIS AI\r\n";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // ordneransicht_txt
            // 
            this.ordneransicht_txt.Location = new System.Drawing.Point(358, 363);
            this.ordneransicht_txt.MaxLength = 50;
            this.ordneransicht_txt.Multiline = true;
            this.ordneransicht_txt.Name = "ordneransicht_txt";
            this.ordneransicht_txt.ReadOnly = true;
            this.ordneransicht_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ordneransicht_txt.Size = new System.Drawing.Size(172, 63);
            this.ordneransicht_txt.TabIndex = 7;
            this.ordneransicht_txt.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(355, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ordner Infos";
            this.label2.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(745, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordneransicht_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dateibrowser);
            this.Controls.Add(this.wiki_Info);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_time);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIS Artifical Intelligents";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox wiki_Info;
        private System.Windows.Forms.Label Dateibrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox ordneransicht_txt;
        private System.Windows.Forms.Label label2;
    }
}
