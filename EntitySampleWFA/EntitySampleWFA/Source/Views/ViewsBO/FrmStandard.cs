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
    public partial class FrmStandard : Form
    {
        SchoolManager schoolMan = null;
        Standard _standard = null;
        bool isFormLoaded = false;
        private int _id = -1;

        public FrmStandard() : this(-1) { }
        public FrmStandard(int Id)
        {
            try
            {
                InitializeComponent();
                schoolMan = new SchoolManager();
                _standard = new Standard();
                _id = Id;
                if (_id != -1)
                {
                    _standard = schoolMan.GetStandardById(_id);
                    txtName.Text = _standard.Name;
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                _standard = new Standard();
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
                if (isFormLoaded && _standard != null)
                {
                    if (_standard.Name.Length < 10 || _standard.Name.Length > 100)
                    {
                        MessageBox.Show("Standart Name character should be between 10 and 100.");
                        return;
                    }

                    if (_id == -1)
                    {
                        schoolMan.AddStandard(_standard);
                    }
                    else
                    {
                        schoolMan.UpdateStandard(_standard);
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
                if (_standard != null)
                {
                    _standard.Name = txtName.Text;
                }
            }
        }
    }
}
