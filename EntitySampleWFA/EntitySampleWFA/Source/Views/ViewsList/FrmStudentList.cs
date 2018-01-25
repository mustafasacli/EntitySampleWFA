using EntitySampleWFA.Source.BO;
using EntitySampleWFA.Source.Views.ViewsBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySampleWFA.Source.Views.ViewsList
{
    public partial class FrmStudentList : Form
    {
        SchoolManager schoolMan = null;
        public FrmStudentList()
        {
            try
            {
                InitializeComponent();
                schoolMan = new SchoolManager();
                LoadListToGrid();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStu();
        }

        private void AddStu()
        {
            try
            {
                FrmStudent frmSt = new FrmStudent();
                frmSt.ShowDialog();
                LoadListToGrid();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStu();
        }

        void UpdateStu()
        {
            try
            {
                if (grdVwStudents.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }
                string strId = string.Format("{0}", grdVwStudents.SelectedRows[0].Cells[0].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    FrmStudent frmSt = new FrmStudent(id);
                    frmSt.ShowDialog();
                }
                LoadListToGrid();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStu();
        }
        void DeleteStu()
        {
            try
            {

                if (grdVwStudents.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }

                if (MessageBox.Show("Student will be deleted. Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                {
                    return;
                }


                string strId = string.Format("{0}", grdVwStudents.SelectedRows[0].Cells["Id"].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    schoolMan.DeleteStandard(id);
                    /*
                    bool isInUse = schoolMan.Is(id);
                    if (isInUse)
                    {
                        if (MessageBox.Show("Student is in use. Are you sure to delete Standard?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                        {
                            return;
                        }
                        schoolMan.DeleteStandard(id);
                    }
                    else
                    {
                        schoolMan.DeleteStandard(id);
                    }
                     * **/
                }
                MessageBox.Show("Delete Operation succeed.");
                LoadListToGrid();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                MessageBox.Show("Delete Operation failed.");
            }
        }


        void LoadListToGrid()
        {
            try
            {
                grdVwStudents.DataSource = null;
                grdVwStudents.DataSource = schoolMan.AllStudents();
                grdVwStudents.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
