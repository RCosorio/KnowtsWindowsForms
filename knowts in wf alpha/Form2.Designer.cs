namespace knowts_in_wf_alpha
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNoteTitle = new System.Windows.Forms.TextBox();
            this.txtBoxContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipImagetoText = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCopyToClipboard = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTag = new System.Windows.Forms.ComboBox();
            this.btnPasteImport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnImageToText = new System.Windows.Forms.Button();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Note Title";
            // 
            // txtBoxNoteTitle
            // 
            this.txtBoxNoteTitle.BackColor = System.Drawing.Color.White;
            this.txtBoxNoteTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNoteTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNoteTitle.Location = new System.Drawing.Point(79, 7);
            this.txtBoxNoteTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNoteTitle.Name = "txtBoxNoteTitle";
            this.txtBoxNoteTitle.Size = new System.Drawing.Size(167, 17);
            this.txtBoxNoteTitle.TabIndex = 1;
            // 
            // txtBoxContent
            // 
            this.txtBoxContent.BackColor = System.Drawing.Color.White;
            this.txtBoxContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxContent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContent.Location = new System.Drawing.Point(0, 71);
            this.txtBoxContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxContent.Multiline = true;
            this.txtBoxContent.Name = "txtBoxContent";
            this.txtBoxContent.Size = new System.Drawing.Size(465, 481);
            this.txtBoxContent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag";
            // 
            // toolTipImagetoText
            // 
            this.toolTipImagetoText.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnImageToText);
            this.panel1.Controls.Add(this.btnSaveNote);
            this.panel1.Location = new System.Drawing.Point(277, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 58);
            this.panel1.TabIndex = 10;
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
            this.comboBoxTag.Location = new System.Drawing.Point(79, 29);
            this.comboBoxTag.Name = "comboBoxTag";
            this.comboBoxTag.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTag.TabIndex = 11;
            // 
            // btnPasteImport
            // 
            this.btnPasteImport.BackColor = System.Drawing.Color.White;
            this.btnPasteImport.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.paste__1_1;
            this.btnPasteImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPasteImport.FlatAppearance.BorderSize = 0;
            this.btnPasteImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteImport.Location = new System.Drawing.Point(63, 495);
            this.btnPasteImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasteImport.Name = "btnPasteImport";
            this.btnPasteImport.Size = new System.Drawing.Size(44, 42);
            this.btnPasteImport.TabIndex = 13;
            this.toolTipImagetoText.SetToolTip(this.btnPasteImport, "Image to Text");
            this.btnPasteImport.UseVisualStyleBackColor = false;
            this.btnPasteImport.Click += new System.EventHandler(this.btnPasteImport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.file_import1;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(15, 495);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(44, 42);
            this.btnImport.TabIndex = 12;
            this.toolTipImagetoText.SetToolTip(this.btnImport, "Image to Text");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImageToText
            // 
            this.btnImageToText.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.picture;
            this.btnImageToText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImageToText.FlatAppearance.BorderSize = 0;
            this.btnImageToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageToText.Location = new System.Drawing.Point(32, 14);
            this.btnImageToText.Margin = new System.Windows.Forms.Padding(2);
            this.btnImageToText.Name = "btnImageToText";
            this.btnImageToText.Size = new System.Drawing.Size(44, 42);
            this.btnImageToText.TabIndex = 8;
            this.toolTipImagetoText.SetToolTip(this.btnImageToText, "Image to Text");
            this.btnImageToText.UseVisualStyleBackColor = true;
            this.btnImageToText.Click += new System.EventHandler(this.btnImageToText_Click);
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.floppy_disks;
            this.btnSaveNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveNote.FlatAppearance.BorderSize = 0;
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Location = new System.Drawing.Point(105, 15);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(50, 43);
            this.btnSaveNote.TabIndex = 6;
            this.toolTipSave.SetToolTip(this.btnSaveNote, "Save");
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.White;
            this.btnCopyToClipboard.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.copy;
            this.btnCopyToClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopyToClipboard.FlatAppearance.BorderSize = 0;
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(404, 495);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(50, 46);
            this.btnCopyToClipboard.TabIndex = 7;
            this.toolTipCopyToClipboard.SetToolTip(this.btnCopyToClipboard, "Copy Text to Clipboard");
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(465, 552);
            this.Controls.Add(this.btnPasteImport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.comboBoxTag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtBoxContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNoteTitle);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(444, 411);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Note";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveNote;
        public System.Windows.Forms.TextBox txtBoxContent;
        public System.Windows.Forms.TextBox txtBoxNoteTitle;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnImageToText;
        private System.Windows.Forms.ToolTip toolTipImagetoText;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipCopyToClipboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTag;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnPasteImport;
    }
}