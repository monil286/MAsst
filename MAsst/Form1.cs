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
using System.IO;

namespace MAsst
{
    public partial class Home : Form
    {
        public String Uname;
        public String Pwd;
        public OleDbConnection conn;
        public OleDbCommand comm;
        public OleDbDataAdapter adapt;
        public OleDbDataReader reader;

        public Home()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReg_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registeration Page under Construction. Please try again later.");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection();
            try
            {
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Monil\\Documents\\Visual Studio 2015\\Projects\\MAsst\\LoginDB.accdb";
                conn.Open();
            }
            catch(Exception err)
            {
                MessageBox.Show("Error coonecting to DB - " + err.Message);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Uname = TxtBxUsrNm.Text.ToString();
            Pwd = TxtBxPwd.Text.ToString();
            if (Uname == null || Uname == "")
            {
                if (Pwd == null || Pwd == "")
                {
                    MessageBox.Show("Please Enter a value for Username and Password fields or Register yourself.");
                    TxtBxUsrNm.Focus();
                }
                else
                {
                    MessageBox.Show("Username Field cannot be blank. Please enter a value or register yourself.");
                    TxtBxUsrNm.Focus();
                }
            }
            else if (Pwd == null || Pwd == "")
            {
                MessageBox.Show("Password Field cannot be blank. Please enter a value or register yourself.");
                TxtBxPwd.Focus();
            }
            else
            {
                comm = new OleDbCommand("SELECT [UserName] FROM Login WHERE [UserName] = '" + Uname + "' AND Password = '" + Pwd + "';", conn);
                try
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        reader = comm.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            SelectAction sa = new SelectAction();
                            sa.UName = this.Uname;
                            sa.Pwd = this.Pwd;
                            this.Hide();
                            sa.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sorry. We did not find your records in our database. Please register again.");
                            AddUser au = new AddUser();
                            au.UName = this.Uname;
                            au.pwd = this.Pwd;
                            this.Close();
                            au.Show();
                        }
                        reader.Close();
                        conn.Close();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error at Data Retreival " + er.Message);
                    conn.Close();
                }
            }
        }
    }
}
