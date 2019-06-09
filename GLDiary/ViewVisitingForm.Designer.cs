namespace GLDiary
{
    partial class ViewVisitingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisitingForm));
            this.dataGridViewViewVisiting = new System.Windows.Forms.DataGridView();
            this.buttonViewVisiting = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.comboBoxSelectedSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisiting)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewVisiting
            // 
            this.dataGridViewViewVisiting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewViewVisiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewViewVisiting.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewViewVisiting.Location = new System.Drawing.Point(52, 84);
            this.dataGridViewViewVisiting.Name = "dataGridViewViewVisiting";
            this.dataGridViewViewVisiting.Size = new System.Drawing.Size(340, 281);
            this.dataGridViewViewVisiting.TabIndex = 0;
            this.dataGridViewViewVisiting.SelectionChanged += new System.EventHandler(this.dataGridViewViewVisiting_SelectionChanged);
            // 
            // buttonViewVisiting
            // 
            this.buttonViewVisiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewVisiting.Location = new System.Drawing.Point(317, 36);
            this.buttonViewVisiting.Name = "buttonViewVisiting";
            this.buttonViewVisiting.Size = new System.Drawing.Size(75, 23);
            this.buttonViewVisiting.TabIndex = 1;
            this.buttonViewVisiting.Text = "View";
            this.buttonViewVisiting.UseVisualStyleBackColor = true;
            this.buttonViewVisiting.Click += new System.EventHandler(this.buttonViewVisiting_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Location = new System.Drawing.Point(60, 41);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Subject";
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuitToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuitToMenu.BackgroundImage")));
            this.buttonQuitToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuitToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitToMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(30, 30);
            this.buttonQuitToMenu.TabIndex = 4;
            this.buttonQuitToMenu.UseVisualStyleBackColor = false;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // comboBoxSelectedSubject
            // 
            this.comboBoxSelectedSubject.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxSelectedSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectedSubject.FormattingEnabled = true;
            this.comboBoxSelectedSubject.Items.AddRange(new object[] {
            "Math",
            "Theory of algorithms",
            "PE",
            "English",
            "Structures",
            "Ukrainian",
            "Programming",
            "Physics"});
            this.comboBoxSelectedSubject.Location = new System.Drawing.Point(109, 38);
            this.comboBoxSelectedSubject.Name = "comboBoxSelectedSubject";
            this.comboBoxSelectedSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectedSubject.TabIndex = 5;
            // 
            // ViewVisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 402);
            this.Controls.Add(this.comboBoxSelectedSubject);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonViewVisiting);
            this.Controls.Add(this.dataGridViewViewVisiting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewVisitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLDiary - View Visiting";
            this.Load += new System.EventHandler(this.ViewVisitingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewViewVisiting;
        private System.Windows.Forms.Button buttonViewVisiting;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.ComboBox comboBoxSelectedSubject;
    }
}