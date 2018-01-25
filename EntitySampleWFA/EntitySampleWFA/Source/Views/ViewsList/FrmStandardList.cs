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
    public partial class FrmStandardList : Form
    {
        SchoolManager schoolMan = null;

        public FrmStandardList()
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
                FrmStandard frmSt = new FrmStandard();
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
            UpdateSt();
        }

        void UpdateSt()
        {
            try
            {
                if (grdVwStandarts.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }
                string strId = string.Format("{0}", grdVwStandarts.SelectedRows[0].Cells[0].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    FrmStandard frmSt = new FrmStandard(id);
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

                if (grdVwStandarts.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select a row.");
                    return;
                }

                if (MessageBox.Show("Standard will be deleted. Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                {
                    return;
                }


                string strId = string.Format("{0}", grdVwStandarts.SelectedRows[0].Cells["Id"].Value);
                int id;
                if (int.TryParse(strId, out id))
                {
                    bool isInUse = schoolMan.IsStandardInNotUse(id);
                    if (isInUse == false)
                    {
                        if (MessageBox.Show("Standard is in use. Are you sure to delete Standard?", "Confirm", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                        {
                            return;
                        }
                        schoolMan.DeleteStandard(id);
                    }
                    else
                    {
                        schoolMan.DeleteStandard(id);
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
            grdVwStandarts.DataSource = null;
            grdVwStandarts.DataSource = schoolMan.AllStandarts();
            grdVwStandarts.Refresh();
        }
    }
}
