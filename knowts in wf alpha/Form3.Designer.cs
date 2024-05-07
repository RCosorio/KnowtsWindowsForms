namespace knowts_in_wf_alpha
{
    partial class ViewUpdateNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUpdateNote));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNewTitle = new System.Windows.Forms.TextBox();
            this.txtBoxNewContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipEnableEdit = new System.Windows.Forms.ToolTip(this.components);
            this.btnEnableEdit = new System.Windows.Forms.Button();
            this.toolTipUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCopyToClipboard = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.btnPasteImport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtBoxNewTitle
            // 
            this.txtBoxNewTitle.BackColor = System.Drawing.Color.White;
            this.txtBoxNewTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNewTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxNewTitle.Location = new System.Drawing.Point(57, 7);
            this.txtBoxNewTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNewTitle.Name = "txtBoxNewTitle";
            this.txtBoxNewTitle.Size = new System.Drawing.Size(171, 16);
            this.txtBoxNewTitle.TabIndex = 1;
            // 
            // txtBoxNewContent
            // 
            this.txtBoxNewContent.BackColor = System.Drawing.Color.White;
            this.txtBoxNewContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNewContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxNewContent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewContent.Location = new System.Drawing.Point(0, 79);
            this.txtBoxNewContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNewContent.Multiline = true;
            this.txtBoxNewContent.Name = "txtBoxNewContent";
            this.txtBoxNewContent.Size = new System.Drawing.Size(457, 484);
            this.txtBoxNewContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag";
            // 
            // btnEnableEdit
            // 
            this.btnEnableEdit.Enabled = false;
            this.btnEnableEdit.FlatAppearance.BorderSize = 0;
            this.btnEnableEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableEdit.Location = new System.Drawing.Point(4, 48);
            this.btnEnableEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnableEdit.Name = "btnEnableEdit";
            this.btnEnableEdit.Size = new System.Drawing.Size(33, 18);
            this.btnEnableEdit.TabIndex = 6;
            this.toolTipEnableEdit.SetToolTip(this.btnEnableEdit, "Enable/Disable Edit");
            this.btnEnableEdit.UseVisualStyleBackColor = true;
            this.btnEnableEdit.Click += new System.EventHandler(this.btnEnableEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnShare);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(237, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 81);
            this.panel1.TabIndex = 8;
            // 
            // comboBoxTag
            // 
            this.comboBoxTag.FormattingEnabled = true;
            this.comboBoxTag.Items.AddRange(new object[] {
            "Personal",
            "Work",
            "Study",
            "Ideas",
            "Shopping",
            "Travel",
            "Recipes",
            "Health",
            "Finance",
            "Events"});
            this.comboBoxTag.Location = new System.Drawing.Point(57, 28);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTag.TabIndex = 12;
            // 
            // btnPasteImport
            // 
            this.btnPasteImport.BackColor = System.Drawing.Color.White;
            this.btnPasteImport.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.paste__1_;
            this.btnPasteImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasteImport.FlatAppearance.BorderSize = 0;
            this.btnPasteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteImport.Location = new System.Drawing.Point(66, 504);
            this.btnPasteImport.Name = "btnPasteImport";
            this.btnPasteImport.Size = new System.Drawing.Size(47, 46);
            this.btnPasteImport.TabIndex = 14;
            this.btnPasteImport.UseVisualStyleBackColor = false;
            this.btnPasteImport.Click += new System.EventHandler(this.btnPasteImport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.file_import;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(13, 504);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(47, 46);
            this.btnImport.TabIndex = 13;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnShare
            // 
            this.btnShare.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.share_square;
            this.btnShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Location = new System.Drawing.Point(13, 21);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(47, 46);
            this.btnShare.TabIndex = 8;
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.trash;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(69, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 51);
            this.btnDelete.TabIndex = 7;
            this.toolTipEnableEdit.SetToolTip(this.btnDelete, "Enable/Disable Edit");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.edit__1_;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(148, 19);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(51, 50);
            this.btnUpdate.TabIndex = 4;
            this.toolTipUpdate.SetToolTip(this.btnUpdate, "Update");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.White;
            this.btnCopyToClipboard.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.copy;
            this.btnCopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopyToClipboard.FlatAppearance.BorderSize = 0;
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(405, 504);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(41, 48);
            this.btnCopyToClipboard.TabIndex = 5;
            this.toolTipCopyToClipboard.SetToolTip(this.btnCopyToClipboard, "Copy Text to Clipboard");
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // ViewUpdateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(457, 563);
            this.Controls.Add(this.btnPasteImport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.btnEnableEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtBoxNewContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNewTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewUpdateNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Note";
            this.Load += new System.EventHandler(this.ViewUpdateNote_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNewTitle;
        private System.Windows.Forms.TextBox txtBoxNewContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.ToolTip toolTipEnableEdit;
        private System.Windows.Forms.ToolTip toolTipCopyToClipboard;
        private System.Windows.Forms.ToolTip toolTipUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.Button btnEnableEdit;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnPasteImport;
    }
}