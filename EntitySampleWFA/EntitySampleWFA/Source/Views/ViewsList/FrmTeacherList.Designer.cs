namespace EntitySampleWFA.Source.Views.ViewsList
{
    partial class FrmTeacherList
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
            this.grdVwTeachers = new System.Windows.Forms.DataGridView();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwTeachers)).BeginInit();
            this.tblLytMain.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVwTeachers
            // 
            this.grdVwTeachers.AllowUserToAddRows = false;
            this.grdVwTeachers.AllowUserToDeleteRows = false;
            this.grdVwTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVwTeachers.Location = new System.Drawing.Point(5, 5);
            this.grdVwTeachers.Margin = new System.Windows.Forms.Padding(5);
            this.grdVwTeachers.MultiSelect = false;
            this.grdVwTeachers.Name = "grdVwTeachers";
            this.grdVwTeachers.ReadOnly = true;
            this.grdVwTeachers.RowHeadersVisible = false;
            this.grdVwTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwTeachers.Size = new System.Drawing.Size(537, 371);
            this.grdVwTeachers.TabIndex = 0;
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdVwTeachers, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tblLytMain.Size = new System.Drawing.Size(547, 486);
            this.tblLytMain.TabIndex = 1;
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
            this.tblLytButtons.Location = new System.Drawing.Point(5, 386);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(537, 95);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(5, 17);
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
            this.btnUpdate.Location = new System.Drawing.Point(183, 17);
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
            this.btnDelete.Location = new System.Drawing.Point(361, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 61);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmTeacherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 486);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher List";
            ((System.ComponentModel.ISupportInitialize)(this.grdVwTeachers)).EndInit();
            this.tblLytMain.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVwTeachers;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}