﻿namespace Spider
{
    partial class frmMain
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
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speicherStrgSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueKartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tippToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.spielToolStripMenuItem1});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(1351, 24);
            this.mStrip.TabIndex = 3;
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.speicherStrgSToolStripMenuItem,
            this.spielLadenToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.spielToolStripMenuItem.Text = "Spider";
            // 
            // spielToolStripMenuItem1
            // 
            this.spielToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueKartenToolStripMenuItem,
            this.tippToolStripMenuItem});
            this.spielToolStripMenuItem1.Name = "spielToolStripMenuItem1";
            this.spielToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem1.Text = "Spiel";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Image = global::Spider.Properties.Resources.Add;
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // speicherStrgSToolStripMenuItem
            // 
            this.speicherStrgSToolStripMenuItem.Image = global::Spider.Properties.Resources.Save;
            this.speicherStrgSToolStripMenuItem.Name = "speicherStrgSToolStripMenuItem";
            this.speicherStrgSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speicherStrgSToolStripMenuItem.Text = "Speichern   (Strg+S)";
            this.speicherStrgSToolStripMenuItem.Click += new System.EventHandler(this.speicherStrgSToolStripMenuItem_Click);
            // 
            // spielLadenToolStripMenuItem
            // 
            this.spielLadenToolStripMenuItem.Image = global::Spider.Properties.Resources.Open;
            this.spielLadenToolStripMenuItem.Name = "spielLadenToolStripMenuItem";
            this.spielLadenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spielLadenToolStripMenuItem.Text = "Spiel laden (Strg+O)";
            this.spielLadenToolStripMenuItem.Click += new System.EventHandler(this.spielLadenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Image = global::Spider.Properties.Resources.Settings;
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Image = global::Spider.Properties.Resources.CloseIcon;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // neueKartenToolStripMenuItem
            // 
            this.neueKartenToolStripMenuItem.Image = global::Spider.Properties.Resources.Copy;
            this.neueKartenToolStripMenuItem.Name = "neueKartenToolStripMenuItem";
            this.neueKartenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.neueKartenToolStripMenuItem.Text = "Neue Karten (F2)";
            this.neueKartenToolStripMenuItem.Click += new System.EventHandler(this.neueKartenToolStripMenuItem_Click);
            // 
            // tippToolStripMenuItem
            // 
            this.tippToolStripMenuItem.Image = global::Spider.Properties.Resources.About;
            this.tippToolStripMenuItem.Name = "tippToolStripMenuItem";
            this.tippToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tippToolStripMenuItem.Text = "Tipp (F3) (Beta)";
            this.tippToolStripMenuItem.Click += new System.EventHandler(this.tippToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 427);
            this.Controls.Add(this.mStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mStrip;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Spider";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neueKartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tippToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speicherStrgSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

