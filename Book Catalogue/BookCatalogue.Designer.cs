namespace Book_Catalogue
{
    partial class BookCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCatalogue));
            this.suchBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.biblio = new System.Windows.Forms.Button();
            this.Sammlung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suchBox1
            // 
            this.suchBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchBox1.Location = new System.Drawing.Point(3, 1);
            this.suchBox1.Multiline = true;
            this.suchBox1.Name = "suchBox1";
            this.suchBox1.Size = new System.Drawing.Size(902, 50);
            this.suchBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(911, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "suchen");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // biblio
            // 
            this.biblio.BackColor = System.Drawing.Color.OliveDrab;
            this.biblio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.biblio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biblio.Location = new System.Drawing.Point(386, 278);
            this.biblio.Name = "biblio";
            this.biblio.Size = new System.Drawing.Size(107, 50);
            this.biblio.TabIndex = 2;
            this.biblio.Text = "Bibliothek";
            this.biblio.UseVisualStyleBackColor = false;
            this.biblio.Click += new System.EventHandler(this.biblio_Click);
            // 
            // Sammlung
            // 
            this.Sammlung.BackColor = System.Drawing.Color.OliveDrab;
            this.Sammlung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sammlung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sammlung.Location = new System.Drawing.Point(511, 278);
            this.Sammlung.Name = "Sammlung";
            this.Sammlung.Size = new System.Drawing.Size(108, 50);
            this.Sammlung.TabIndex = 3;
            this.Sammlung.Text = "Sammlung";
            this.Sammlung.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 636);
            this.Controls.Add(this.Sammlung);
            this.Controls.Add(this.biblio);
            this.Controls.Add(this.suchBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Book Catalogue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox suchBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button biblio;
        private System.Windows.Forms.Button Sammlung;
    }
}

