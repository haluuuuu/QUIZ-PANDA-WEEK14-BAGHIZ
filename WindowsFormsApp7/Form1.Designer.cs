namespace WindowsFormsApp7
{
    partial class Formp
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
            this.lblmasukkankalimat = new System.Windows.Forms.Label();
            this.lblmasukkanhuruf = new System.Windows.Forms.Label();
            this.txtinputkalimat = new System.Windows.Forms.TextBox();
            this.txtinputhuruf = new System.Windows.Forms.TextBox();
            this.lblmenjadi = new System.Windows.Forms.Label();
            this.txthurufubah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnkonversihuruf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.lblhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmasukkankalimat
            // 
            this.lblmasukkankalimat.AutoSize = true;
            this.lblmasukkankalimat.Location = new System.Drawing.Point(39, 55);
            this.lblmasukkankalimat.Name = "lblmasukkankalimat";
            this.lblmasukkankalimat.Size = new System.Drawing.Size(138, 20);
            this.lblmasukkankalimat.TabIndex = 0;
            this.lblmasukkankalimat.Text = "Masukkan Kalimat";
            // 
            // lblmasukkanhuruf
            // 
            this.lblmasukkanhuruf.AutoSize = true;
            this.lblmasukkanhuruf.Location = new System.Drawing.Point(39, 117);
            this.lblmasukkanhuruf.Name = "lblmasukkanhuruf";
            this.lblmasukkanhuruf.Size = new System.Drawing.Size(126, 20);
            this.lblmasukkanhuruf.TabIndex = 1;
            this.lblmasukkanhuruf.Text = "Masukkan Huruf";
            // 
            // txtinputkalimat
            // 
            this.txtinputkalimat.Location = new System.Drawing.Point(183, 55);
            this.txtinputkalimat.Name = "txtinputkalimat";
            this.txtinputkalimat.Size = new System.Drawing.Size(379, 26);
            this.txtinputkalimat.TabIndex = 2;
            // 
            // txtinputhuruf
            // 
            this.txtinputhuruf.Location = new System.Drawing.Point(189, 111);
            this.txtinputhuruf.Name = "txtinputhuruf";
            this.txtinputhuruf.Size = new System.Drawing.Size(142, 26);
            this.txtinputhuruf.TabIndex = 3;
            this.txtinputhuruf.TextChanged += new System.EventHandler(this.txtinputhuruf_TextChanged);
            // 
            // lblmenjadi
            // 
            this.lblmenjadi.AutoSize = true;
            this.lblmenjadi.Location = new System.Drawing.Point(346, 117);
            this.lblmenjadi.Name = "lblmenjadi";
            this.lblmenjadi.Size = new System.Drawing.Size(64, 20);
            this.lblmenjadi.TabIndex = 4;
            this.lblmenjadi.Text = "Menjadi";
            // 
            // txthurufubah
            // 
            this.txthurufubah.Location = new System.Drawing.Point(433, 108);
            this.txthurufubah.Name = "txthurufubah";
            this.txthurufubah.Size = new System.Drawing.Size(129, 26);
            this.txthurufubah.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // btnkonversihuruf
            // 
            this.btnkonversihuruf.Location = new System.Drawing.Point(183, 179);
            this.btnkonversihuruf.Name = "btnkonversihuruf";
            this.btnkonversihuruf.Size = new System.Drawing.Size(379, 34);
            this.btnkonversihuruf.TabIndex = 8;
            this.btnkonversihuruf.Text = "Konversi!";
            this.btnkonversihuruf.UseVisualStyleBackColor = true;
            this.btnkonversihuruf.Click += new System.EventHandler(this.btnkonversihuruf_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 9;
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(179, 261);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(0, 20);
            this.labelhasil.TabIndex = 10;
            // 
            // lblhasil
            // 
            this.lblhasil.AutoSize = true;
            this.lblhasil.Location = new System.Drawing.Point(185, 261);
            this.lblhasil.Name = "lblhasil";
            this.lblhasil.Size = new System.Drawing.Size(21, 20);
            this.lblhasil.TabIndex = 11;
            this.lblhasil.Text = "...";
            // 
            // Formp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblhasil);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnkonversihuruf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthurufubah);
            this.Controls.Add(this.lblmenjadi);
            this.Controls.Add(this.txtinputhuruf);
            this.Controls.Add(this.txtinputkalimat);
            this.Controls.Add(this.lblmasukkanhuruf);
            this.Controls.Add(this.lblmasukkankalimat);
            this.Name = "Formp";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasukkankalimat;
        private System.Windows.Forms.Label lblmasukkanhuruf;
        private System.Windows.Forms.TextBox txtinputkalimat;
        private System.Windows.Forms.TextBox txtinputhuruf;
        private System.Windows.Forms.Label lblmenjadi;
        private System.Windows.Forms.TextBox txthurufubah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkonversihuruf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelhasil;
        private System.Windows.Forms.Label lblhasil;
    }
}

