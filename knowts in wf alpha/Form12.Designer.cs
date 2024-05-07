namespace knowts_in_wf_alpha
{
    partial class Form12
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
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.btnConfirmImport = new System.Windows.Forms.Button();
            this.btnPasteCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(10, 9);
            this.txtBoxCode.Multiline = true;
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(187, 42);
            this.txtBoxCode.TabIndex = 0;
            // 
            // btnConfirmImport
            // 
            this.btnConfirmImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.btnConfirmImport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmImport.ForeColor = System.Drawing.Color.White;
            this.btnConfirmImport.Location = new System.Drawing.Point(8, 62);
            this.btnConfirmImport.Name = "btnConfirmImport";
            this.btnConfirmImport.Size = new System.Drawing.Size(121, 33);
            this.btnConfirmImport.TabIndex = 1;
            this.btnConfirmImport.Text = "Import Content";
            this.btnConfirmImport.UseVisualStyleBackColor = false;
            this.btnConfirmImport.Click += new System.EventHandler(this.btnConfirmImport_Click);
            // 
            // btnPasteCode
            // 
            this.btnPasteCode.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.paste;
            this.btnPasteCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasteCode.FlatAppearance.BorderSize = 0;
            this.btnPasteCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteCode.Location = new System.Drawing.Point(135, 61);
            this.btnPasteCode.Name = "btnPasteCode";
            this.btnPasteCode.Size = new System.Drawing.Size(49, 33);
            this.btnPasteCode.TabIndex = 2;
            this.btnPasteCode.UseVisualStyleBackColor = true;
            this.btnPasteCode.Click += new System.EventHandler(this.btnPasteCode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtBoxCode);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 58);
            this.panel1.TabIndex = 3;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 103);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPasteCode);
            this.Controls.Add(this.btnConfirmImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Content";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.Button btnConfirmImport;
        private System.Windows.Forms.Button btnPasteCode;
        private System.Windows.Forms.Panel panel1;
    }
}