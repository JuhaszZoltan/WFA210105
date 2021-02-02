
namespace feladatok12_15
{
    partial class Form1
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
            this.tbKedvencSzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSmiley = new System.Windows.Forms.PictureBox();
            this.btnVissza = new System.Windows.Forms.Button();
            this.btnTunjEl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKedvencSzo
            // 
            this.tbKedvencSzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKedvencSzo.Location = new System.Drawing.Point(53, 76);
            this.tbKedvencSzo.Name = "tbKedvencSzo";
            this.tbKedvencSzo.Size = new System.Drawing.Size(812, 30);
            this.tbKedvencSzo.TabIndex = 0;
            this.tbKedvencSzo.TextChanged += new System.EventHandler(this.tbKedvencSzo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi a kedvenc szavad?";
            // 
            // pbSmiley
            // 
            this.pbSmiley.Image = global::feladatok12_15.Properties.Resources.smiley_open;
            this.pbSmiley.Location = new System.Drawing.Point(379, 203);
            this.pbSmiley.Name = "pbSmiley";
            this.pbSmiley.Size = new System.Drawing.Size(200, 200);
            this.pbSmiley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSmiley.TabIndex = 2;
            this.pbSmiley.TabStop = false;
            this.pbSmiley.Click += new System.EventHandler(this.pbSmiley_Click);
            this.pbSmiley.MouseEnter += new System.EventHandler(this.pbSmiley_MouseEnter);
            this.pbSmiley.MouseLeave += new System.EventHandler(this.pbSmiley_MouseLeave);
            // 
            // btnVissza
            // 
            this.btnVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVissza.Location = new System.Drawing.Point(616, 561);
            this.btnVissza.Name = "btnVissza";
            this.btnVissza.Size = new System.Drawing.Size(249, 70);
            this.btnVissza.TabIndex = 3;
            this.btnVissza.Text = "gyere vissza!";
            this.btnVissza.UseVisualStyleBackColor = true;
            this.btnVissza.Click += new System.EventHandler(this.btnVissza_Click);
            // 
            // btnTunjEl
            // 
            this.btnTunjEl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTunjEl.Location = new System.Drawing.Point(53, 561);
            this.btnTunjEl.Name = "btnTunjEl";
            this.btnTunjEl.Size = new System.Drawing.Size(249, 70);
            this.btnTunjEl.TabIndex = 3;
            this.btnTunjEl.Text = "tűnj el!";
            this.btnTunjEl.UseVisualStyleBackColor = true;
            this.btnTunjEl.Click += new System.EventHandler(this.btnTunjEl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 673);
            this.Controls.Add(this.btnTunjEl);
            this.Controls.Add(this.btnVissza);
            this.Controls.Add(this.pbSmiley);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKedvencSzo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSmiley)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKedvencSzo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSmiley;
        private System.Windows.Forms.Button btnVissza;
        private System.Windows.Forms.Button btnTunjEl;
    }
}

