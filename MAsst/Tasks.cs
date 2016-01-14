using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace MAsst
{
    public partial class Tasks : Form
    {

        public String Uname, dt, Fname;
        
        public Tasks()
        {
            InitializeComponent();
        }

        private void BtnSndTxt_Click(object sender, EventArgs e)
        {
            string msg = TxtBoxSMS.Text.ToString();
            const string id = "monilw286@gmail.com";
            const string pw = "HorizonPass123";
            string sub = "";
            string recepient = "7147264261@tmomail.net";
            try
            {
                using (MailMessage txtMsg = new MailMessage(id, recepient, sub, msg))
                {
                    using (SmtpClient msgClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        msgClient.UseDefaultCredentials = false;
                        msgClient.EnableSsl = true;
                        msgClient.Credentials = new System.Net.NetworkCredential(id, pw);
                        msgClient.Port = 587;
                        msgClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        msgClient.Send(txtMsg);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured - \n" + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            String FileName = Directory.GetCurrentDirectory() + "\\" + Uname + "-Tasks-" + dt + ".txt";


            if(!File.Exists(FileName))
            {
                ChLsBxTaskList.Items.Clear();
                MessageBox.Show("You have no tasks for " + dt);
            }
            else
            {
                String[] Tasks = System.IO.File.ReadAllLines(FileName);
                int l = Tasks.Length;
                int j;
                for(int i=0; i< l; i++)
                {
                    j = Tasks[i].Length - 5;
                    ChLsBxTaskList.Items.Add(Tasks[i].Substring(5, (Tasks[i].Length-5)));
                    if (Tasks[i].Substring(0, 2) == "cd")
                    {
                        ChLsBxTaskList.SetItemCheckState(i, CheckState.Checked);
                    }
                    else if(Tasks[i].Substring(0, 2) == "ip")
                    {
                        ChLsBxTaskList.SetItemCheckState(i, CheckState.Indeterminate);
                    }
                    else if(Tasks[i].Substring(0, 2) == "uc")
                    {
                        ChLsBxTaskList.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private void TxtBoxAddTask_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnAddTsk_Click(object sender, EventArgs e)
        {
            String tk = TxtBoxAddTask.Text.ToString();
            if (tk == null || tk == "")
            {
                MessageBox.Show("Please enter the name of the task to be added to your list.");
            }
            else
            {
                try
                {
                    String FileName = Directory.GetCurrentDirectory() + Uname + "-Tasks-" + dt + ".txt";
                    ChLsBxTaskList.Items.Add(tk);
                    int i = ChLsBxTaskList.Items.IndexOf(tk);
                    ChLsBxTaskList.SetItemCheckState(i, CheckState.Unchecked);
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(FileName, true);
                    sw.WriteLine("uc - " + tk);
                    TxtBoxAddTask.Clear();
                    //sw.Close();
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message + " Occurred");
                }
            }
        }

        private void BtnTIP_Click(object sender, EventArgs e)
        {
            int tk = ChLsBxTaskList.SelectedIndex;
            if (tk == -1)
            {
                MessageBox.Show("No task selected. Please select a task and try again.");
                ChLsBxTaskList.Focus();
            }
            else
            {
                String FileName = Directory.GetCurrentDirectory() + Uname + "-Tasks-" + dt + ".txt";
                ChLsBxTaskList.SetItemCheckState(tk, CheckState.Indeterminate);
                String[] list = System.IO.File.ReadAllLines(FileName);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FileName);
                for(int i=0; i<list.Length; i++)
                {

                    if(i == tk)
                    {
                        sw.WriteLine("ip - " + list[i].Substring(5, (list[i].Length-5)).ToString());
                    }
                    else
                    {
                        sw.WriteLine(list[i].ToString());
                    }
                }
                sw.Close();
            }
        }

        private void BtnTskComp_Click(object sender, EventArgs e)
        {
            int tk = ChLsBxTaskList.SelectedIndex;
            if (tk == -1)
            {
                MessageBox.Show("No task selected. Please select a task and try again.");
                ChLsBxTaskList.Focus();
            }
            else
            {
                String FileName = Directory.GetCurrentDirectory() + Uname + "-Tasks-" + dt + ".txt";
                ChLsBxTaskList.SetItemCheckState(tk, CheckState.Checked);
                String[] list = System.IO.File.ReadAllLines(FileName);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FileName);
                for (int i = 0; i < list.Length; i++)
                {

                    if (i == tk)
                    {
                        sw.WriteLine("cd - " + list[i].Substring(5, (list[i].Length-5)).ToString());
                    }
                    else
                    {
                        sw.WriteLine(list[i].ToString());
                    }
                }
                sw.Close();
            }
        }

        private void BtnTskIr_Click(object sender, EventArgs e)
        {
            int tk = ChLsBxTaskList.SelectedIndex;
            if (tk == -1)
            {
                MessageBox.Show("No task selected. Please select a task and try again.");
                ChLsBxTaskList.Focus();
            }
            else
            {
                String FileName = Directory.GetCurrentDirectory() + Uname + "-Tasks-" + dt + ".txt";
                ChLsBxTaskList.Items.RemoveAt(tk);
                String[] list = System.IO.File.ReadAllLines(FileName);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(FileName);
                for (int i = 0; i < list.Length; i++)
                {

                    if (i == tk)
                    {
                    }
                    else
                    {
                        sw.WriteLine(list[i].ToString());
                    }
                }
                sw.Close();
            }
        }

        private void BtnRemind_Click(object sender, EventArgs e)
        {
            Reminder r = new Reminder();
            r.st = 2;
            r.FName = Fname;
            List<string> lst = new List<string>();
            if(ChLsBxTaskList.SelectedIndices == null )
            {
                MessageBox.Show("No tasks selected to set reminder. Please select one or more tasks");
                ChLsBxTaskList.Focus();
            }
            else
            {
                int i;
                for(i = 0; i< ChLsBxTaskList.SelectedItems.Count;i++)
                {
                    lst.Add(ChLsBxTaskList.SelectedItems.IndexOf(i).ToString());
                }
            }
            r.TLst = lst;
            r.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectAction sa = new SelectAction();
            sa.Show();
        }
    }
}
