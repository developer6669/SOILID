
namespace Solid
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLSP = new System.Windows.Forms.Button();
            this.btnOCP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLSP
            // 
            this.btnLSP.Location = new System.Drawing.Point(521, 75);
            this.btnLSP.Name = "btnLSP";
            this.btnLSP.Size = new System.Drawing.Size(160, 160);
            this.btnLSP.TabIndex = 0;
            this.btnLSP.Text = "LSP";
            this.btnLSP.UseVisualStyleBackColor = true;
            this.btnLSP.Click += new System.EventHandler(this.btnLSP_Click);
            // 
            // btnOCP
            // 
            this.btnOCP.Location = new System.Drawing.Point(357, 75);
            this.btnOCP.Name = "btnOCP";
            this.btnOCP.Size = new System.Drawing.Size(160, 160);
            this.btnOCP.TabIndex = 1;
            this.btnOCP.Text = "OCP";
            this.btnOCP.UseVisualStyleBackColor = true;
            this.btnOCP.Click += new System.EventHandler(this.btnOCP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOCP);
            this.Controls.Add(this.btnLSP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLSP;
        private System.Windows.Forms.Button btnOCP;
    }
}

