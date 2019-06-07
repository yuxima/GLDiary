namespace GLDiary
{
    partial class SheduleOfCallsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleOfCallsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.dataGridViewSheduleOfCalls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheduleOfCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuitToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuitToMenu.BackgroundImage")));
            this.buttonQuitToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQuitToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitToMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(30, 30);
            this.buttonQuitToMenu.TabIndex = 0;
            this.buttonQuitToMenu.UseVisualStyleBackColor = false;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // dataGridViewSheduleOfCalls
            // 
            this.dataGridViewSheduleOfCalls.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSheduleOfCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSheduleOfCalls.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSheduleOfCalls.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewSheduleOfCalls.Name = "dataGridViewSheduleOfCalls";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSheduleOfCalls.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSheduleOfCalls.Size = new System.Drawing.Size(343, 192);
            this.dataGridViewSheduleOfCalls.TabIndex = 1;
            // 
            // SheduleOfCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(369, 239);
            this.Controls.Add(this.dataGridViewSheduleOfCalls);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SheduleOfCallsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLDiary - Shedule of calls";
            this.Load += new System.EventHandler(this.SheduleOfCallsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheduleOfCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.DataGridView dataGridViewSheduleOfCalls;
    }
}