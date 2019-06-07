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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisitingForm));
            this.dataGridViewViewVisiting = new System.Windows.Forms.DataGridView();
            this.buttonViewVisiting = new System.Windows.Forms.Button();
            this.textBoxChooseSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViewVisiting)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewViewVisiting
            // 
            this.dataGridViewViewVisiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViewVisiting.Location = new System.Drawing.Point(201, 92);
            this.dataGridViewViewVisiting.Name = "dataGridViewViewVisiting";
            this.dataGridViewViewVisiting.Size = new System.Drawing.Size(304, 199);
            this.dataGridViewViewVisiting.TabIndex = 0;
            // 
            // buttonViewVisiting
            // 
            this.buttonViewVisiting.Location = new System.Drawing.Point(317, 36);
            this.buttonViewVisiting.Name = "buttonViewVisiting";
            this.buttonViewVisiting.Size = new System.Drawing.Size(75, 23);
            this.buttonViewVisiting.TabIndex = 1;
            this.buttonViewVisiting.Text = "View";
            this.buttonViewVisiting.UseVisualStyleBackColor = true;
            this.buttonViewVisiting.Click += new System.EventHandler(this.buttonViewVisiting_Click);
            // 
            // textBoxChooseSubject
            // 
            this.textBoxChooseSubject.Location = new System.Drawing.Point(109, 38);
            this.textBoxChooseSubject.Name = "textBoxChooseSubject";
            this.textBoxChooseSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxChooseSubject.TabIndex = 2;
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
            // ViewVisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxChooseSubject);
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
        private System.Windows.Forms.TextBox textBoxChooseSubject;
        private System.Windows.Forms.Label labelSubject;
    }
}