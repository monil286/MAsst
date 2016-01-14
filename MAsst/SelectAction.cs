using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAsst
{
    public partial class SelectAction : Form
    {
        public String UName, Pwd;
        public SelectAction()
        {
            InitializeComponent();
        }

        private void SelectAction_Load(object sender, EventArgs e)
        {
            this.MoCal1.Visible = true;
            this.BtnDiary.Visible = true;
            this.BtnExpenseM.Visible = true;
            this.BtnGoal.Visible = true;
            this.BtnTaskM.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Logout Button Press Event
        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Close();
            hm.Show();
        }

        private void BtnTaskM_Click(object sender, EventArgs e)
        {
            this.Close();
            Tasks ts = new Tasks();
            ts.Uname = this.UName;
            String date = MoCal1.SelectionStart.ToString("MM-dd-yyyy");
            ts.dt = date;
            ts.Show();

        }

        private void BtnDiary_Click(object sender, EventArgs e)
        {
            Diary dr = new Diary();
            this.Close();
            dr.Show();
        }
    }
}
