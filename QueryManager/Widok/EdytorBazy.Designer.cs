namespace QueryManager.Widok
{
    partial class EdytorBazy
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
            this.bazyView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.przeglądajButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.anulujButton = new System.Windows.Forms.Button();
            this.wykonajButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.wykluczButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bazyView
            // 
            this.bazyView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bazyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.bazyView.FullRowSelect = true;
            this.bazyView.Location = new System.Drawing.Point(12, 38);
            this.bazyView.Name = "bazyView";
            this.bazyView.Size = new System.Drawing.Size(709, 212);
            this.bazyView.TabIndex = 0;
            this.bazyView.UseCompatibleStateImageBehavior = false;
            this.bazyView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Baza danych";
            this.columnHeader1.Width = 310;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa kwerendy";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rezultat";
            this.columnHeader3.Width = 150;
            // 
            // przeglądajButton
            // 
            this.przeglądajButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.przeglądajButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.przeglądajButton.Location = new System.Drawing.Point(626, 9);
            this.przeglądajButton.Name = "przeglądajButton";
            this.przeglądajButton.Size = new System.Drawing.Size(95, 23);
            this.przeglądajButton.TabIndex = 1;
            this.przeglądajButton.Text = "Przeglądaj...";
            this.przeglądajButton.UseVisualStyleBackColor = true;
            this.przeglądajButton.Click += new System.EventHandler(this.przeglądajButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(12, 19);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(264, 13);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Wybierz bazy danych, dla których wykonać kwerendy.";
            // 
            // anulujButton
            // 
            this.anulujButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.anulujButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujButton.Location = new System.Drawing.Point(646, 256);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(75, 23);
            this.anulujButton.TabIndex = 3;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            // 
            // wykonajButton
            // 
            this.wykonajButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wykonajButton.Location = new System.Drawing.Point(565, 256);
            this.wykonajButton.Name = "wykonajButton";
            this.wykonajButton.Size = new System.Drawing.Size(75, 23);
            this.wykonajButton.TabIndex = 4;
            this.wykonajButton.Text = "Wykonaj";
            this.wykonajButton.UseVisualStyleBackColor = true;
            this.wykonajButton.Click += new System.EventHandler(this.wykonajButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.mdb|*.mdb";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Wybierz plik bazy danych";
            // 
            // wykluczButton
            // 
            this.wykluczButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wykluczButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wykluczButton.Location = new System.Drawing.Point(12, 256);
            this.wykluczButton.Name = "wykluczButton";
            this.wykluczButton.Size = new System.Drawing.Size(119, 23);
            this.wykluczButton.TabIndex = 5;
            this.wykluczButton.Text = "Wyklucz wszystkie";
            this.wykluczButton.UseVisualStyleBackColor = true;
            this.wykluczButton.Click += new System.EventHandler(this.wykluczButton_Click);
            // 
            // EdytorBazy
            // 
            this.AcceptButton = this.wykonajButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anulujButton;
            this.ClientSize = new System.Drawing.Size(733, 284);
            this.Controls.Add(this.wykluczButton);
            this.Controls.Add(this.wykonajButton);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.przeglądajButton);
            this.Controls.Add(this.bazyView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdytorBazy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procesor kwerend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bazyView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button przeglądajButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button anulujButton;
        private System.Windows.Forms.Button wykonajButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button wykluczButton;
    }
}