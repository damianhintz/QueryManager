namespace QueryManager
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyPlikMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.otwórzPlikMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportujXmlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportujTekstowyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dodajMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaKwerendaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujKwerendyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zapiszMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwerendaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKwerendaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.zmieńMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.usuńMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.wykonajMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.generatorKwerendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwerendyView = new System.Windows.Forms.ListView();
            this.lpHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opisHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sqlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kwerendyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajKontekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.zmienKontekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.usunKontekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.wykonajKontekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.generatorKwerendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.kwerendyMenu.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Menu;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikMenuItem,
            this.widokMenuItem,
            this.kwerendaMenuItem,
            this.pomocMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(1355, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // plikMenuItem
            // 
            this.plikMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyPlikMenuItem,
            this.toolStripSeparator5,
            this.otwórzPlikMenuItem,
            this.zapiszJakoMenuItem,
            this.toolStripSeparator4,
            this.dodajMenuItem,
            this.toolStripSeparator3,
            this.zamknijMenuItem,
            this.toolStripSeparator2,
            this.zapiszMenuItem,
            this.toolStripSeparator1,
            this.zakończMenuItem});
            this.plikMenuItem.Name = "plikMenuItem";
            this.plikMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikMenuItem.Text = "Plik";
            // 
            // nowyPlikMenuItem
            // 
            this.nowyPlikMenuItem.Name = "nowyPlikMenuItem";
            this.nowyPlikMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyPlikMenuItem.Size = new System.Drawing.Size(212, 26);
            this.nowyPlikMenuItem.Text = "Nowy plik...";
            this.nowyPlikMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // otwórzPlikMenuItem
            // 
            this.otwórzPlikMenuItem.Name = "otwórzPlikMenuItem";
            this.otwórzPlikMenuItem.Size = new System.Drawing.Size(212, 26);
            this.otwórzPlikMenuItem.Text = "Importuj...";
            this.otwórzPlikMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // zapiszJakoMenuItem
            // 
            this.zapiszJakoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eksportujXmlMenuItem,
            this.eksportujTekstowyMenuItem});
            this.zapiszJakoMenuItem.Name = "zapiszJakoMenuItem";
            this.zapiszJakoMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zapiszJakoMenuItem.Text = "Eksportuj";
            // 
            // eksportujXmlMenuItem
            // 
            this.eksportujXmlMenuItem.Name = "eksportujXmlMenuItem";
            this.eksportujXmlMenuItem.Size = new System.Drawing.Size(169, 26);
            this.eksportujXmlMenuItem.Text = "Plik XML";
            this.eksportujXmlMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // eksportujTekstowyMenuItem
            // 
            this.eksportujTekstowyMenuItem.Name = "eksportujTekstowyMenuItem";
            this.eksportujTekstowyMenuItem.Size = new System.Drawing.Size(169, 26);
            this.eksportujTekstowyMenuItem.Text = "Plik tekstowy";
            this.eksportujTekstowyMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // dodajMenuItem
            // 
            this.dodajMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaKwerendaMenuItem,
            this.importujKwerendyMenuItem});
            this.dodajMenuItem.Name = "dodajMenuItem";
            this.dodajMenuItem.Size = new System.Drawing.Size(212, 26);
            this.dodajMenuItem.Text = "Dodaj";
            // 
            // nowaKwerendaMenuItem
            // 
            this.nowaKwerendaMenuItem.Name = "nowaKwerendaMenuItem";
            this.nowaKwerendaMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nowaKwerendaMenuItem.Text = "Nowa kwerenda...";
            this.nowaKwerendaMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // importujKwerendyMenuItem
            // 
            this.importujKwerendyMenuItem.Name = "importujKwerendyMenuItem";
            this.importujKwerendyMenuItem.Size = new System.Drawing.Size(217, 26);
            this.importujKwerendyMenuItem.Text = "Importuj kwerendy...";
            this.importujKwerendyMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // zamknijMenuItem
            // 
            this.zamknijMenuItem.Name = "zamknijMenuItem";
            this.zamknijMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zamknijMenuItem.Text = "Zamknij";
            this.zamknijMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // zapiszMenuItem
            // 
            this.zapiszMenuItem.Name = "zapiszMenuItem";
            this.zapiszMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zapiszMenuItem.Text = "Zapisz";
            this.zapiszMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // zakończMenuItem
            // 
            this.zakończMenuItem.Name = "zakończMenuItem";
            this.zakończMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończMenuItem.Size = new System.Drawing.Size(212, 26);
            this.zakończMenuItem.Text = "Zakończ";
            this.zakończMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // widokMenuItem
            // 
            this.widokMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaznaczWszystkoMenuItem});
            this.widokMenuItem.Name = "widokMenuItem";
            this.widokMenuItem.Size = new System.Drawing.Size(64, 24);
            this.widokMenuItem.Text = "Widok";
            // 
            // zaznaczWszystkoMenuItem
            // 
            this.zaznaczWszystkoMenuItem.Name = "zaznaczWszystkoMenuItem";
            this.zaznaczWszystkoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoMenuItem.Size = new System.Drawing.Size(252, 26);
            this.zaznaczWszystkoMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoMenuItem_Click);
            // 
            // kwerendaMenuItem
            // 
            this.kwerendaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKwerendaMenuItem,
            this.toolStripSeparator8,
            this.zmieńMenuItem,
            this.toolStripSeparator7,
            this.usuńMenuItem,
            this.toolStripSeparator6,
            this.wykonajMenuItem,
            this.toolStripSeparator12,
            this.generatorKwerendMenuItem});
            this.kwerendaMenuItem.Name = "kwerendaMenuItem";
            this.kwerendaMenuItem.Size = new System.Drawing.Size(87, 24);
            this.kwerendaMenuItem.Text = "Kwerenda";
            // 
            // dodajKwerendaMenuItem
            // 
            this.dodajKwerendaMenuItem.Name = "dodajKwerendaMenuItem";
            this.dodajKwerendaMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.dodajKwerendaMenuItem.Size = new System.Drawing.Size(226, 26);
            this.dodajKwerendaMenuItem.Text = "Dodaj...";
            this.dodajKwerendaMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(223, 6);
            // 
            // zmieńMenuItem
            // 
            this.zmieńMenuItem.Name = "zmieńMenuItem";
            this.zmieńMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.zmieńMenuItem.Size = new System.Drawing.Size(226, 26);
            this.zmieńMenuItem.Text = "Zmień...";
            this.zmieńMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(223, 6);
            // 
            // usuńMenuItem
            // 
            this.usuńMenuItem.Name = "usuńMenuItem";
            this.usuńMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńMenuItem.Size = new System.Drawing.Size(226, 26);
            this.usuńMenuItem.Text = "Usuń";
            this.usuńMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(223, 6);
            // 
            // wykonajMenuItem
            // 
            this.wykonajMenuItem.Name = "wykonajMenuItem";
            this.wykonajMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.wykonajMenuItem.Size = new System.Drawing.Size(226, 26);
            this.wykonajMenuItem.Text = "Wykonaj...";
            this.wykonajMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(223, 6);
            // 
            // generatorKwerendMenuItem
            // 
            this.generatorKwerendMenuItem.Name = "generatorKwerendMenuItem";
            this.generatorKwerendMenuItem.Size = new System.Drawing.Size(226, 26);
            this.generatorKwerendMenuItem.Text = "Generator kwerend...";
            this.generatorKwerendMenuItem.Click += new System.EventHandler(this.generatorKwerendMenuItem_Click);
            // 
            // pomocMenuItem
            // 
            this.pomocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeOMenuItem});
            this.pomocMenuItem.Name = "pomocMenuItem";
            this.pomocMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomocMenuItem.Text = "Pomoc";
            // 
            // informacjeOMenuItem
            // 
            this.informacjeOMenuItem.Name = "informacjeOMenuItem";
            this.informacjeOMenuItem.Size = new System.Drawing.Size(270, 26);
            this.informacjeOMenuItem.Text = "Informacje o QueryManager";
            this.informacjeOMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // kwerendyView
            // 
            this.kwerendyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lpHeader,
            this.nazwaHeader,
            this.opisHeader,
            this.sqlHeader});
            this.kwerendyView.ContextMenuStrip = this.kwerendyMenu;
            this.kwerendyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kwerendyView.FullRowSelect = true;
            this.kwerendyView.HideSelection = false;
            this.kwerendyView.Location = new System.Drawing.Point(0, 0);
            this.kwerendyView.Margin = new System.Windows.Forms.Padding(4);
            this.kwerendyView.Name = "kwerendyView";
            this.kwerendyView.Size = new System.Drawing.Size(1355, 487);
            this.kwerendyView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.kwerendyView.TabIndex = 1;
            this.kwerendyView.UseCompatibleStateImageBehavior = false;
            this.kwerendyView.View = System.Windows.Forms.View.Details;
            this.kwerendyView.VirtualMode = true;
            this.kwerendyView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.kwerendyListView_MouseDoubleClick);
            // 
            // lpHeader
            // 
            this.lpHeader.Text = "Lp.";
            this.lpHeader.Width = 50;
            // 
            // nazwaHeader
            // 
            this.nazwaHeader.Text = "Nazwa";
            this.nazwaHeader.Width = 200;
            // 
            // opisHeader
            // 
            this.opisHeader.Text = "Opis";
            this.opisHeader.Width = 300;
            // 
            // sqlHeader
            // 
            this.sqlHeader.Text = "Kwerenda SQL";
            this.sqlHeader.Width = 800;
            // 
            // kwerendyMenu
            // 
            this.kwerendyMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.kwerendyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kwerendyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKontekstToolStripMenuItem,
            this.toolStripSeparator10,
            this.zmienKontekstToolStripMenuItem,
            this.toolStripSeparator11,
            this.usunKontekstToolStripMenuItem,
            this.toolStripSeparator9,
            this.wykonajKontekstToolStripMenuItem,
            this.toolStripSeparator13,
            this.generatorKwerendToolStripMenuItem});
            this.kwerendyMenu.Name = "kwerendyContextMenuStrip";
            this.kwerendyMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.kwerendyMenu.Size = new System.Drawing.Size(227, 158);
            // 
            // dodajKontekstToolStripMenuItem
            // 
            this.dodajKontekstToolStripMenuItem.Name = "dodajKontekstToolStripMenuItem";
            this.dodajKontekstToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.dodajKontekstToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.dodajKontekstToolStripMenuItem.Text = "Dodaj...";
            this.dodajKontekstToolStripMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(223, 6);
            // 
            // zmienKontekstToolStripMenuItem
            // 
            this.zmienKontekstToolStripMenuItem.Name = "zmienKontekstToolStripMenuItem";
            this.zmienKontekstToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.zmienKontekstToolStripMenuItem.Text = "Zmień...";
            this.zmienKontekstToolStripMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(223, 6);
            // 
            // usunKontekstToolStripMenuItem
            // 
            this.usunKontekstToolStripMenuItem.Name = "usunKontekstToolStripMenuItem";
            this.usunKontekstToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.usunKontekstToolStripMenuItem.Text = "Usuń";
            this.usunKontekstToolStripMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(223, 6);
            // 
            // wykonajKontekstToolStripMenuItem
            // 
            this.wykonajKontekstToolStripMenuItem.Name = "wykonajKontekstToolStripMenuItem";
            this.wykonajKontekstToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.wykonajKontekstToolStripMenuItem.Text = "Wykonaj...";
            this.wykonajKontekstToolStripMenuItem.Click += new System.EventHandler(this.PolecenieMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(223, 6);
            // 
            // generatorKwerendToolStripMenuItem
            // 
            this.generatorKwerendToolStripMenuItem.Name = "generatorKwerendToolStripMenuItem";
            this.generatorKwerendToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.generatorKwerendToolStripMenuItem.Text = "Generator kwerend...";
            this.generatorKwerendToolStripMenuItem.Click += new System.EventHandler(this.generatorKwerendMenuItem_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.Menu;
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Location = new System.Drawing.Point(0, 515);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status.Size = new System.Drawing.Size(1355, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip1";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kwerendyView);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 28);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1355, 487);
            this.panel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 537);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "QueryManager v1.3-beta - Zarządca kwerend  (18 listopada 2016)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.kwerendyMenu.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem plikMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocMenuItem;
        private System.Windows.Forms.ListView kwerendyView;
        private System.Windows.Forms.ColumnHeader lpHeader;
        private System.Windows.Forms.ColumnHeader nazwaHeader;
        private System.Windows.Forms.ColumnHeader opisHeader;
        private System.Windows.Forms.ColumnHeader sqlHeader;
        private System.Windows.Forms.ToolStripMenuItem nowyPlikMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem dodajMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaKwerendaMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem zamknijMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem zapiszMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwerendaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKwerendaMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem zmieńMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem usuńMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem wykonajMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOMenuItem;
        private System.Windows.Forms.ContextMenuStrip kwerendyMenu;
        private System.Windows.Forms.ToolStripMenuItem dodajKontekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem zmienKontekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem usunKontekstToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem wykonajKontekstToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem widokMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importujKwerendyMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem eksportujXmlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksportujTekstowyMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem generatorKwerendMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem generatorKwerendToolStripMenuItem;
    }
}

