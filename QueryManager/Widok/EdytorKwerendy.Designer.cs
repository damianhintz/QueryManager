namespace QueryManager.Widok
{
    partial class EdytorKwerendy
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
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.nazwaLabel = new System.Windows.Forms.Label();
            this.sqlLabel = new System.Windows.Forms.Label();
            this.opisLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.anulujButton = new System.Windows.Forms.Button();
            this.numerTextBox = new System.Windows.Forms.TextBox();
            this.numerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nazwaTextBox.Location = new System.Drawing.Point(88, 12);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(229, 20);
            this.nazwaTextBox.TabIndex = 0;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opisTextBox.Location = new System.Drawing.Point(88, 38);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(389, 20);
            this.opisTextBox.TabIndex = 1;
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTextBox.Location = new System.Drawing.Point(88, 64);
            this.sqlTextBox.Multiline = true;
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(389, 115);
            this.sqlTextBox.TabIndex = 2;
            // 
            // nazwaLabel
            // 
            this.nazwaLabel.AutoSize = true;
            this.nazwaLabel.Location = new System.Drawing.Point(12, 12);
            this.nazwaLabel.Name = "nazwaLabel";
            this.nazwaLabel.Size = new System.Drawing.Size(43, 13);
            this.nazwaLabel.TabIndex = 3;
            this.nazwaLabel.Text = "Nazwa:";
            // 
            // sqlLabel
            // 
            this.sqlLabel.AutoSize = true;
            this.sqlLabel.Location = new System.Drawing.Point(12, 64);
            this.sqlLabel.Name = "sqlLabel";
            this.sqlLabel.Size = new System.Drawing.Size(58, 13);
            this.sqlLabel.TabIndex = 4;
            this.sqlLabel.Text = "Kwerenda:";
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(12, 38);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(31, 13);
            this.opisLabel.TabIndex = 5;
            this.opisLabel.Text = "Opis:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(321, 185);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // anulujButton
            // 
            this.anulujButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.anulujButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.anulujButton.Location = new System.Drawing.Point(402, 185);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(75, 23);
            this.anulujButton.TabIndex = 7;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            // 
            // numerTextBox
            // 
            this.numerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numerTextBox.Location = new System.Drawing.Point(402, 12);
            this.numerTextBox.Name = "numerTextBox";
            this.numerTextBox.Size = new System.Drawing.Size(75, 20);
            this.numerTextBox.TabIndex = 8;
            // 
            // numerLabel
            // 
            this.numerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numerLabel.AutoSize = true;
            this.numerLabel.Location = new System.Drawing.Point(355, 19);
            this.numerLabel.Name = "numerLabel";
            this.numerLabel.Size = new System.Drawing.Size(41, 13);
            this.numerLabel.TabIndex = 9;
            this.numerLabel.Text = "Numer:";
            // 
            // EdytorKwerendy
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anulujButton;
            this.ClientSize = new System.Drawing.Size(493, 216);
            this.Controls.Add(this.numerLabel);
            this.Controls.Add(this.numerTextBox);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.sqlLabel);
            this.Controls.Add(this.nazwaLabel);
            this.Controls.Add(this.sqlTextBox);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.nazwaTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdytorKwerendy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytor kwerendy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox sqlTextBox;
        private System.Windows.Forms.Label nazwaLabel;
        private System.Windows.Forms.Label sqlLabel;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button anulujButton;
        private System.Windows.Forms.TextBox numerTextBox;
        private System.Windows.Forms.Label numerLabel;
    }
}