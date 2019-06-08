namespace GLDiary
{
    partial class VisitingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitingForm));
            this.dataGridViewVisiting = new System.Windows.Forms.DataGridView();
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxSelectPair = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiting)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisiting
            // 
            this.dataGridViewVisiting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewVisiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVisiting.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVisiting.Location = new System.Drawing.Point(39, 12);
            this.dataGridViewVisiting.Name = "dataGridViewVisiting";
            this.dataGridViewVisiting.Size = new System.Drawing.Size(390, 312);
            this.dataGridViewVisiting.TabIndex = 0;
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
            this.buttonQuitToMenu.TabIndex = 1;
            this.buttonQuitToMenu.UseVisualStyleBackColor = false;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdate.Location = new System.Drawing.Point(492, 275);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(103, 26);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(467, 12);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.LightSteelBlue;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // comboBoxSelectPair
            // 
            this.comboBoxSelectPair.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBoxSelectPair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectPair.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSelectPair.FormattingEnabled = true;
            this.comboBoxSelectPair.Location = new System.Drawing.Point(492, 201);
            this.comboBoxSelectPair.Name = "comboBoxSelectPair";
            this.comboBoxSelectPair.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectPair.TabIndex = 4;
            this.comboBoxSelectPair.UseWaitCursor = true;
            // 
            // VisitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 342);
            this.Controls.Add(this.comboBoxSelectPair);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Controls.Add(this.dataGridViewVisiting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLDiary - Visiting";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisiting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisiting;
        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxSelectPair;
    }
}