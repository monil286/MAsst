using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MAsst
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        //BtnCreate_Click Method
        private void button1_Click(object sender, EventArgs e)
        {
            LblDiary.Visible = true;
            LstBxDiaryEntry.Visible = false;
            TxtBxDiary.Visible = true;
            TxtBxDiary.Focus();
            BtnCreate.Visible = false;
            BtnDel.Visible = false;
            BtnEdit.Visible = false;
            BtnRead.Visible = false;
            BtnSave.Visible = true;
            BtnClear.Visible = true;
            BtnCancel.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Diary_Load(object sender, EventArgs e)
        {
            LstBxDiaryEntry.Items.Clear();
            int j, k;
            String dir = Directory.GetCurrentDirectory();
            String[] DiaryEntry = Directory.GetFiles( @dir, "Diary-*.txt");
            if (DiaryEntry.Length == 0)
            {
                LstBxDiaryEntry.Items.Add("<No Diary Entry. Click on 'Create New Entry' to Create a new Entry.>");
            }
            else
            {
                for (int i = 0; i < DiaryEntry.Length; i++)
                {
                    j = (DiaryEntry[i].Length - 14);
                    k = 10;
                    try
                    {
                        LstBxDiaryEntry.Items.Add(DiaryEntry[i].Substring(j, k));
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SelectAction sa = new SelectAction();
            this.Close();
            sa.Show();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBxDiary.Clear();
            TxtBxDiary.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LblDiary.Visible = false;
            LstBxDiaryEntry.Visible = true;
            TxtBxDiary.Visible = false;
            //TxtBxDiary.Focus();
            BtnCreate.Visible = true;
            BtnDel.Visible = true;
            BtnEdit.Visible = true;
            BtnRead.Visible = true;
            BtnSave.Visible = false;
            BtnClear.Visible = false;
            BtnCancel.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String dir = Directory.GetCurrentDirectory();
            String Filename = @dir + "\\Diary-" + DateTime.Now.ToString("MM-dd-yyyy") +".txt";
            if(File.Exists(Filename) == false)
            {
                System.IO.File.WriteAllText(Filename, TxtBxDiary.Text.ToString());
            }
            else
            {
                System.IO.StreamWriter objWriter = new System.IO.StreamWriter(Filename, true);
                objWriter.Write(TxtBxDiary.Text.ToString());
                objWriter.Close();
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (LstBxDiaryEntry.SelectedItem == null)
            {
                MessageBox.Show("Please select a diary entry to be read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String filename = Directory.GetCurrentDirectory() + "\\Diary-" + LstBxDiaryEntry.SelectedItem.ToString() + ".txt";
                String Content = System.IO.File.ReadAllText(filename);
                TxtBxDiary.Text = Content;
                LstBxDiaryEntry.Visible = false;
                TxtBxDiary.Visible = true;
                TxtBxDiary.ReadOnly = true;
                LblDiary.Visible = true;
                LblDate.Text = LstBxDiaryEntry.SelectedItem.ToString();
                LblDate.Visible = true;
                BtnCancel.Visible = false;
                BtnBack.Visible = false;
                BtnClear.Visible = false;
                BtnCreate.Visible = false;
                BtnExit.Visible = true;
                BtnRead.Visible = false;
                BtnSave.Visible = false;
                BtnEdit.Visible = true;
                BtnEdit.Location = new Point(10, 683);
                BtnDel.Visible = true;
                BtnDel.Location = new Point(275, 683);
                BtnBack1.Visible = true;
                BtnBack1.Location = new Point(540, 683);
                BtnExit.Visible = true;
                BtnExit.Location = new Point(805, 683);
            }
        }

        private void BtnBack1_Click_1(object sender, EventArgs e)
        {
            Diary d = new Diary();
            try
            {
                this.Dispose();
                this.Close();
                d.Show();
                d.Diary_Load(null, null);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            String fileName = Directory.GetCurrentDirectory() + "\\Diary-" + LstBxDiaryEntry.SelectedItem.ToString() + ".txt";
            File.Delete(fileName);
            Diary d = new Diary();
            try
            {
                this.Dispose();
                this.Close();
                d.Show();
                d.Diary_Load(null, null);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            String FileName = Directory.GetCurrentDirectory() + "\\Diary-" + LstBxDiaryEntry.SelectedItem.ToString() + ".txt";
            String Content = System.IO.File.ReadAllText(FileName);
            LblDate.Text = LstBxDiaryEntry.SelectedItem.ToString();
            LstBxDiaryEntry.Visible = false;
            LblDate.Visible = true;
            LblDiary.Visible = true;
            TxtBxDiary.Visible = true;
            TxtBxDiary.Text = Content;
            BtnBack.Visible = false;
            BtnBack1.Visible = true;
            BtnCancel.Visible = false;
            BtnClear.Visible = true;
            BtnCreate.Visible = false;
            BtnDel.Visible = true;
            BtnEdit.Visible = false;
            BtnExit.Visible = false;
            BtnRead.Visible = false;
            BtnSave.Visible = false;
            BtnSave1.Visible = true;
            BtnSave1.Location = new Point(10, 683);
            BtnClear.Location = new Point(275, 683);
            BtnDel.Location = new Point(540, 683);
            BtnBack1.Text = "Cancel";
            BtnBack1.Location = new Point(805, 683);
            
            
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            String FileName = Directory.GetCurrentDirectory() + "\\Diary-" + LblDate.Text.ToString() + ".txt";
            String Content = TxtBxDiary.Text.ToString();
            System.IO.StreamWriter write2File = new System.IO.StreamWriter(FileName);
            write2File.Write(Content);
            write2File.Close();
            MessageBox.Show("Diary Entry Saved");
        }
    }
}
