
namespace feladatok12_4
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
            this.lblText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKek = new System.Windows.Forms.Button();
            this.btnFeher = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnJK = new System.Windows.Forms.Button();
            this.btnKK = new System.Windows.Forms.Button();
            this.btnBK = new System.Windows.Forms.Button();
            this.btnNagy = new System.Windows.Forms.Button();
            this.btnNagyit = new System.Windows.Forms.Button();
            this.btnKicsinyit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlap = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(13, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(644, 312);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Hello World!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnKek, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFeher, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTorol, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJK, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnKK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNagy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNagyit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnKicsinyit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAlap, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 328);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 306);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnKek
            // 
            this.btnKek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKek.Location = new System.Drawing.Point(3, 3);
            this.btnKek.Name = "btnKek";
            this.btnKek.Size = new System.Drawing.Size(208, 70);
            this.btnKek.TabIndex = 0;
            this.btnKek.Text = "Kék betű";
            this.btnKek.UseVisualStyleBackColor = true;
            this.btnKek.Click += new System.EventHandler(this.btnKek_Click);
            // 
            // btnFeher
            // 
            this.btnFeher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFeher.Location = new System.Drawing.Point(217, 3);
            this.btnFeher.Name = "btnFeher";
            this.btnFeher.Size = new System.Drawing.Size(208, 70);
            this.btnFeher.TabIndex = 0;
            this.btnFeher.Text = "Fehér háttér";
            this.btnFeher.UseVisualStyleBackColor = true;
            this.btnFeher.Click += new System.EventHandler(this.btnFeher_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.Location = new System.Drawing.Point(432, 3);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(208, 70);
            this.btnTorol.TabIndex = 0;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnJK
            // 
            this.btnJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJK.Location = new System.Drawing.Point(432, 79);
            this.btnJK.Name = "btnJK";
            this.btnJK.Size = new System.Drawing.Size(208, 70);
            this.btnJK.TabIndex = 0;
            this.btnJK.Text = "Jobb-közép";
            this.btnJK.UseVisualStyleBackColor = true;
            this.btnJK.Click += new System.EventHandler(this.btnJK_Click);
            // 
            // btnKK
            // 
            this.btnKK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKK.Location = new System.Drawing.Point(217, 79);
            this.btnKK.Name = "btnKK";
            this.btnKK.Size = new System.Drawing.Size(208, 70);
            this.btnKK.TabIndex = 0;
            this.btnKK.Text = "Közép-közép";
            this.btnKK.UseVisualStyleBackColor = true;
            this.btnKK.Click += new System.EventHandler(this.btnKK_Click);
            // 
            // btnBK
            // 
            this.btnBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBK.Location = new System.Drawing.Point(3, 79);
            this.btnBK.Name = "btnBK";
            this.btnBK.Size = new System.Drawing.Size(208, 70);
            this.btnBK.TabIndex = 0;
            this.btnBK.Text = "Bal-közép";
            this.btnBK.UseVisualStyleBackColor = true;
            this.btnBK.Click += new System.EventHandler(this.btnBK_Click);
            // 
            // btnNagy
            // 
            this.btnNagy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNagy.Location = new System.Drawing.Point(3, 155);
            this.btnNagy.Name = "btnNagy";
            this.btnNagy.Size = new System.Drawing.Size(208, 70);
            this.btnNagy.TabIndex = 0;
            this.btnNagy.Text = "Nagybetűs";
            this.btnNagy.UseVisualStyleBackColor = true;
            this.btnNagy.Click += new System.EventHandler(this.btnNagy_Click);
            // 
            // btnNagyit
            // 
            this.btnNagyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNagyit.Location = new System.Drawing.Point(217, 155);
            this.btnNagyit.Name = "btnNagyit";
            this.btnNagyit.Size = new System.Drawing.Size(208, 70);
            this.btnNagyit.TabIndex = 0;
            this.btnNagyit.Text = "Nagyít";
            this.btnNagyit.UseVisualStyleBackColor = true;
            this.btnNagyit.Click += new System.EventHandler(this.btnNagyit_Click);
            // 
            // btnKicsinyit
            // 
            this.btnKicsinyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKicsinyit.Location = new System.Drawing.Point(432, 155);
            this.btnKicsinyit.Name = "btnKicsinyit";
            this.btnKicsinyit.Size = new System.Drawing.Size(208, 70);
            this.btnKicsinyit.TabIndex = 0;
            this.btnKicsinyit.Text = "Kicsinyít";
            this.btnKicsinyit.UseVisualStyleBackColor = true;
            this.btnKicsinyit.Click += new System.EventHandler(this.btnKicsinyit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(432, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 70);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kilép";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAlap
            // 
            this.btnAlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlap.Location = new System.Drawing.Point(3, 231);
            this.btnAlap.Name = "btnAlap";
            this.btnAlap.Size = new System.Drawing.Size(208, 70);
            this.btnAlap.TabIndex = 0;
            this.btnAlap.Text = "Alaphelyzet";
            this.btnAlap.UseVisualStyleBackColor = true;
            this.btnAlap.Click += new System.EventHandler(this.btnAlap_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 646);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblText);
            this.Name = "FrmMain";
            this.Text = "Szöveg formázás";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnKek;
        private System.Windows.Forms.Button btnFeher;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnJK;
        private System.Windows.Forms.Button btnKK;
        private System.Windows.Forms.Button btnBK;
        private System.Windows.Forms.Button btnNagy;
        private System.Windows.Forms.Button btnNagyit;
        private System.Windows.Forms.Button btnKicsinyit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAlap;
    }
}

