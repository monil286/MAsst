namespace MAsst
{
    partial class SelectAction
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
            this.MoCal1 = new System.Windows.Forms.MonthCalendar();
            this.BtnGoal = new System.Windows.Forms.Button();
            this.BtnDiary = new System.Windows.Forms.Button();
            this.BtnTaskM = new System.Windows.Forms.Button();
            this.BtnExpenseM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoCal1
            // 
            this.MoCal1.Location = new System.Drawing.Point(416, 200);
            this.MoCal1.MaxSelectionCount = 1;
            this.MoCal1.Name = "MoCal1";
            this.MoCal1.TabIndex = 0;
            // 
            // BtnGoal
            // 
            this.BtnGoal.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoal.Location = new System.Drawing.Point(15, 500);
            this.BtnGoal.Name = "BtnGoal";
            this.BtnGoal.Size = new System.Drawing.Size(250, 40);
            this.BtnGoal.TabIndex = 1;
            this.BtnGoal.Text = "My Goals";
            this.BtnGoal.UseVisualStyleBackColor = true;
            // 
            // BtnDiary
            // 
            this.BtnDiary.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiary.Location = new System.Drawing.Point(280, 500);
            this.BtnDiary.Name = "BtnDiary";
            this.BtnDiary.Size = new System.Drawing.Size(250, 40);
            this.BtnDiary.TabIndex = 2;
            this.BtnDiary.Text = "Dear Diary";
            this.BtnDiary.UseVisualStyleBackColor = true;
            this.BtnDiary.Click += new System.EventHandler(this.BtnDiary_Click);
            // 
            // BtnTaskM
            // 
            this.BtnTaskM.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTaskM.Location = new System.Drawing.Point(545, 500);
            this.BtnTaskM.Name = "BtnTaskM";
            this.BtnTaskM.Size = new System.Drawing.Size(250, 40);
            this.BtnTaskM.TabIndex = 3;
            this.BtnTaskM.Text = "My Tasks";
            this.BtnTaskM.UseVisualStyleBackColor = true;
            this.BtnTaskM.Click += new System.EventHandler(this.BtnTaskM_Click);
            // 
            // BtnExpenseM
            // 
            this.BtnExpenseM.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExpenseM.Location = new System.Drawing.Point(810, 500);
            this.BtnExpenseM.Name = "BtnExpenseM";
            this.BtnExpenseM.Size = new System.Drawing.Size(250, 40);
            this.BtnExpenseM.TabIndex = 4;
            this.BtnExpenseM.Text = "My Money";
            this.BtnExpenseM.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(545, 575);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(250, 40);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // SelectAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExpenseM);
            this.Controls.Add(this.BtnTaskM);
            this.Controls.Add(this.BtnDiary);
            this.Controls.Add(this.BtnGoal);
            this.Controls.Add(this.MoCal1);
            this.Name = "SelectAction";
            this.Text = "SelectAction";
            this.Load += new System.EventHandler(this.SelectAction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MoCal1;
        private System.Windows.Forms.Button BtnGoal;
        private System.Windows.Forms.Button BtnDiary;
        private System.Windows.Forms.Button BtnTaskM;
        private System.Windows.Forms.Button BtnExpenseM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnExit;
    }
}