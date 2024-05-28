
namespace System_rezerwacji
{
    partial class Wybierz_rodzaj
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
            this.button1 = new System.Windows.Forms.Button();
            this.wroc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rStolika = new System.Windows.Forms.CheckBox();
            this.rPrzyjecia = new System.Windows.Forms.CheckBox();
            this.rSali = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(205, 278);
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
            this.label3.Location = new System.Drawing.Point(203, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(307, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wybierz rodzaj rezerwacji";
            // 
            // rStolika
            // 
            this.rStolika.AutoSize = true;
            this.rStolika.Location = new System.Drawing.Point(205, 155);
            this.rStolika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rStolika.Name = "rStolika";
            this.rStolika.Size = new System.Drawing.Size(142, 20);
            this.rStolika.TabIndex = 24;
            this.rStolika.Text = "Rezerwacja stolika";
            this.rStolika.UseVisualStyleBackColor = true;
            this.rStolika.CheckedChanged += new System.EventHandler(this.rStolika_CheckedChanged);
            // 
            // rPrzyjecia
            // 
            this.rPrzyjecia.AutoSize = true;
            this.rPrzyjecia.Location = new System.Drawing.Point(205, 191);
            this.rPrzyjecia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rPrzyjecia.Name = "rPrzyjecia";
            this.rPrzyjecia.Size = new System.Drawing.Size(158, 20);
            this.rPrzyjecia.TabIndex = 25;
            this.rPrzyjecia.Text = "Organizacja przyjęcia";
            this.rPrzyjecia.UseVisualStyleBackColor = true;
            this.rPrzyjecia.CheckedChanged += new System.EventHandler(this.rPrzyjecia_CheckedChanged);
            // 
            // rSali
            // 
            this.rSali.AutoSize = true;
            this.rSali.Location = new System.Drawing.Point(205, 231);
            this.rSali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rSali.Name = "rSali";
            this.rSali.Size = new System.Drawing.Size(192, 20);
            this.rSali.TabIndex = 26;
            this.rSali.Text = "Wynajęcie sali bankietowej";
            this.rSali.UseVisualStyleBackColor = true;
            this.rSali.CheckedChanged += new System.EventHandler(this.rSali_CheckedChanged);
            // 
            // Wybierz_rodzaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rSali);
            this.Controls.Add(this.rPrzyjecia);
            this.Controls.Add(this.rStolika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Wybierz_rodzaj";
            this.Text = "Wybierz_rodzaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rStolika;
        private System.Windows.Forms.CheckBox rPrzyjecia;
        private System.Windows.Forms.CheckBox rSali;
    }
}