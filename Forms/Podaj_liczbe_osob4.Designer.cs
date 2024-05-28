
namespace System_rezerwacji
{
    partial class Podaj_liczbe_osob
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
            this.zatwierdz = new System.Windows.Forms.Button();
            this.liczba_osob = new System.Windows.Forms.NumericUpDown();
            this.wroc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liczba_osob)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę osób:";
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(398, 197);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(194, 41);
            this.zatwierdz.TabIndex = 24;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // liczba_osob
            // 
            this.liczba_osob.Location = new System.Drawing.Point(335, 156);
            this.liczba_osob.Name = "liczba_osob";
            this.liczba_osob.Size = new System.Drawing.Size(120, 22);
            this.liczba_osob.TabIndex = 25;
            this.liczba_osob.ValueChanged += new System.EventHandler(this.liczba_osob_ValueChanged);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(197, 197);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 26;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // Podaj_liczbe_osob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.liczba_osob);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.label1);
            this.Name = "Podaj_liczbe_osob";
            this.Text = "Podaj_liczbe_osob";
            ((System.ComponentModel.ISupportInitialize)(this.liczba_osob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.NumericUpDown liczba_osob;
        private System.Windows.Forms.Button wroc;
    }
}