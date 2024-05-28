
namespace System_rezerwacji
{
    partial class Wybierz_termin
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
            this.zatwierdz = new System.Windows.Forms.Button();
            this.godzina = new System.Windows.Forms.NumericUpDown();
            this.minuty = new System.Windows.Forms.DomainUpDown();
            this.wroc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.godzina)).BeginInit();
            this.SuspendLayout();
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(400, 353);
            this.zatwierdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(195, 41);
            this.zatwierdz.TabIndex = 25;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // godzina
            // 
            this.godzina.Location = new System.Drawing.Point(360, 305);
            this.godzina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.godzina.Name = "godzina";
            this.godzina.Size = new System.Drawing.Size(67, 22);
            this.godzina.TabIndex = 27;
            this.godzina.ValueChanged += new System.EventHandler(this.godzina_ValueChanged);
            // 
            // minuty
            // 
            this.minuty.Items.Add("45");
            this.minuty.Items.Add("30");
            this.minuty.Items.Add("15");
            this.minuty.Items.Add("00");
            this.minuty.Location = new System.Drawing.Point(435, 305);
            this.minuty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minuty.Name = "minuty";
            this.minuty.Size = new System.Drawing.Size(67, 22);
            this.minuty.TabIndex = 28;
            this.minuty.Text = "00";
            this.minuty.SelectedItemChanged += new System.EventHandler(this.minuty_SelectedItemChanged);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(200, 353);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 29;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Wybierz datę:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Wybierz godzinę:";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(236, 70);
            this.data.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.data.MaxSelectionCount = 14;
            this.data.Name = "data";
            this.data.TabIndex = 32;
            this.data.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.data_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Wybrana data";
            // 
            // Wybierz_termin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.minuty);
            this.Controls.Add(this.godzina);
            this.Controls.Add(this.zatwierdz);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Wybierz_termin";
            this.Text = "Wybierz_termin";
            ((System.ComponentModel.ISupportInitialize)(this.godzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.NumericUpDown godzina;
        private System.Windows.Forms.DomainUpDown minuty;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar data;
        private System.Windows.Forms.Label label3;
    }
}