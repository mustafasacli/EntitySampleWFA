using EntitySampleWFA.Source.BO;
using EntitySampleWFA.Source.Extensions;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EntitySampleWFA.Source.Views.ViewsBO
{
    public partial class FrmStudent : Form
    {
        SchoolManager schoolMan = null;
        Student _student = null;
        bool isFormLoaded = false;
        private int _id = -1;
        OpenFileDialog fileDialog = null;

        public FrmStudent()
            : this(-1)
        { }

        public FrmStudent(int Id)
        {
            try
            {
                InitializeComponent();
                schoolMan = new SchoolManager();
                _student = new Student();
                _id = Id;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                _student = new Student();
            }
        }

        void FormLoad()
        {
            try
            {
                cmbxStandard.DataSource = schoolMan.AllStandarts();
                cmbxStandard.ValueMember = "Id";
                cmbxStandard.DisplayMember = "Name";
                cmbxStandard.Refresh();
                cmbxStandard.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
            try
            {
                cmbxTeacher.DataSource = schoolMan.AllTeachers();
                cmbxTeacher.ValueMember = "Id";
                cmbxTeacher.DisplayMember = "Name";
                cmbxTeacher.Refresh();
                cmbxTeacher.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
            try
            {

                if (_id != -1)
                {
                    _student = schoolMan.GetStudentById(_id);
                    txtName.Text = _student.Name;
                    txtHeight.Text = _student.Height.ToStr();
                    txtWeight.Text = _student.Weight.ToStr();
                    if (_student.DateOfBirth.HasValue)
                    {
                        dtpBirth.Value = _student.DateOfBirth.Value;
                    }
                    cmbxStandard.SelectedValue = _student.StandardId;
                    cmbxTeacher.SelectedValue = _student.TeacherId;
                    if (_student.Photo != null)
                    {
                        Image im = Bitmap.FromStream(new System.IO.MemoryStream(_student.Photo, false));
                        pcbxPhoto.Image = im;
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                _student = new Student();
            }
            finally
            {
                isFormLoaded = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        void Save()
        {
            try
            {
                if (isFormLoaded && _student != null)
                {
                    if (_student.Name.Length < 10 || _student.Name.Length > 100)
                    {
                        MessageBox.Show("Standart Name character should be between 10 and 100.");
                        return;
                    }

                    if (_student.StandardId == 0)
                    {
                        MessageBox.Show("Standart can not be null or zero.");
                        return;
                    }

                    if (_student.TeacherId == 0)
                    {
                        MessageBox.Show("Teacher can not be null or zero.");
                        return;
                    }

                    if (_id == -1)
                    {
                        schoolMan.AddStudent(_student);
                    }
                    else
                    {
                        schoolMan.UpdateStudent(_student);
                    }

                }
                MessageBox.Show("Save Operation succeed.");
                btnSave.Enabled = false;
                btnCancel.Text = "Close";
                return;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                MessageBox.Show("Save Operation failed.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.Name = txtName.Text;
                }
            }
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.Height = txtHeight.Text.ToDecimal();
                }
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.Weight = txtWeight.Text.ToSingle();
                }
            }
        }

        private void cmbxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.TeacherId = cmbxTeacher.SelectedValue.ToInt();
                }
            }
        }

        private void cmbxStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.StandardId = cmbxStandard.SelectedValue.ToInt();
                }
            }
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {
                if (_student != null)
                {
                    _student.DateOfBirth = dtpBirth.Value;
                }
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            BrowseImg();
        }

        private void BrowseImg()
        {
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.Title = "Set Image";
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DialogResult dR = fileDialog.ShowDialog();
                if (dR == DialogResult.OK)
                {
                    Image im = Bitmap.FromFile(fileDialog.FileName);
                    pcbxPhoto.Image = im;
                    _student.Photo = File.ReadAllBytes(fileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                MessageBox.Show("Browse Image Operation failed.");
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            ClearImg();
        }

        private void ClearImg()
        {
            pcbxPhoto.Image = null;
            _student.Photo = null;
            pcbxPhoto.Refresh();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            FormLoad();
        }


    }
}
