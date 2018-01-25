using EntitySampleWFA.Source.BO;
using EntitySampleWFA.Source.Views.ViewsBO;
using System;
using System.Windows.Forms;

namespace EntitySampleWFA.Source.Views.ViewsList
{
    public partial class FrmTeacherList : Form
    {
        SchoolManager schoolMan = null;
        public FrmTeacherList()
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
            AddSt();
        }

        void AddSt()
        {
            try
            {
                FrmTeacher frmTch = new FrmTeacher();
                frmTch.ShowDialog();
                LoadListToGrid();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSt();
        }

        void UpdateSt()
        {
            try
            {
                if (grdVwTeachers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }
                string strId = string.Format("{0}", grdVwTeachers.SelectedRows[0].Cells[0].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    FrmTeacher frmSt = new FrmTeacher(id);
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
            DeleteSt();
        }

        void DeleteSt()
        {
            try
            {

                if (grdVwTeachers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }

                if (MessageBox.Show("Teacher will be deleted. Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                {
                    return;
                }


                string strId = string.Format("{0}", grdVwTeachers.SelectedRows[0].Cells["Id"].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    bool isInUse = schoolMan.IsTeacherNotInUse(id);
                    if (isInUse == false)
                    {
                        if (MessageBox.Show("Teacher is in use. Are you sure to delete Standard?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                        {
                            return;
                        }
                        schoolMan.DeleteTeacher(id);
                    }
                    else
                    {
                        schoolMan.DeleteTeacher(id);
                    }
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
            grdVwTeachers.DataSource = null;
            grdVwTeachers.DataSource = schoolMan.AllTeachers();
            grdVwTeachers.Refresh();
        }
    }
}
