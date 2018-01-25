using EntitySampleWFA.Source.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySampleWFA.Source.Views.ViewsBO
{
    public partial class FrmTeacher : Form
    {
        SchoolManager schoolMan = null;
        Teacher _teacher = null;
        bool isFormLoaded = false;
        private int _id = -1;

        public FrmTeacher()
            : this(-1)
        {
        }

        public FrmTeacher(int Id)
        {
            try
            {
                InitializeComponent();
                schoolMan = new SchoolManager();
                _teacher = new Teacher();
                _id = Id;
                if (_id != -1)
                {
                    _teacher = schoolMan.GetTeacherById(_id);
                    txtName.Text = _teacher.Name;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                _teacher = new Teacher();
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

        private void Save()
        {
            try
            {
                if (isFormLoaded && _teacher != null)
                {
                    if (_teacher.Name.Length < 10 || _teacher.Name.Length > 100)
                    {
                        MessageBox.Show("Teacher Name character should be between 10 and 100.");
                        return;
                    }

                    if (_id == -1)
                    {
                        schoolMan.AddTeacher(_teacher);
                    }
                    else
                    {
                        schoolMan.UpdateTeacher(_teacher);
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
                if (_teacher != null)
                {
                    _teacher.Name = txtName.Text;
                }
            }
        }
    }
}
