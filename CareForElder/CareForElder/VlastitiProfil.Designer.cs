namespace CareForElder
{
    partial class VlastitiProfil
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
            this.dgvNjegovatelji = new System.Windows.Forms.DataGridView();
            this.dgvRezidenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNjegovatelji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezidenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "vlastiti profil";
            // 
            // dgvNjegovatelji
            // 
            this.dgvNjegovatelji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNjegovatelji.Location = new System.Drawing.Point(42, 130);
            this.dgvNjegovatelji.Name = "dgvNjegovatelji";
            this.dgvNjegovatelji.Size = new System.Drawing.Size(240, 150);
            this.dgvNjegovatelji.TabIndex = 1;
            // 
            // dgvRezidenti
            // 
            this.dgvRezidenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezidenti.Location = new System.Drawing.Point(370, 130);
            this.dgvRezidenti.Name = "dgvRezidenti";
            this.dgvRezidenti.Size = new System.Drawing.Size(240, 150);
            this.dgvRezidenti.TabIndex = 2;
            // 
            // VlastitiProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 408);
            this.Controls.Add(this.dgvRezidenti);
            this.Controls.Add(this.dgvNjegovatelji);
            this.Controls.Add(this.label1);
            this.Name = "VlastitiProfil";
            this.Text = "VlastitiProfil";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNjegovatelji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezidenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNjegovatelji;
        private System.Windows.Forms.DataGridView dgvRezidenti;
    }
}