namespace gestione_archivio1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dipendentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaArchivioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualzzaElencoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoDipendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercaDipendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaDipendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaDipendeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riepilogo = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dipendentiToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dipendentiToolStripMenuItem
            // 
            this.dipendentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaArchivioToolStripMenuItem,
            this.visualzzaElencoToolStripMenuItem,
            this.nuovoDipendenteToolStripMenuItem,
            this.cercaDipendenteToolStripMenuItem,
            this.modificaDipendenteToolStripMenuItem,
            this.cancellaDipendeteToolStripMenuItem});
            this.dipendentiToolStripMenuItem.Name = "dipendentiToolStripMenuItem";
            this.dipendentiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dipendentiToolStripMenuItem.Text = "Dipendenti";
            // 
            // creaArchivioToolStripMenuItem
            // 
            this.creaArchivioToolStripMenuItem.Name = "creaArchivioToolStripMenuItem";
            this.creaArchivioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.creaArchivioToolStripMenuItem.Text = "Crea Archivio";
            this.creaArchivioToolStripMenuItem.Click += new System.EventHandler(this.creaArchivioToolStripMenuItem_Click);
            // 
            // visualzzaElencoToolStripMenuItem
            // 
            this.visualzzaElencoToolStripMenuItem.Name = "visualzzaElencoToolStripMenuItem";
            this.visualzzaElencoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.visualzzaElencoToolStripMenuItem.Text = "VisualzzaElenco";
            this.visualzzaElencoToolStripMenuItem.Click += new System.EventHandler(this.visualzzaElencoToolStripMenuItem_Click);
            // 
            // nuovoDipendenteToolStripMenuItem
            // 
            this.nuovoDipendenteToolStripMenuItem.Name = "nuovoDipendenteToolStripMenuItem";
            this.nuovoDipendenteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nuovoDipendenteToolStripMenuItem.Text = "Nuovo Dipendente";
            this.nuovoDipendenteToolStripMenuItem.Click += new System.EventHandler(this.nuovoDipendenteToolStripMenuItem_Click);
            // 
            // cercaDipendenteToolStripMenuItem
            // 
            this.cercaDipendenteToolStripMenuItem.Name = "cercaDipendenteToolStripMenuItem";
            this.cercaDipendenteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cercaDipendenteToolStripMenuItem.Text = "Cerca Dipendente";
            this.cercaDipendenteToolStripMenuItem.Click += new System.EventHandler(this.cercaDipendenteToolStripMenuItem_Click);
            // 
            // modificaDipendenteToolStripMenuItem
            // 
            this.modificaDipendenteToolStripMenuItem.Name = "modificaDipendenteToolStripMenuItem";
            this.modificaDipendenteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.modificaDipendenteToolStripMenuItem.Text = "Modifica Dipendente";
            this.modificaDipendenteToolStripMenuItem.Click += new System.EventHandler(this.modificaDipendenteToolStripMenuItem_Click);
            // 
            // cancellaDipendeteToolStripMenuItem
            // 
            this.cancellaDipendeteToolStripMenuItem.Name = "cancellaDipendeteToolStripMenuItem";
            this.cancellaDipendeteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cancellaDipendeteToolStripMenuItem.Text = "Cancella Dipendete";
            this.cancellaDipendeteToolStripMenuItem.Click += new System.EventHandler(this.cancellaDipendeteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // riepilogo
            // 
            this.riepilogo.HideSelection = false;
            this.riepilogo.Location = new System.Drawing.Point(0, 31);
            this.riepilogo.Name = "riepilogo";
            this.riepilogo.Size = new System.Drawing.Size(800, 400);
            this.riepilogo.TabIndex = 1;
            this.riepilogo.UseCompatibleStateImageBehavior = false;
            this.riepilogo.SelectedIndexChanged += new System.EventHandler(this.riepilogo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.riepilogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dipendentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaArchivioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualzzaElencoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoDipendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercaDipendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaDipendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaDipendeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView riepilogo;
    }
}

