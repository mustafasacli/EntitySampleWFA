using EntitySampleWFA.Source.Views.ViewsList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySampleWFA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStandardList_Click(object sender, EventArgs e)
        {
            FrmStandardList frmStandardLst = new FrmStandardList();
            frmStandardLst.ShowDialog();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            FrmTeacherList frmTeachers = new FrmTeacherList();
            frmTeachers.ShowDialog();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            FrmStudentList frmSt = new FrmStudentList();
            frmSt.ShowDialog();
        }
    }
}
