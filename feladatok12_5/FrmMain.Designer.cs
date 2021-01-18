
namespace feladatok12_5
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
            this.txtElso = new System.Windows.Forms.TextBox();
            this.btnOsszeadas = new System.Windows.Forms.Button();
            this.btnSzorzas = new System.Windows.Forms.Button();
            this.btnOsztas = new System.Windows.Forms.Button();
            this.btnKivonas = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasodik = new System.Windows.Forms.TextBox();
            this.lblMuvelet = new System.Windows.Forms.Label();
            this.txtEredmeny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(254, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. adat:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtElso
            // 
            this.txtElso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtElso.Location = new System.Drawing.Point(17, 56);
            this.txtElso.Name = "txtElso";
            this.txtElso.Size = new System.Drawing.Size(115, 30);
            this.txtElso.TabIndex = 1;
            this.txtElso.TextChanged += new System.EventHandler(this.TxtAdat_TextChanged);
            // 
            // btnOsszeadas
            // 
            this.btnOsszeadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsszeadas.Location = new System.Drawing.Point(12, 188);
            this.btnOsszeadas.Name = "btnOsszeadas";
            this.btnOsszeadas.Size = new System.Drawing.Size(143, 49);
            this.btnOsszeadas.TabIndex = 2;
            this.btnOsszeadas.Text = "Összeadás";
            this.btnOsszeadas.UseVisualStyleBackColor = true;
            this.btnOsszeadas.Click += new System.EventHandler(this.BtnClick_Szamol);
            // 
            // btnSzorzas
            // 
            this.btnSzorzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzorzas.Location = new System.Drawing.Point(12, 243);
            this.btnSzorzas.Name = "btnSzorzas";
            this.btnSzorzas.Size = new System.Drawing.Size(143, 49);
            this.btnSzorzas.TabIndex = 2;
            this.btnSzorzas.Text = "Szorzás";
            this.btnSzorzas.UseVisualStyleBackColor = true;
            this.btnSzorzas.Click += new System.EventHandler(this.BtnClick_Szamol);
            // 
            // btnOsztas
            // 
            this.btnOsztas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOsztas.Location = new System.Drawing.Point(226, 243);
            this.btnOsztas.Name = "btnOsztas";
            this.btnOsztas.Size = new System.Drawing.Size(143, 49);
            this.btnOsztas.TabIndex = 2;
            this.btnOsztas.Text = "Osztás";
            this.btnOsztas.UseVisualStyleBackColor = true;
            this.btnOsztas.Click += new System.EventHandler(this.BtnClick_Szamol);
            // 
            // btnKivonas
            // 
            this.btnKivonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKivonas.Location = new System.Drawing.Point(226, 188);
            this.btnKivonas.Name = "btnKivonas";
            this.btnKivonas.Size = new System.Drawing.Size(143, 49);
            this.btnKivonas.TabIndex = 2;
            this.btnKivonas.Text = "Kivonás";
            this.btnKivonas.UseVisualStyleBackColor = true;
            this.btnKivonas.Click += new System.EventHandler(this.BtnClick_Szamol);
            // 
            // btnTorles
            // 
            this.btnTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorles.Location = new System.Drawing.Point(117, 298);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(148, 49);
            this.btnTorles.TabIndex = 2;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. adat:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMasodik
            // 
            this.txtMasodik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMasodik.Location = new System.Drawing.Point(254, 56);
            this.txtMasodik.Name = "txtMasodik";
            this.txtMasodik.Size = new System.Drawing.Size(115, 30);
            this.txtMasodik.TabIndex = 1;
            this.txtMasodik.TextChanged += new System.EventHandler(this.TxtAdat_TextChanged);
            // 
            // lblMuvelet
            // 
            this.lblMuvelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMuvelet.Location = new System.Drawing.Point(12, 101);
            this.lblMuvelet.Name = "lblMuvelet";
            this.lblMuvelet.Size = new System.Drawing.Size(357, 25);
            this.lblMuvelet.TabIndex = 0;
            this.lblMuvelet.Text = "Művelet eredménye:";
            this.lblMuvelet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEredmeny
            // 
            this.txtEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEredmeny.Location = new System.Drawing.Point(137, 129);
            this.txtEredmeny.Name = "txtEredmeny";
            this.txtEredmeny.Size = new System.Drawing.Size(115, 30);
            this.txtEredmeny.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 360);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnKivonas);
            this.Controls.Add(this.btnOsztas);
            this.Controls.Add(this.btnSzorzas);
            this.Controls.Add(this.btnOsszeadas);
            this.Controls.Add(this.txtEredmeny);
            this.Controls.Add(this.lblMuvelet);
            this.Controls.Add(this.txtMasodik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtElso);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Alapműveletek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElso;
        private System.Windows.Forms.Button btnOsszeadas;
        private System.Windows.Forms.Button btnSzorzas;
        private System.Windows.Forms.Button btnOsztas;
        private System.Windows.Forms.Button btnKivonas;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasodik;
        private System.Windows.Forms.Label lblMuvelet;
        private System.Windows.Forms.TextBox txtEredmeny;
    }
}

