
namespace System_rezerwacji
{
    partial class Szukaj_rezerwacji
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
            this.szukaj_gl = new System.Windows.Forms.Button();
            this.wroc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNazwisko = new System.Windows.Forms.TextBox();
            this.zakoncz = new System.Windows.Forms.Button();
            this.szukaj_sala = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.Label();
            this.szukaj_obu = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szukaj_gl
            // 
            this.szukaj_gl.Location = new System.Drawing.Point(104, 336);
            this.szukaj_gl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.szukaj_gl.Name = "szukaj_gl";
            this.szukaj_gl.Size = new System.Drawing.Size(195, 41);
            this.szukaj_gl.TabIndex = 23;
            this.szukaj_gl.Text = "Szukaj z sali głównej";
            this.szukaj_gl.UseVisualStyleBackColor = true;
            this.szukaj_gl.Click += new System.EventHandler(this.szukaj_gl_Click);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(204, 381);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 22;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nazwisko rezerwującego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(124, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Jeśli chcesz wyszukać rezerwacje możesz podać samą datę lub z nazwiskiem";
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.Location = new System.Drawing.Point(387, 296);
            this.TextBoxNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.Size = new System.Drawing.Size(213, 22);
            this.TextBoxNazwisko.TabIndex = 29;
            // 
            // zakoncz
            // 
            this.zakoncz.Location = new System.Drawing.Point(405, 381);
            this.zakoncz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zakoncz.Name = "zakoncz";
            this.zakoncz.Size = new System.Drawing.Size(195, 41);
            this.zakoncz.TabIndex = 32;
            this.zakoncz.Text = "Zakończ";
            this.zakoncz.UseVisualStyleBackColor = true;
            this.zakoncz.Click += new System.EventHandler(this.zakoncz_Click);
            // 
            // szukaj_sala
            // 
            this.szukaj_sala.Location = new System.Drawing.Point(305, 336);
            this.szukaj_sala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.szukaj_sala.Name = "szukaj_sala";
            this.szukaj_sala.Size = new System.Drawing.Size(195, 41);
            this.szukaj_sala.TabIndex = 33;
            this.szukaj_sala.Text = "Szukaj z sali bankietowej";
            this.szukaj_sala.UseVisualStyleBackColor = true;
            this.szukaj_sala.Click += new System.EventHandler(this.szukaj_sala_Click);
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(40, 424);
            this.dane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(171, 17);
            this.dane.TabIndex = 34;
            this.dane.Text = "Kliknij aby wyświetlić dane";
            this.dane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dane_MouseClick);
            // 
            // szukaj_obu
            // 
            this.szukaj_obu.Location = new System.Drawing.Point(506, 336);
            this.szukaj_obu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.szukaj_obu.Name = "szukaj_obu";
            this.szukaj_obu.Size = new System.Drawing.Size(195, 41);
            this.szukaj_obu.TabIndex = 35;
            this.szukaj_obu.Text = "Szukaj ze wszystkiego";
            this.szukaj_obu.UseVisualStyleBackColor = true;
            this.szukaj_obu.Click += new System.EventHandler(this.szukaj_obu_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(259, 76);
            this.data.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.data.MaxSelectionCount = 14;
            this.data.Name = "data";
            this.data.TabIndex = 36;
            this.data.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.data_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Wybrana data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Wybierz datę:";
            // 
            // Szukaj_rezerwacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.szukaj_obu);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.szukaj_sala);
            this.Controls.Add(this.zakoncz);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szukaj_gl);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Szukaj_rezerwacji";
            this.Text = "Szukaj_rezerwacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szukaj_gl;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNazwisko;
        private System.Windows.Forms.Button zakoncz;
        private System.Windows.Forms.Button szukaj_sala;
        private System.Windows.Forms.Label dane;
        private System.Windows.Forms.Button szukaj_obu;
        private System.Windows.Forms.MonthCalendar data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}