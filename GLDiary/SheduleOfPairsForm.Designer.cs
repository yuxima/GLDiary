namespace GLDiary
{
    partial class SheduleOfPairsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleOfPairsForm));
            this.buttonQuitToMenu = new System.Windows.Forms.Button();
            this.dataGridViewSheduleOfCalls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheduleOfCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuitToMenu
            // 
            this.buttonQuitToMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonQuitToMenu.Name = "buttonQuitToMenu";
            this.buttonQuitToMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitToMenu.TabIndex = 0;
            this.buttonQuitToMenu.Text = "Quit to menu";
            this.buttonQuitToMenu.UseVisualStyleBackColor = true;
            this.buttonQuitToMenu.Click += new System.EventHandler(this.buttonQuitToMenu_Click);
            // 
            // dataGridViewSheduleOfCalls
            // 
            this.dataGridViewSheduleOfCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSheduleOfCalls.Location = new System.Drawing.Point(220, 99);
            this.dataGridViewSheduleOfCalls.Name = "dataGridViewSheduleOfCalls";
            this.dataGridViewSheduleOfCalls.Size = new System.Drawing.Size(347, 174);
            this.dataGridViewSheduleOfCalls.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSheduleOfCalls);
            this.Controls.Add(this.buttonQuitToMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSheduleOfCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitToMenu;
        private System.Windows.Forms.DataGridView dataGridViewSheduleOfCalls;
    }
}