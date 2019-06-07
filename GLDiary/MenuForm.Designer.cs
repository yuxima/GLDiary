namespace GLDiary
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.buttonInfAboutStudents = new System.Windows.Forms.Button();
            this.buttonCheckVisiting = new System.Windows.Forms.Button();
            this.buttonSheduleOfCalls = new System.Windows.Forms.Button();
            this.buttonPairsShedule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonViewVisiting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfAboutStudents
            // 
            this.buttonInfAboutStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfAboutStudents.AutoSize = true;
            this.buttonInfAboutStudents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInfAboutStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfAboutStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInfAboutStudents.Location = new System.Drawing.Point(334, 292);
            this.buttonInfAboutStudents.Name = "buttonInfAboutStudents";
            this.buttonInfAboutStudents.Size = new System.Drawing.Size(149, 42);
            this.buttonInfAboutStudents.TabIndex = 0;
            this.buttonInfAboutStudents.Text = "Information about students";
            this.buttonInfAboutStudents.UseVisualStyleBackColor = false;
            this.buttonInfAboutStudents.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCheckVisiting
            // 
            this.buttonCheckVisiting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckVisiting.AutoSize = true;
            this.buttonCheckVisiting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCheckVisiting.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheckVisiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckVisiting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheckVisiting.Location = new System.Drawing.Point(334, 148);
            this.buttonCheckVisiting.Name = "buttonCheckVisiting";
            this.buttonCheckVisiting.Size = new System.Drawing.Size(149, 42);
            this.buttonCheckVisiting.TabIndex = 1;
            this.buttonCheckVisiting.Text = "Check visiting";
            this.buttonCheckVisiting.UseVisualStyleBackColor = false;
            this.buttonCheckVisiting.Click += new System.EventHandler(this.buttonCheckVisiting_Click);
            // 
            // buttonSheduleOfCalls
            // 
            this.buttonSheduleOfCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSheduleOfCalls.AutoSize = true;
            this.buttonSheduleOfCalls.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSheduleOfCalls.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSheduleOfCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSheduleOfCalls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSheduleOfCalls.Location = new System.Drawing.Point(334, 244);
            this.buttonSheduleOfCalls.Name = "buttonSheduleOfCalls";
            this.buttonSheduleOfCalls.Size = new System.Drawing.Size(149, 42);
            this.buttonSheduleOfCalls.TabIndex = 2;
            this.buttonSheduleOfCalls.Text = "Calls shedule";
            this.buttonSheduleOfCalls.UseVisualStyleBackColor = false;
            this.buttonSheduleOfCalls.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPairsShedule
            // 
            this.buttonPairsShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPairsShedule.AutoSize = true;
            this.buttonPairsShedule.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPairsShedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPairsShedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPairsShedule.Location = new System.Drawing.Point(334, 196);
            this.buttonPairsShedule.Name = "buttonPairsShedule";
            this.buttonPairsShedule.Size = new System.Drawing.Size(149, 42);
            this.buttonPairsShedule.TabIndex = 3;
            this.buttonPairsShedule.Text = "Pairs shedule";
            this.buttonPairsShedule.UseVisualStyleBackColor = false;
            this.buttonPairsShedule.Click += new System.EventHandler(this.buttonPairsShedule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.ForeColor = System.Drawing.Color.Black;
            this.buttonInfo.Location = new System.Drawing.Point(750, 12);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(38, 35);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonViewVisiting
            // 
            this.buttonViewVisiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewVisiting.AutoSize = true;
            this.buttonViewVisiting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonViewVisiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewVisiting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewVisiting.Location = new System.Drawing.Point(334, 340);
            this.buttonViewVisiting.Name = "buttonViewVisiting";
            this.buttonViewVisiting.Size = new System.Drawing.Size(149, 42);
            this.buttonViewVisiting.TabIndex = 6;
            this.buttonViewVisiting.Text = "View visiting";
            this.buttonViewVisiting.UseVisualStyleBackColor = false;
            this.buttonViewVisiting.Click += new System.EventHandler(this.buttonViewVisiting_Click);
            // 
            // MenuForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewVisiting);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPairsShedule);
            this.Controls.Add(this.buttonSheduleOfCalls);
            this.Controls.Add(this.buttonCheckVisiting);
            this.Controls.Add(this.buttonInfAboutStudents);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLDiary";
            this.toolTip1.SetToolTip(this, "Click for checking visited students");
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInfAboutStudents;
        private System.Windows.Forms.Button buttonCheckVisiting;
        private System.Windows.Forms.Button buttonSheduleOfCalls;
        private System.Windows.Forms.Button buttonPairsShedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonViewVisiting;
    }
}

