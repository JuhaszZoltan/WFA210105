
namespace feladatok12_6
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlso = new System.Windows.Forms.TextBox();
            this.txtFelso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMegadott = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMegallapit = new System.Windows.Forms.Button();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alsó határ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlso
            // 
            this.txtAlso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAlso.Location = new System.Drawing.Point(12, 38);
            this.txtAlso.Name = "txtAlso";
            this.txtAlso.Size = new System.Drawing.Size(154, 30);
            this.txtAlso.TabIndex = 3;
            // 
            // txtFelso
            // 
            this.txtFelso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFelso.Location = new System.Drawing.Point(260, 38);
            this.txtFelso.Name = "txtFelso";
            this.txtFelso.Size = new System.Drawing.Size(154, 30);
            this.txtFelso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felső hatás:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMegadott
            // 
            this.txtMegadott.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMegadott.Location = new System.Drawing.Point(12, 117);
            this.txtMegadott.Name = "txtMegadott";
            this.txtMegadott.Size = new System.Drawing.Size(228, 30);
            this.txtMegadott.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "A megadott szám:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMegallapit
            // 
            this.btnMegallapit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegallapit.Location = new System.Drawing.Point(260, 88);
            this.btnMegallapit.Name = "btnMegallapit";
            this.btnMegallapit.Size = new System.Drawing.Size(153, 59);
            this.btnMegallapit.TabIndex = 4;
            this.btnMegallapit.Text = "Megállapít";
            this.btnMegallapit.UseVisualStyleBackColor = true;
            this.btnMegallapit.Click += new System.EventHandler(this.BtnMegallapit_Click);
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEredmeny.Location = new System.Drawing.Point(7, 150);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(406, 47);
            this.lblEredmeny.TabIndex = 2;
            this.lblEredmeny.Text = "#placeholder#";
            this.lblEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 206);
            this.Controls.Add(this.btnMegallapit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFelso);
            this.Controls.Add(this.txtMegadott);
            this.Controls.Add(this.txtAlso);
            this.Name = "Form1";
            this.Text = "Intervallum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlso;
        private System.Windows.Forms.TextBox txtFelso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMegadott;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMegallapit;
        private System.Windows.Forms.Label lblEredmeny;
    }
}

