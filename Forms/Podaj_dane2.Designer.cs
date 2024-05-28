
namespace System_rezerwacji
{
    partial class Podaj_dane
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.nr_tel = new System.Windows.Forms.TextBox();
            this.wroc = new System.Windows.Forms.Button();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj swoje dane:";
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(303, 110);
            this.imie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(282, 22);
            this.imie.TabIndex = 3;
            this.imie.TextChanged += new System.EventHandler(this.imie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imię: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko:";
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(303, 138);
            this.nazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(282, 22);
            this.nazwisko.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres e-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numer telefonu:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(303, 166);
            this.mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(282, 22);
            this.mail.TabIndex = 10;
            // 
            // nr_tel
            // 
            this.nr_tel.Location = new System.Drawing.Point(303, 194);
            this.nr_tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nr_tel.Name = "nr_tel";
            this.nr_tel.Size = new System.Drawing.Size(282, 22);
            this.nr_tel.TabIndex = 11;
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(191, 233);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 14;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(392, 233);
            this.zatwierdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(195, 41);
            this.zatwierdz.TabIndex = 15;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // Podaj_dane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.nr_tel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Podaj_dane";
            this.Text = "Podaj_dane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox nr_tel;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Button zatwierdz;
    }
}

