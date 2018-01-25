namespace EntitySampleWFA.Source.Views.ViewsList
{
    partial class FrmStudentList
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
            this.grdVwStudents = new System.Windows.Forms.DataGridView();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwStudents)).BeginInit();
            this.tblLytMain.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVwStudents
            // 
            this.grdVwStudents.AllowUserToAddRows = false;
            this.grdVwStudents.AllowUserToDeleteRows = false;
            this.grdVwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVwStudents.Location = new System.Drawing.Point(5, 5);
            this.grdVwStudents.Margin = new System.Windows.Forms.Padding(5);
            this.grdVwStudents.MultiSelect = false;
            this.grdVwStudents.Name = "grdVwStudents";
            this.grdVwStudents.ReadOnly = true;
            this.grdVwStudents.RowHeadersVisible = false;
            this.grdVwStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwStudents.Size = new System.Drawing.Size(741, 483);
            this.grdVwStudents.TabIndex = 0;
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdVwStudents, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblLytMain.Size = new System.Drawing.Size(751, 598);
            this.tblLytMain.TabIndex = 2;
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 3;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblLytButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tblLytButtons.Controls.Add(this.btnUpdate, 1, 0);
            this.tblLytButtons.Controls.Add(this.btnDelete, 2, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(5, 498);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(741, 95);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(39, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 61);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(285, 17);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 61);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(531, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 61);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 598);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)(this.grdVwStudents)).EndInit();
            this.tblLytMain.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVwStudents;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}