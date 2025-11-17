using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrud
{
    public partial class fmDialog : Form
    {
        string mode = "";
        string id = "";

        public fmDialog(string mode, string id)
        {
            InitializeComponent();
            this.mode = mode;
            this.id = id;
            if (mode == "edit")
            {                
                var model = DB.pGetStudentById(id);
                tbFname.Text = model.fname;
                tbLname.Text = model.lname;
                dtBirthDate.Value = model.birthdate;
                cbGender.SelectedIndex = Convert.ToInt32(model.gender);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                DB.pStudentAddOrEdit(new StudentAddOrEditModel
                {
                    id = "0",
                    birthdate = dtBirthDate.Value,
                    fname = tbFname.Text,
                    lname = tbLname.Text,
                    gender = cbGender.SelectedIndex.ToString()
                });
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
