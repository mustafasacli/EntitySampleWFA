namespace EntitySampleWFA.Source.Views.ViewsBO
{
    partial class FrmStandard
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
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLytProps = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tblLytMain.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tblLytProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytProps, 0, 0);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.Size = new System.Drawing.Size(370, 148);
            this.tblLytMain.TabIndex = 1;
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 3;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLytButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tblLytButtons.Controls.Add(this.btnSave, 1, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(4, 72);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(362, 72);
            this.tblLytButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancel.Location = new System.Drawing.Point(258, 14);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.Location = new System.Drawing.Point(98, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblLytProps
            // 
            this.tblLytProps.ColumnCount = 2;
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLytProps.Controls.Add(this.lblName, 0, 0);
            this.tblLytProps.Controls.Add(this.txtName, 1, 0);
            this.tblLytProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytProps.Location = new System.Drawing.Point(3, 3);
            this.tblLytProps.Name = "tblLytProps";
            this.tblLytProps.RowCount = 1;
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytProps.Size = new System.Drawing.Size(364, 62);
            this.tblLytProps.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblName.Location = new System.Drawing.Point(10, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtName.Location = new System.Drawing.Point(148, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FrmStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 148);
            this.Controls.Add(this.tblLytMain);
            this.Name = "FrmStandard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard";
            this.tblLytMain.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytProps.ResumeLayout(false);
            this.tblLytProps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tblLytMain;
        public System.Windows.Forms.TableLayoutPanel tblLytButtons;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tblLytProps;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}