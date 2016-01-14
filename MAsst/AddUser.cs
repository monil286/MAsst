using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MAsst
{
    public partial class AddUser : Form
    {
        public String UName, pwd, repwd, fname, lname, eID, secq, seca;
        public OleDbConnection conn;
        public OleDbCommand comm;
        public OleDbDataAdapter adapt;
        public OleDbDataReader reader;
        public delegate void PasswordEvent(String Pass1, String Pass2);
        public event PasswordEvent PasswordVerify;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBxUName.Clear();
            TxtBxPwd.Clear();
            TxtBxRPwd.Clear();
            TxtBxFName.Clear();
            TxtBxLName.Clear();
            TxtBxEmail.Clear();
            TxtBxSecQ.Clear();
            TxtBxSecA.Clear();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            TxtBxUName.Text = this.UName;
            TxtBxPwd.Text = this.pwd;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = LoginDB.accdb";
                conn.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error : " + er.Message);
            }
            fname = TxtBxFName.Text.ToString();
            lname = TxtBxLName.Text.ToString();
            eID = TxtBxEmail.Text.ToString();
            secq = TxtBxSecQ.Text.ToString();
            seca = TxtBxSecA.Text.ToString();
            UName = TxtBxUName.Text.ToString();
            pwd = TxtBxPwd.Text.ToString();
        }

        public AddUser()
        {
            InitializeComponent();
            AddUser obj = new AddUser();
            obj.PasswordVerify += new PasswordEvent(RePasswordLoseFocus);
        }

        void RePasswordLoseFocus(String pass1, String pass2 )
        {
            if(TxtBxPwd.Text.ToString() != TxtBxRPwd.Text.ToString())
            {
                PwdLbl.Show();
                TxtBxRPwd.Clear();
                TxtBxRPwd.Focus();
            }
        }
    }
}
