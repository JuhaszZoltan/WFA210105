
namespace feladatok12_8
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
            this.lbOsztok = new System.Windows.Forms.ListBox();
            this.txtSzam = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám:";
            // 
            // lbOsztok
            // 
            this.lbOsztok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOsztok.FormattingEnabled = true;
            this.lbOsztok.ItemHeight = 25;
            this.lbOsztok.Location = new System.Drawing.Point(63, 95);
            this.lbOsztok.Name = "lbOsztok";
            this.lbOsztok.Size = new System.Drawing.Size(166, 304);
            this.lbOsztok.TabIndex = 1;
            // 
            // txtSzam
            // 
            this.txtSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSzam.Location = new System.Drawing.Point(142, 12);
            this.txtSzam.Name = "txtSzam";
            this.txtSzam.Size = new System.Drawing.Size(87, 30);
            this.txtSzam.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalc.Location = new System.Drawing.Point(63, 48);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(166, 41);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Osztók:";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 413);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtSzam);
            this.Controls.Add(this.lbOsztok);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Osztók";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbOsztok;
        private System.Windows.Forms.TextBox txtSzam;
        private System.Windows.Forms.Button btnCalc;
    }
}

