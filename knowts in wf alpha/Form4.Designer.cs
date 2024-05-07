namespace knowts_in_wf_alpha
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            this.labelSearchResult = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(20, 25);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(168, 20);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // dvgSearch
            // 
            this.dvgSearch.AllowUserToOrderColumns = true;
            this.dvgSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dvgSearch.BackgroundColor = System.Drawing.Color.White;
            this.dvgSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSearch.ColumnHeadersVisible = false;
            this.dvgSearch.Location = new System.Drawing.Point(-95, 78);
            this.dvgSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dvgSearch.Name = "dvgSearch";
            this.dvgSearch.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgSearch.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgSearch.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgSearch.RowTemplate.Height = 24;
            this.dvgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSearch.Size = new System.Drawing.Size(482, 445);
            this.dvgSearch.TabIndex = 2;
            this.dvgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSearch_CellContentClick);
            // 
            // labelSearchResult
            // 
            this.labelSearchResult.AutoSize = true;
            this.labelSearchResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchResult.ForeColor = System.Drawing.Color.White;
            this.labelSearchResult.Location = new System.Drawing.Point(31, 51);
            this.labelSearchResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchResult.Name = "labelSearchResult";
            this.labelSearchResult.Size = new System.Drawing.Size(14, 11);
            this.labelSearchResult.TabIndex = 4;
            this.labelSearchResult.Text = "...";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Title and Content",
            "Tag"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(193, 25);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(77, 21);
            this.comboBoxSearchBy.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::knowts_in_wf_alpha.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(278, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(337, 523);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.labelSearchResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dvgSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.DataGridView dvgSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearchResult;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
    }
}