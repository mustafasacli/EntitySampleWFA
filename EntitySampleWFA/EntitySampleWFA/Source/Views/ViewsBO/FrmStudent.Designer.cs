namespace EntitySampleWFA.Source.Views.ViewsBO
{
    partial class FrmStudent
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
            this.tblLytProps = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.cmbxTeacher = new System.Windows.Forms.ComboBox();
            this.cmbxStandard = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLytPhoto = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytPhotoButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.pcbxPhoto = new System.Windows.Forms.PictureBox();
            this.tblLytProps.SuspendLayout();
            this.tblLytMain.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tblLytPhoto.SuspendLayout();
            this.tblLytPhotoButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLytProps
            // 
            this.tblLytProps.ColumnCount = 2;
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLytProps.Controls.Add(this.lblName, 0, 0);
            this.tblLytProps.Controls.Add(this.txtName, 1, 0);
            this.tblLytProps.Controls.Add(this.label1, 0, 1);
            this.tblLytProps.Controls.Add(this.label2, 0, 2);
            this.tblLytProps.Controls.Add(this.label3, 0, 3);
            this.tblLytProps.Controls.Add(this.label4, 0, 4);
            this.tblLytProps.Controls.Add(this.label5, 0, 5);
            this.tblLytProps.Controls.Add(this.label6, 0, 6);
            this.tblLytProps.Controls.Add(this.txtHeight, 1, 2);
            this.tblLytProps.Controls.Add(this.txtWeight, 1, 3);
            this.tblLytProps.Controls.Add(this.cmbxTeacher, 1, 5);
            this.tblLytProps.Controls.Add(this.cmbxStandard, 1, 6);
            this.tblLytProps.Controls.Add(this.dtpBirth, 1, 1);
            this.tblLytProps.Controls.Add(this.tblLytPhoto, 1, 4);
            this.tblLytProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytProps.Location = new System.Drawing.Point(4, 4);
            this.tblLytProps.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytProps.Name = "tblLytProps";
            this.tblLytProps.RowCount = 7;
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLytProps.Size = new System.Drawing.Size(411, 392);
            this.tblLytProps.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblName.Location = new System.Drawing.Point(13, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtName.Location = new System.Drawing.Point(168, 8);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birth Date :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Photo :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(13, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Teacher :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(13, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Standard :";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtHeight.Location = new System.Drawing.Point(168, 86);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(239, 23);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtWeight.Location = new System.Drawing.Point(168, 125);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(239, 23);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // cmbxTeacher
            // 
            this.cmbxTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbxTeacher.FormattingEnabled = true;
            this.cmbxTeacher.Location = new System.Drawing.Point(168, 319);
            this.cmbxTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxTeacher.Name = "cmbxTeacher";
            this.cmbxTeacher.Size = new System.Drawing.Size(239, 25);
            this.cmbxTeacher.TabIndex = 2;
            this.cmbxTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbxTeacher_SelectedIndexChanged);
            // 
            // cmbxStandard
            // 
            this.cmbxStandard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbxStandard.FormattingEnabled = true;
            this.cmbxStandard.Location = new System.Drawing.Point(168, 359);
            this.cmbxStandard.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxStandard.Name = "cmbxStandard";
            this.cmbxStandard.Size = new System.Drawing.Size(239, 25);
            this.cmbxStandard.TabIndex = 2;
            this.cmbxStandard.SelectedIndexChanged += new System.EventHandler(this.cmbxStandard_SelectedIndexChanged);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(168, 47);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(239, 23);
            this.dtpBirth.TabIndex = 3;
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytProps, 0, 0);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.Size = new System.Drawing.Size(419, 480);
            this.tblLytMain.TabIndex = 3;
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 3;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tblLytButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tblLytButtons.Controls.Add(this.btnSave, 1, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(5, 405);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(5);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(409, 70);
            this.tblLytButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancel.Location = new System.Drawing.Point(271, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 56);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.Location = new System.Drawing.Point(58, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 56);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblLytPhoto
            // 
            this.tblLytPhoto.ColumnCount = 1;
            this.tblLytPhoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPhoto.Controls.Add(this.tblLytPhotoButtons, 0, 1);
            this.tblLytPhoto.Controls.Add(this.pcbxPhoto, 0, 0);
            this.tblLytPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPhoto.Location = new System.Drawing.Point(167, 159);
            this.tblLytPhoto.Name = "tblLytPhoto";
            this.tblLytPhoto.RowCount = 2;
            this.tblLytPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytPhoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLytPhoto.Size = new System.Drawing.Size(241, 150);
            this.tblLytPhoto.TabIndex = 4;
            // 
            // tblLytPhotoButtons
            // 
            this.tblLytPhotoButtons.ColumnCount = 2;
            this.tblLytPhotoButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPhotoButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPhotoButtons.Controls.Add(this.btnClearImage, 1, 0);
            this.tblLytPhotoButtons.Controls.Add(this.btnBrowseImage, 0, 0);
            this.tblLytPhotoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPhotoButtons.Location = new System.Drawing.Point(3, 113);
            this.tblLytPhotoButtons.Name = "tblLytPhotoButtons";
            this.tblLytPhotoButtons.RowCount = 1;
            this.tblLytPhotoButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPhotoButtons.Size = new System.Drawing.Size(235, 34);
            this.tblLytPhotoButtons.TabIndex = 0;
            // 
            // btnClearImage
            // 
            this.btnClearImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearImage.Location = new System.Drawing.Point(131, 3);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(89, 28);
            this.btnClearImage.TabIndex = 0;
            this.btnClearImage.Text = "Clear";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseImage.Location = new System.Drawing.Point(17, 3);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(82, 28);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // pcbxPhoto
            // 
            this.pcbxPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbxPhoto.Location = new System.Drawing.Point(18, 3);
            this.pcbxPhoto.Name = "pcbxPhoto";
            this.pcbxPhoto.Size = new System.Drawing.Size(204, 104);
            this.pcbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxPhoto.TabIndex = 1;
            this.pcbxPhoto.TabStop = false;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 480);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.tblLytProps.ResumeLayout(false);
            this.tblLytProps.PerformLayout();
            this.tblLytMain.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytPhoto.ResumeLayout(false);
            this.tblLytPhotoButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytProps;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TableLayoutPanel tblLytMain;
        public System.Windows.Forms.TableLayoutPanel tblLytButtons;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cmbxTeacher;
        private System.Windows.Forms.ComboBox cmbxStandard;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TableLayoutPanel tblLytPhoto;
        private System.Windows.Forms.TableLayoutPanel tblLytPhotoButtons;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox pcbxPhoto;
    }
}