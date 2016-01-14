namespace MAsst
{
    partial class Reminder
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
            this.CmBxList = new System.Windows.Forms.ComboBox();
            this.BtnReminder = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxPhNo = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNo = new System.Windows.Forms.Label();
            this.CmBxCar = new System.Windows.Forms.ComboBox();
            this.LblCarrier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmBxList
            // 
            this.CmBxList.FormattingEnabled = true;
            this.CmBxList.Location = new System.Drawing.Point(210, 25);
            this.CmBxList.Name = "CmBxList";
            this.CmBxList.Size = new System.Drawing.Size(121, 21);
            this.CmBxList.TabIndex = 0;
            this.CmBxList.SelectedIndexChanged += new System.EventHandler(this.CmBxList_SelectedIndexChanged);
            // 
            // BtnReminder
            // 
            this.BtnReminder.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReminder.Location = new System.Drawing.Point(15, 300);
            this.BtnReminder.Name = "BtnReminder";
            this.BtnReminder.Size = new System.Drawing.Size(250, 40);
            this.BtnReminder.TabIndex = 1;
            this.BtnReminder.Text = "Set Reminder";
            this.BtnReminder.UseVisualStyleBackColor = true;
            this.BtnReminder.Click += new System.EventHandler(this.BtnReminder_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(278, 300);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(250, 40);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.Enabled = false;
            this.TxtBxEmail.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(310, 94);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(181, 29);
            this.TxtBxEmail.TabIndex = 3;
            this.TxtBxEmail.Visible = false;
            // 
            // TxtBxPhNo
            // 
            this.TxtBxPhNo.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPhNo.Location = new System.Drawing.Point(310, 146);
            this.TxtBxPhNo.Name = "TxtBxPhNo";
            this.TxtBxPhNo.Size = new System.Drawing.Size(181, 29);
            this.TxtBxPhNo.TabIndex = 4;
            this.TxtBxPhNo.Visible = false;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(22, 96);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(238, 24);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Enter your Email ID - ";
            this.LblEmail.Visible = false;
            // 
            // LblNo
            // 
            this.LblNo.AutoSize = true;
            this.LblNo.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNo.Location = new System.Drawing.Point(2, 149);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(300, 24);
            this.LblNo.TabIndex = 6;
            this.LblNo.Text = "Enter your Phone Number - ";
            this.LblNo.Visible = false;
            this.LblNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmBxCar
            // 
            this.CmBxCar.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxCar.FormattingEnabled = true;
            this.CmBxCar.Location = new System.Drawing.Point(310, 202);
            this.CmBxCar.Name = "CmBxCar";
            this.CmBxCar.Size = new System.Drawing.Size(181, 25);
            this.CmBxCar.TabIndex = 7;
            this.CmBxCar.Text = "<Choose your Carrier>";
            this.CmBxCar.Visible = false;
            this.CmBxCar.SelectedIndexChanged += new System.EventHandler(this.CmBxCar_SelectedIndexChanged);
            // 
            // LblCarrier
            // 
            this.LblCarrier.AutoSize = true;
            this.LblCarrier.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarrier.Location = new System.Drawing.Point(5, 202);
            this.LblCarrier.Name = "LblCarrier";
            this.LblCarrier.Size = new System.Drawing.Size(297, 24);
            this.LblCarrier.TabIndex = 8;
            this.LblCarrier.Text = "Please choose your Carrier - ";
            this.LblCarrier.Visible = false;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.LblCarrier);
            this.Controls.Add(this.CmBxCar);
            this.Controls.Add(this.LblNo);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtBxPhNo);
            this.Controls.Add(this.TxtBxEmail);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnReminder);
            this.Controls.Add(this.CmBxList);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmBxList;
        private System.Windows.Forms.Button BtnReminder;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.TextBox TxtBxPhNo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNo;
        private System.Windows.Forms.ComboBox CmBxCar;
        private System.Windows.Forms.Label LblCarrier;
    }
}