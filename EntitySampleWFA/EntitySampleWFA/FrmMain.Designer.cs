namespace EntitySampleWFA
{
    partial class FrmMain
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
            this.btnStandardList = new System.Windows.Forms.Button();
            this.btnTeacherList = new System.Windows.Forms.Button();
            this.btnStudentList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStandardList
            // 
            this.btnStandardList.Location = new System.Drawing.Point(71, 75);
            this.btnStandardList.Margin = new System.Windows.Forms.Padding(4);
            this.btnStandardList.Name = "btnStandardList";
            this.btnStandardList.Size = new System.Drawing.Size(100, 30);
            this.btnStandardList.TabIndex = 0;
            this.btnStandardList.Text = "Standard List";
            this.btnStandardList.UseVisualStyleBackColor = true;
            this.btnStandardList.Click += new System.EventHandler(this.btnStandardList_Click);
            // 
            // btnTeacherList
            // 
            this.btnTeacherList.Location = new System.Drawing.Point(256, 75);
            this.btnTeacherList.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeacherList.Name = "btnTeacherList";
            this.btnTeacherList.Size = new System.Drawing.Size(100, 30);
            this.btnTeacherList.TabIndex = 0;
            this.btnTeacherList.Text = "Teacher List";
            this.btnTeacherList.UseVisualStyleBackColor = true;
            this.btnTeacherList.Click += new System.EventHandler(this.btnTeacherList_Click);
            // 
            // btnStudentList
            // 
            this.btnStudentList.Location = new System.Drawing.Point(409, 75);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(100, 30);
            this.btnStudentList.TabIndex = 1;
            this.btnStudentList.Text = "Student List";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 501);
            this.Controls.Add(this.btnStudentList);
            this.Controls.Add(this.btnTeacherList);
            this.Controls.Add(this.btnStandardList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStandardList;
        private System.Windows.Forms.Button btnTeacherList;
        private System.Windows.Forms.Button btnStudentList;
    }
}

