
namespace feladatok12_9
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbGyumolcsok = new System.Windows.Forms.ListBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnOsszesTorol = new System.Windows.Forms.Button();
            this.btnKijeloltTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(185, 30);
            this.txtInput.TabIndex = 0;
            // 
            // lbGyumolcsok
            // 
            this.lbGyumolcsok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbGyumolcsok.FormattingEnabled = true;
            this.lbGyumolcsok.ItemHeight = 25;
            this.lbGyumolcsok.Location = new System.Drawing.Point(12, 48);
            this.lbGyumolcsok.Name = "lbGyumolcsok";
            this.lbGyumolcsok.Size = new System.Drawing.Size(185, 304);
            this.lbGyumolcsok.TabIndex = 1;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.Location = new System.Drawing.Point(203, 12);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(166, 40);
            this.btnHozzaad.TabIndex = 2;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.BtnHozzaad_Click);
            // 
            // btnOsszesTorol
            // 
            this.btnOsszesTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsszesTorol.Location = new System.Drawing.Point(203, 58);
            this.btnOsszesTorol.Name = "btnOsszesTorol";
            this.btnOsszesTorol.Size = new System.Drawing.Size(166, 88);
            this.btnOsszesTorol.TabIndex = 2;
            this.btnOsszesTorol.Text = "Összes törlése";
            this.btnOsszesTorol.UseVisualStyleBackColor = true;
            this.btnOsszesTorol.Click += new System.EventHandler(this.BtnOsszesTorol_Click);
            // 
            // btnKijeloltTorol
            // 
            this.btnKijeloltTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKijeloltTorol.Location = new System.Drawing.Point(203, 152);
            this.btnKijeloltTorol.Name = "btnKijeloltTorol";
            this.btnKijeloltTorol.Size = new System.Drawing.Size(166, 88);
            this.btnKijeloltTorol.TabIndex = 2;
            this.btnKijeloltTorol.Text = "Kijelölt törlése";
            this.btnKijeloltTorol.UseVisualStyleBackColor = true;
            this.btnKijeloltTorol.Click += new System.EventHandler(this.BtnKijeloltTorol_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 380);
            this.Controls.Add(this.btnKijeloltTorol);
            this.Controls.Add(this.btnOsszesTorol);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.lbGyumolcsok);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmMain";
            this.Text = "Gyümölcsök";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lbGyumolcsok;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnOsszesTorol;
        private System.Windows.Forms.Button btnKijeloltTorol;
    }
}

