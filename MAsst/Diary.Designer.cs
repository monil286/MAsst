namespace MAsst
{
    partial class Diary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.TxtBxDiary = new System.Windows.Forms.TextBox();
            this.LblDiary = new System.Windows.Forms.Label();
            this.LstBxDiaryEntry = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.BtnBack1 = new System.Windows.Forms.Button();
            this.BtnSave1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(805, 580);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(250, 40);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create New Entry";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(540, 580);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(250, 40);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit Entry";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.Location = new System.Drawing.Point(275, 580);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(250, 40);
            this.BtnDel.TabIndex = 2;
            this.BtnDel.Text = "Delete Entry";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Location = new System.Drawing.Point(10, 580);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(250, 40);
            this.BtnRead.TabIndex = 3;
            this.BtnRead.Text = "Read Entry";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // TxtBxDiary
            // 
            this.TxtBxDiary.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDiary.Location = new System.Drawing.Point(35, 93);
            this.TxtBxDiary.Multiline = true;
            this.TxtBxDiary.Name = "TxtBxDiary";
            this.TxtBxDiary.Size = new System.Drawing.Size(1000, 452);
            this.TxtBxDiary.TabIndex = 4;
            this.TxtBxDiary.Visible = false;
            this.TxtBxDiary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblDiary
            // 
            this.LblDiary.AutoSize = true;
            this.LblDiary.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiary.Location = new System.Drawing.Point(36, 70);
            this.LblDiary.Name = "LblDiary";
            this.LblDiary.Size = new System.Drawing.Size(118, 21);
            this.LblDiary.TabIndex = 5;
            this.LblDiary.Text = "Dear Diary,";
            this.LblDiary.Visible = false;
            // 
            // LstBxDiaryEntry
            // 
            this.LstBxDiaryEntry.FormattingEnabled = true;
            this.LstBxDiaryEntry.Location = new System.Drawing.Point(430, 280);
            this.LstBxDiaryEntry.Name = "LstBxDiaryEntry";
            this.LstBxDiaryEntry.Size = new System.Drawing.Size(200, 199);
            this.LstBxDiaryEntry.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(136, 669);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(250, 40);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(419, 669);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(250, 40);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Visible = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(710, 669);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(250, 40);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(250, 640);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(250, 40);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(525, 640);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(250, 40);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(35, 24);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(57, 21);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "label1";
            this.LblDate.Visible = false;
            // 
            // BtnBack1
            // 
            this.BtnBack1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack1.Location = new System.Drawing.Point(40, 683);
            this.BtnBack1.Name = "BtnBack1";
            this.BtnBack1.Size = new System.Drawing.Size(250, 40);
            this.BtnBack1.TabIndex = 13;
            this.BtnBack1.Text = "Back";
            this.BtnBack1.UseVisualStyleBackColor = true;
            this.BtnBack1.Visible = false;
            this.BtnBack1.Click += new System.EventHandler(this.BtnBack1_Click_1);
            // 
            // BtnSave1
            // 
            this.BtnSave1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave1.Location = new System.Drawing.Point(96, 640);
            this.BtnSave1.Name = "BtnSave1";
            this.BtnSave1.Size = new System.Drawing.Size(250, 40);
            this.BtnSave1.TabIndex = 14;
            this.BtnSave1.Text = "Save";
            this.BtnSave1.UseVisualStyleBackColor = true;
            this.BtnSave1.Visible = false;
            this.BtnSave1.Click += new System.EventHandler(this.BtnSave1_Click);
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.BtnSave1);
            this.Controls.Add(this.BtnBack1);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstBxDiaryEntry);
            this.Controls.Add(this.LblDiary);
            this.Controls.Add(this.TxtBxDiary);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnCreate);
            this.Name = "Diary";
            this.Text = "My Diary";
            this.Load += new System.EventHandler(this.Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.TextBox TxtBxDiary;
        private System.Windows.Forms.Label LblDiary;
        private System.Windows.Forms.ListBox LstBxDiaryEntry;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Button BtnBack1;
        private System.Windows.Forms.Button BtnSave1;
    }
}