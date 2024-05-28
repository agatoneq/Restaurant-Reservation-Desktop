namespace System_rezerwacji
{
    partial class Koniec
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
            this.wroc = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dane Twojej rezerwacji:";
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(789, 33);
            this.zatwierdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(195, 41);
            this.zatwierdz.TabIndex = 26;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // wroc
            // 
            this.wroc.Location = new System.Drawing.Point(589, 33);
            this.wroc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(195, 41);
            this.wroc.TabIndex = 30;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(53, 91);
            this.dane.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(171, 17);
            this.dane.TabIndex = 31;
            this.dane.Text = "Kliknij aby wyświetlić dane";
            this.dane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dane_MouseClick);
            // 
            // Koniec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Koniec";
            this.Text = "Koniec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label dane;
    }
}