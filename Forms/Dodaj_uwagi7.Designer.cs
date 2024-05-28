namespace System_rezerwacji
{
    partial class Dodaj_uwagi
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
            this.label1 = new System.Windows.Forms.Label();
            this.uwagi = new System.Windows.Forms.TextBox();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.wroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj inne uwagi na temat swojej rezerwacji:";
            // 
            // uwagi
            // 
            this.uwagi.Location = new System.Drawing.Point(55, 229);
            this.uwagi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uwagi.Name = "uwagi";
            this.uwagi.Size = new System.Drawing.Size(956, 22);
            this.uwagi.TabIndex = 2;
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(255, 271);
            this.zatwierdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(195, 41);
            this.zatwierdz.TabIndex = 24;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(55, 271);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 25;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // Dodaj_uwagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.uwagi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dodaj_uwagi";
            this.Text = "Dodaj_uwagi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uwagi;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Button wroc;
    }
}