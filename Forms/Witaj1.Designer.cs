
namespace System_rezerwacji
{
    partial class Witaj
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
            this.klient_log = new System.Windows.Forms.Button();
            this.pracownik_log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(166, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witamy w systemie rezerwacji! ";
            // 
            // klient_log
            // 
            this.klient_log.Location = new System.Drawing.Point(239, 151);
            this.klient_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.klient_log.Name = "klient_log";
            this.klient_log.Size = new System.Drawing.Size(110, 34);
            this.klient_log.TabIndex = 1;
            this.klient_log.Text = "Klient";
            this.klient_log.UseVisualStyleBackColor = true;
            this.klient_log.Click += new System.EventHandler(this.klient_log_Click);
            // 
            // pracownik_log
            // 
            this.pracownik_log.Location = new System.Drawing.Point(239, 208);
            this.pracownik_log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pracownik_log.Name = "pracownik_log";
            this.pracownik_log.Size = new System.Drawing.Size(110, 34);
            this.pracownik_log.TabIndex = 3;
            this.pracownik_log.Text = "Pracownik";
            this.pracownik_log.UseVisualStyleBackColor = true;
            this.pracownik_log.Click += new System.EventHandler(this.pracownik_log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(185, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logujesz się jako klient czy pracownik?";
            // 
            // Witaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pracownik_log);
            this.Controls.Add(this.klient_log);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Witaj";
            this.Text = "Witaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button klient_log;
        private System.Windows.Forms.Button pracownik_log;
        private System.Windows.Forms.Label label2;
    }
}