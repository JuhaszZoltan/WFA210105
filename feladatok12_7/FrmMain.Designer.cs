
namespace feladatok12_7
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
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(190, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(102, 22);
            this.txtInput.TabIndex = 0;
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(12, 40);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtOutput.Size = new System.Drawing.Size(280, 185);
            this.rtxtOutput.TabIndex = 1;
            this.rtxtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hány kockadobást kérsz?";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 236);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(280, 40);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "Dobás";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.BtnGenClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 288);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmMain";
            this.Text = "Kockadobások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGen;
    }
}

