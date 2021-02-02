
namespace feladatok12_13
{
    partial class FrmMain
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
            this.btnJatekos_Papir = new System.Windows.Forms.Button();
            this.btnJatekos_Ollo = new System.Windows.Forms.Button();
            this.btnJatekos_Ko = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGep_Papir = new System.Windows.Forms.Button();
            this.btnGep_Ollo = new System.Windows.Forms.Button();
            this.btnGep_Ko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos:";
            // 
            // btnJatekos_Papir
            // 
            this.btnJatekos_Papir.BackColor = System.Drawing.Color.LightGray;
            this.btnJatekos_Papir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJatekos_Papir.Location = new System.Drawing.Point(296, 28);
            this.btnJatekos_Papir.Name = "btnJatekos_Papir";
            this.btnJatekos_Papir.Size = new System.Drawing.Size(158, 56);
            this.btnJatekos_Papir.TabIndex = 1;
            this.btnJatekos_Papir.Text = "PAPÍR";
            this.btnJatekos_Papir.UseVisualStyleBackColor = false;
            this.btnJatekos_Papir.Click += new System.EventHandler(this.BtnJatekos_Click);
            // 
            // btnJatekos_Ollo
            // 
            this.btnJatekos_Ollo.BackColor = System.Drawing.Color.LightGray;
            this.btnJatekos_Ollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJatekos_Ollo.Location = new System.Drawing.Point(460, 28);
            this.btnJatekos_Ollo.Name = "btnJatekos_Ollo";
            this.btnJatekos_Ollo.Size = new System.Drawing.Size(158, 56);
            this.btnJatekos_Ollo.TabIndex = 1;
            this.btnJatekos_Ollo.Text = "OLLÓ";
            this.btnJatekos_Ollo.UseVisualStyleBackColor = false;
            this.btnJatekos_Ollo.Click += new System.EventHandler(this.BtnJatekos_Click);
            // 
            // btnJatekos_Ko
            // 
            this.btnJatekos_Ko.BackColor = System.Drawing.Color.LightGray;
            this.btnJatekos_Ko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJatekos_Ko.Location = new System.Drawing.Point(132, 28);
            this.btnJatekos_Ko.Name = "btnJatekos_Ko";
            this.btnJatekos_Ko.Size = new System.Drawing.Size(158, 56);
            this.btnJatekos_Ko.TabIndex = 1;
            this.btnJatekos_Ko.Text = "KŐ";
            this.btnJatekos_Ko.UseVisualStyleBackColor = false;
            this.btnJatekos_Ko.Click += new System.EventHandler(this.BtnJatekos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gép:";
            // 
            // btnGep_Papir
            // 
            this.btnGep_Papir.BackColor = System.Drawing.Color.LightGray;
            this.btnGep_Papir.Enabled = false;
            this.btnGep_Papir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGep_Papir.Location = new System.Drawing.Point(296, 107);
            this.btnGep_Papir.Name = "btnGep_Papir";
            this.btnGep_Papir.Size = new System.Drawing.Size(158, 56);
            this.btnGep_Papir.TabIndex = 1;
            this.btnGep_Papir.Text = "PAPÍR";
            this.btnGep_Papir.UseVisualStyleBackColor = false;
            // 
            // btnGep_Ollo
            // 
            this.btnGep_Ollo.BackColor = System.Drawing.Color.LightGray;
            this.btnGep_Ollo.Enabled = false;
            this.btnGep_Ollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGep_Ollo.Location = new System.Drawing.Point(460, 107);
            this.btnGep_Ollo.Name = "btnGep_Ollo";
            this.btnGep_Ollo.Size = new System.Drawing.Size(158, 56);
            this.btnGep_Ollo.TabIndex = 1;
            this.btnGep_Ollo.Text = "OLLÓ";
            this.btnGep_Ollo.UseVisualStyleBackColor = false;
            // 
            // btnGep_Ko
            // 
            this.btnGep_Ko.BackColor = System.Drawing.Color.LightGray;
            this.btnGep_Ko.Enabled = false;
            this.btnGep_Ko.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGep_Ko.Location = new System.Drawing.Point(132, 107);
            this.btnGep_Ko.Name = "btnGep_Ko";
            this.btnGep_Ko.Size = new System.Drawing.Size(158, 56);
            this.btnGep_Ko.TabIndex = 1;
            this.btnGep_Ko.Text = "KŐ";
            this.btnGep_Ko.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 190);
            this.Controls.Add(this.btnGep_Ko);
            this.Controls.Add(this.btnGep_Ollo);
            this.Controls.Add(this.btnJatekos_Ko);
            this.Controls.Add(this.btnJatekos_Ollo);
            this.Controls.Add(this.btnGep_Papir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJatekos_Papir);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Kő-Papír-Olló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJatekos_Papir;
        private System.Windows.Forms.Button btnJatekos_Ollo;
        private System.Windows.Forms.Button btnJatekos_Ko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGep_Papir;
        private System.Windows.Forms.Button btnGep_Ollo;
        private System.Windows.Forms.Button btnGep_Ko;
    }
}

