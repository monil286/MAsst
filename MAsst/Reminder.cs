using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MAsst
{
    public partial class Reminder : Form
    {
        public String FName, REmail;
        public long RNo;
        public List<string> ShpngLst, TLst;
        public int st;
        public static string[] carr;
        public static int ind;
        public static string receipt;
        
        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            carr = new string[50];
            CmBxList.Items.Add("Message");
            CmBxList.Items.Add("Email");
            CmBxList.Items.Add("Email and Message");
            

            CmBxCar.Items.Add("AirFire");
            carr[0] = "@sms.airfiremobile.com";
            CmBxCar.Items.Add("Aio Wireless");
            carr[1] = "@mms.aiowireless.net";
            CmBxCar.Items.Add("Alaska Communications");
            carr[2] = "@msg.acsalaska.com";
            CmBxCar.Items.Add("Alltel");
            carr[3] = "@sms.alltelwireless.com";
            CmBxCar.Items.Add("Verizon Wireless");
            carr[4] = "@vtext.com";
            CmBxCar.Items.Add("Ameritech");
            carr[5] = "@paging.acswireless.com";
            CmBxCar.Items.Add("AT&T - Cellular");
            carr[6] = "@txt.att.net";
            CmBxCar.Items.Add("AT&T - Pager");
            carr[7] = "@page.att.net";
            CmBxCar.Items.Add("Bellsouth");
            carr[8] = "@bellsouth.cl";
            CmBxCar.Items.Add("Bluesky Communications - USA Samoa only");
            carr[9] = "@psms.bluesky.as";
            CmBxCar.Items.Add("Boost Mobile");
            carr[10] = "@sms.myboostmobile.com";
            CmBxCar.Items.Add("CellCom");
            carr[11] = "@cellcom.quiktxt.com";
            CmBxCar.Items.Add("Cellular South");
            carr[12] = "@csouth1.com";
            CmBxCar.Items.Add("Chat Mobility");
            carr[13] = "@mail.msgsender.com";
            CmBxCar.Items.Add("C Spire Wireless");
            carr[14] = "@cspire1.com";
            CmBxCar.Items.Add("DTC");
            carr[15] = "@sms.advantagecell.net";
            CmBxCar.Items.Add("Edge Wireless");
            carr[16] =  "@sms.edgewireless.com";
            CmBxCar.Items.Add("Element Mobile");
            carr[17] = "@SMS.elementmobile.net";
            CmBxCar.Items.Add("helio");
            carr[18] = "@myhelio.com";
            CmBxCar.Items.Add("I-Wireless (Sprint PCS) ");
            carr[19] = "@iwirelesshometext.com";
            CmBxCar.Items.Add("Kajeet");
            carr[20] = "@mobile.kajeet.net";
            CmBxCar.Items.Add("LongLines");
            carr[21] = "@text.longlines.com";
            CmBxCar.Items.Add("MetroPCS");
            carr[22] = "@mymetropcs.com";
            CmBxCar.Items.Add("NexTech");
            carr[23] = "@sms.ntwls.net";
            CmBxCar.Items.Add("Page Plus Cellular (Verizon) ");
            carr[24] = "@vtext.com";
            CmBxCar.Items.Add("Pioneer Cellular");
            carr[25] = "@zsend.com";
            CmBxCar.Items.Add("Quest Wireless");
            carr[26] = "@qwestmp.com";
            CmBxCar.Items.Add("Rogers Wireless");
            carr[27] = "@sms.rogers.com";
            CmBxCar.Items.Add("Simple Mobile");
            carr[28] = "@smtext.com";
            CmBxCar.Items.Add("Southernlinc");
            carr[29] = "@page.southernlinc.com";
            CmBxCar.Items.Add("South Central Communications");
            carr[30] = "@rinasms.com";
            CmBxCar.Items.Add("Sprint");
            carr[31] = "@messaging.sprintpcs.com";
            CmBxCar.Items.Add("Straight Talk");
            carr[32] = "@vtext.com";
            CmBxCar.Items.Add("T-Mobile");
            carr[33] = "@tmomail.net";
            CmBxCar.Items.Add("Teleflip");
            carr[34] = "@teleflip.com";
            CmBxCar.Items.Add("Telus Mobility");
            carr[35] = "@msg.telus.com";
            CmBxCar.Items.Add("Ting");
            carr[36] = "@message.ting.com";
            CmBxCar.Items.Add("Unicel");
            carr[37] = "@utext.com";
            CmBxCar.Items.Add("Union Wireless");
            carr[38] = "@union - tel.com";
            CmBxCar.Items.Add("US Cellular");
            carr[39] = "@email.uscc.net";
            CmBxCar.Items.Add("USA Mobility");
            carr[40] = "@usamobility.net";
            CmBxCar.Items.Add("Verizon Wireless");
            carr[41] = "@vtext.com";
            CmBxCar.Items.Add("Viaero");
            carr[42] = "@viaerosms.com";
            CmBxCar.Items.Add("Virgin Mobile");
            carr[43] = "@vmobl.com";
            CmBxCar.Items.Add("Voyager Mobile");
            carr[44] = "@text.voyagermobile.com";
            CmBxCar.Items.Add("West Central Wireless");
            carr[45] = "@sms.wcc.net";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void MsgOnly(string no, string nm, List<string> lst)
        {
            
            const string id = "MyAsstProg@gmail.com";
            const string pw = "Prog112016";
            string sub = "Reminder";
            string stc = "";

            if (st == 1)
            {
                stc = "Shopping";
            }
            else
            {
                stc = "Tasks";
            }
                string msg = "This is to remind you that you have the following " + stc + " to do : " + lst;
                try
                {
                //string carrier = carr[ind];
                receipt = String.Concat(no, carr[ind].ToString());
                    using (MailMessage txtMsg = new MailMessage(id, receipt, sub, msg))
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured - \n" + ex.Message);
                }
            MessageBox.Show("Message sent to " + TxtBxPhNo.Text.ToString());
        }
        
        public void EmailOnly(string email, string nm, List<string> lst)
        {
            string stc = "";
            if(st == 1)
            {
                stc = "Shopping";
            }
            else
            {
                stc = "Tasks";
            }
            String re = TxtBxEmail.Text.ToString();
            var fromAdd = new MailAddress("MyAsstProg@gmail.com", "My Personal Assistant");
            var toAdd = new MailAddress(re);
            string pwd = "Prog112016";
            string sub = "Reminder";
            string msg = "Hi " + nm + ",\n\nThis is an autogenerated email to remind you that you have the following " + stc + " to do \n" + lst;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAdd.Address, pwd)
            };
            using (var message = new MailMessage(fromAdd, toAdd)
            {
                Subject = sub,
                Body = msg
            })
            {
                smtp.Send(message);
            }
            MessageBox.Show("Email sent to " + re);
        }

        private void BtnReminder_Click(object sender, EventArgs e)
        {
            Reminder r = new Reminder();
            if(CmBxList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a mode of reminding you.");
                CmBxList.Focus();
            }
            else if(CmBxList.SelectedIndex == 0)
            {
                if (TxtBxPhNo.Text == null || TxtBxPhNo.Text == "")
                {
                    MessageBox.Show("Please enter your cellphone number to send a message to");
                    TxtBxPhNo.Focus();
                }
                else if (TxtBxPhNo.Text.Length != 10)
                {
                    MessageBox.Show("Invalid Phone number. Please try again");
                    TxtBxPhNo.Focus();
                }
                else
                {
                    if (st == 1)
                    {
                        r.MsgOnly(TxtBxPhNo.Text.ToString() , FName, ShpngLst);
                    }
                    else
                    {
                        r.MsgOnly(TxtBxPhNo.Text.ToString(), FName, TLst);
                    }
                }
            }
            else if (CmBxList.SelectedIndex == 1)
            {
                if(TxtBxEmail.Text == "" || TxtBxEmail.Text == null)
                {
                    MessageBox.Show("Please enter your email id.");
                    TxtBxEmail.Focus();
                }
                else if(!TxtBxEmail.Text.Contains("@") && !TxtBxEmail.Text.Contains("."))
                {
                    MessageBox.Show("Invalid Email id. Please try again.");
                    TxtBxEmail.Focus();
                }
                else
                {
                    if (st == 1)
                    {
                        r.EmailOnly(TxtBxEmail.Text.ToString() , FName, ShpngLst);
                    }
                    else
                    {
                        r.EmailOnly(TxtBxEmail.Text.ToString(), FName, TLst);
                    }
                }
            }
            else if (CmBxList.SelectedIndex == 2)
            {
                if (st == 1)
                {
                    r.EmailAndMsg(TxtBxEmail.Text.ToString(), TxtBxPhNo.Text.ToString(), FName, ShpngLst);
                }
                else
                {
                    r.EmailAndMsg(TxtBxEmail.Text.ToString(), TxtBxPhNo.Text.ToString(), FName, TLst);
                }

            }
        }

        private void CmBxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmBxList.SelectedIndex == 0)
            {
                LblNo.Visible = true;
                LblCarrier.Visible = true;
                TxtBxPhNo.Visible = true;
                CmBxCar.Visible = true;
                
            }
            else if(CmBxList.SelectedIndex == 1)
            {
                LblEmail.Visible = true;
                TxtBxEmail.Visible = true;
                
            }
            else if(CmBxList.SelectedIndex == 2)
            {
                LblNo.Visible = true;
                LblCarrier.Visible = true;
                TxtBxPhNo.Visible = true;
                CmBxCar.Visible = true;
                LblEmail.Visible = true;
                TxtBxEmail.Visible = true;
                
            }
        }

        private void CmBxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ind = CmBxCar.SelectedIndex;
        }

        public void EmailAndMsg(string email, string no, string nm, List<string> lst)
        {
            Reminder r = new Reminder();
            r.MsgOnly(no, nm, lst);
            r.EmailOnly(email, nm, lst);
            MessageBox.Show("Email sent to " + TxtBxEmail.Text.ToString() + "\nMessage sent to " + TxtBxPhNo.Text.ToString());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
