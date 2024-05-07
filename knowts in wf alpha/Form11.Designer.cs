namespace knowts_in_wf_alpha
{
    partial class PublicAnalytics
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFeedbacks = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.labelAverageRating = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTag2 = new System.Windows.Forms.Label();
            this.labelTag3 = new System.Windows.Forms.Label();
            this.labelShared = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Community Feedback and Info";
            // 
            // dgvFeedbacks
            // 
            this.dgvFeedbacks.AllowUserToAddRows = false;
            this.dgvFeedbacks.AllowUserToDeleteRows = false;
            this.dgvFeedbacks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbacks.ColumnHeadersVisible = false;
            this.dgvFeedbacks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFeedbacks.Location = new System.Drawing.Point(0, 255);
            this.dgvFeedbacks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFeedbacks.Name = "dgvFeedbacks";
            this.dgvFeedbacks.ReadOnly = true;
            this.dgvFeedbacks.RowHeadersVisible = false;
            this.dgvFeedbacks.RowHeadersWidth = 51;
            this.dgvFeedbacks.RowTemplate.Height = 60;
            this.dgvFeedbacks.Size = new System.Drawing.Size(654, 275);
            this.dgvFeedbacks.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(587, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Average User Experience Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(461, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "_% of overall users experience \r\nissues while using the app";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentage.Location = new System.Drawing.Point(427, 129);
            this.labelPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(44, 37);
            this.labelPercentage.TabIndex = 17;
            this.labelPercentage.Text = "%";
            this.labelPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverageRating
            // 
            this.labelAverageRating.AutoSize = true;
            this.labelAverageRating.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageRating.Location = new System.Drawing.Point(77, 105);
            this.labelAverageRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAverageRating.Name = "labelAverageRating";
            this.labelAverageRating.Size = new System.Drawing.Size(44, 37);
            this.labelAverageRating.TabIndex = 18;
            this.labelAverageRating.Text = "%";
            this.labelAverageRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 79);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.leaderboard_alt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(243, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Users\' Most Interesting Tags";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTag.Location = new System.Drawing.Point(256, 101);
            this.labelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(44, 37);
            this.labelTag.TabIndex = 21;
            this.labelTag.Text = "%";
            this.labelTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(398, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "Most Recent User Feedback and Suggestions";
            // 
            // labelTag2
            // 
            this.labelTag2.AutoSize = true;
            this.labelTag2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTag2.Location = new System.Drawing.Point(256, 138);
            this.labelTag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTag2.Name = "labelTag2";
            this.labelTag2.Size = new System.Drawing.Size(44, 37);
            this.labelTag2.TabIndex = 23;
            this.labelTag2.Text = "%";
            this.labelTag2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTag3
            // 
            this.labelTag3.AutoSize = true;
            this.labelTag3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTag3.Location = new System.Drawing.Point(256, 175);
            this.labelTag3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTag3.Name = "labelTag3";
            this.labelTag3.Size = new System.Drawing.Size(44, 37);
            this.labelTag3.TabIndex = 24;
            this.labelTag3.Text = "%";
            this.labelTag3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelShared
            // 
            this.labelShared.AutoSize = true;
            this.labelShared.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShared.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelShared.Location = new System.Drawing.Point(77, 191);
            this.labelShared.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShared.Name = "labelShared";
            this.labelShared.Size = new System.Drawing.Size(44, 37);
            this.labelShared.TabIndex = 25;
            this.labelShared.Text = "%";
            this.labelShared.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(31, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "Number of Notes Shared";
            // 
            // PublicAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 530);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelShared);
            this.Controls.Add(this.labelTag3);
            this.Controls.Add(this.labelTag2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAverageRating);
            this.Controls.Add(this.labelPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFeedbacks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PublicAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Feedbacks";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFeedbacks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.Label labelAverageRating;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTag2;
        private System.Windows.Forms.Label labelTag3;
        private System.Windows.Forms.Label labelShared;
        private System.Windows.Forms.Label label7;
    }
}