namespace MAsst
{
    partial class Tasks
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
            this.TxtBoxSMS = new System.Windows.Forms.TextBox();
            this.BtnSndTxt = new System.Windows.Forms.Button();
            this.ChLsBxTaskList = new System.Windows.Forms.CheckedListBox();
            this.BtnAddTsk = new System.Windows.Forms.Button();
            this.TxtBoxAddTask = new System.Windows.Forms.TextBox();
            this.BtnTIP = new System.Windows.Forms.Button();
            this.BtnTskComp = new System.Windows.Forms.Button();
            this.BtnTskIr = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRemind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxSMS
            // 
            this.TxtBoxSMS.Location = new System.Drawing.Point(25, 26);
            this.TxtBoxSMS.Multiline = true;
            this.TxtBoxSMS.Name = "TxtBoxSMS";
            this.TxtBoxSMS.Size = new System.Drawing.Size(250, 40);
            this.TxtBoxSMS.TabIndex = 0;
            this.TxtBoxSMS.Visible = false;
            // 
            // BtnSndTxt
            // 
            this.BtnSndTxt.Location = new System.Drawing.Point(102, 83);
            this.BtnSndTxt.Name = "BtnSndTxt";
            this.BtnSndTxt.Size = new System.Drawing.Size(75, 23);
            this.BtnSndTxt.TabIndex = 1;
            this.BtnSndTxt.Text = "Send Message";
            this.BtnSndTxt.UseVisualStyleBackColor = true;
            this.BtnSndTxt.Visible = false;
            this.BtnSndTxt.Click += new System.EventHandler(this.BtnSndTxt_Click);
            // 
            // ChLsBxTaskList
            // 
            this.ChLsBxTaskList.FormattingEnabled = true;
            this.ChLsBxTaskList.Location = new System.Drawing.Point(308, 155);
            this.ChLsBxTaskList.Name = "ChLsBxTaskList";
            this.ChLsBxTaskList.Size = new System.Drawing.Size(200, 199);
            this.ChLsBxTaskList.TabIndex = 2;
            // 
            // BtnAddTsk
            // 
            this.BtnAddTsk.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTsk.Location = new System.Drawing.Point(10, 475);
            this.BtnAddTsk.Name = "BtnAddTsk";
            this.BtnAddTsk.Size = new System.Drawing.Size(250, 40);
            this.BtnAddTsk.TabIndex = 0;
            this.BtnAddTsk.Text = "Add Task";
            this.BtnAddTsk.UseVisualStyleBackColor = true;
            this.BtnAddTsk.Click += new System.EventHandler(this.BtnAddTsk_Click);
            // 
            // TxtBoxAddTask
            // 
            this.TxtBoxAddTask.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxAddTask.Location = new System.Drawing.Point(308, 387);
            this.TxtBoxAddTask.Name = "TxtBoxAddTask";
            this.TxtBoxAddTask.Size = new System.Drawing.Size(200, 29);
            this.TxtBoxAddTask.TabIndex = 4;
            this.TxtBoxAddTask.TextChanged += new System.EventHandler(this.TxtBoxAddTask_TextChanged);
            // 
            // BtnTIP
            // 
            this.BtnTIP.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTIP.Location = new System.Drawing.Point(275, 475);
            this.BtnTIP.Name = "BtnTIP";
            this.BtnTIP.Size = new System.Drawing.Size(250, 40);
            this.BtnTIP.TabIndex = 1;
            this.BtnTIP.Text = "Task in Progress";
            this.BtnTIP.UseVisualStyleBackColor = true;
            this.BtnTIP.Click += new System.EventHandler(this.BtnTIP_Click);
            // 
            // BtnTskComp
            // 
            this.BtnTskComp.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTskComp.Location = new System.Drawing.Point(540, 475);
            this.BtnTskComp.Name = "BtnTskComp";
            this.BtnTskComp.Size = new System.Drawing.Size(250, 40);
            this.BtnTskComp.TabIndex = 2;
            this.BtnTskComp.Text = "Task Completed";
            this.BtnTskComp.UseVisualStyleBackColor = true;
            this.BtnTskComp.Click += new System.EventHandler(this.BtnTskComp_Click);
            // 
            // BtnTskIr
            // 
            this.BtnTskIr.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTskIr.Location = new System.Drawing.Point(805, 475);
            this.BtnTskIr.Name = "BtnTskIr";
            this.BtnTskIr.Size = new System.Drawing.Size(250, 40);
            this.BtnTskIr.TabIndex = 3;
            this.BtnTskIr.Text = "Task Irrevelant";
            this.BtnTskIr.UseVisualStyleBackColor = true;
            this.BtnTskIr.Click += new System.EventHandler(this.BtnTskIr_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(415, 530);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(250, 40);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(680, 530);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(250, 40);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRemind
            // 
            this.BtnRemind.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemind.Location = new System.Drawing.Point(150, 530);
            this.BtnRemind.Name = "BtnRemind";
            this.BtnRemind.Size = new System.Drawing.Size(250, 40);
            this.BtnRemind.TabIndex = 6;
            this.BtnRemind.Text = "Set Reminder";
            this.BtnRemind.UseVisualStyleBackColor = true;
            this.BtnRemind.Click += new System.EventHandler(this.BtnRemind_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.BtnRemind);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnTskIr);
            this.Controls.Add(this.BtnTskComp);
            this.Controls.Add(this.BtnTIP);
            this.Controls.Add(this.TxtBoxAddTask);
            this.Controls.Add(this.BtnAddTsk);
            this.Controls.Add(this.ChLsBxTaskList);
            this.Controls.Add(this.BtnSndTxt);
            this.Controls.Add(this.TxtBoxSMS);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxSMS;
        private System.Windows.Forms.Button BtnSndTxt;
        private System.Windows.Forms.CheckedListBox ChLsBxTaskList;
        private System.Windows.Forms.Button BtnAddTsk;
        private System.Windows.Forms.TextBox TxtBoxAddTask;
        private System.Windows.Forms.Button BtnTIP;
        private System.Windows.Forms.Button BtnTskComp;
        private System.Windows.Forms.Button BtnTskIr;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRemind;
    }
}