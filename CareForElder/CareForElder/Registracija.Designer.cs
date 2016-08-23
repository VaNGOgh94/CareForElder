namespace CareForElder
{
    partial class Registracija
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.tbxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDatumRođenja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipKorisnika = new System.Windows.Forms.ComboBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(60, 51);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // tbxKorisnickoIme
            // 
            this.tbxKorisnickoIme.Location = new System.Drawing.Point(63, 67);
            this.tbxKorisnickoIme.Name = "tbxKorisnickoIme";
            this.tbxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.tbxKorisnickoIme.TabIndex = 1;
            this.tbxKorisnickoIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(63, 127);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime";
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(63, 180);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbxPrezime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum rođenja";
            // 
            // tbxDatumRođenja
            // 
            this.tbxDatumRođenja.Location = new System.Drawing.Point(66, 237);
            this.tbxDatumRođenja.Name = "tbxDatumRođenja";
            this.tbxDatumRođenja.Size = new System.Drawing.Size(100, 20);
            this.tbxDatumRođenja.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tip korisnika";
            // 
            // cbxTipKorisnika
            // 
            this.cbxTipKorisnika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipKorisnika.FormattingEnabled = true;
            this.cbxTipKorisnika.Location = new System.Drawing.Point(63, 294);
            this.cbxTipKorisnika.Name = "cbxTipKorisnika";
            this.cbxTipKorisnika.Size = new System.Drawing.Size(121, 21);
            this.cbxTipKorisnika.TabIndex = 10;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.BackColor = System.Drawing.Color.Red;
            this.btnRegistriraj.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnRegistriraj.Location = new System.Drawing.Point(267, 144);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(95, 113);
            this.btnRegistriraj.TabIndex = 11;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = false;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 369);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.cbxTipKorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDatumRođenja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registracija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox tbxKorisnickoIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDatumRođenja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipKorisnika;
        private System.Windows.Forms.Button btnRegistriraj;
    }
}