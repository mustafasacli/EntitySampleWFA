namespace EntitySampleWFA.Source.Views.ViewsList
{
    partial class FrmStandardList
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
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdVwStandarts = new System.Windows.Forms.DataGridView();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblLytMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwStandarts)).BeginInit();
            this.tblLytButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdVwStandarts, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.Size = new System.Drawing.Size(464, 401);
            this.tblLytMain.TabIndex = 0;
            // 
            // grdVwStandarts
            // 
            this.grdVwStandarts.AllowUserToAddRows = false;
            this.grdVwStandarts.AllowUserToDeleteRows = false;
            this.grdVwStandarts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwStandarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwStandarts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVwStandarts.Location = new System.Drawing.Point(4, 4);
            this.grdVwStandarts.Margin = new System.Windows.Forms.Padding(4);
            this.grdVwStandarts.MultiSelect = false;
            this.grdVwStandarts.Name = "grdVwStandarts";
            this.grdVwStandarts.ReadOnly = true;
            this.grdVwStandarts.RowHeadersVisible = false;
            this.grdVwStandarts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwStandarts.Size = new System.Drawing.Size(456, 313);
            this.grdVwStandarts.TabIndex = 0;
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
            this.tblLytButtons.Location = new System.Drawing.Point(4, 325);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(456, 72);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(8, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(159, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 47);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(311, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 47);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmStandardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 401);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(480, 440);
            this.MinimumSize = new System.Drawing.Size(480, 440);
            this.Name = "FrmStandardList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard List";
            this.tblLytMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVwStandarts)).EndInit();
            this.tblLytButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.DataGridView grdVwStandarts;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}