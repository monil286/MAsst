namespace MAsst
{
    partial class Home
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
            this.WelcomeMsg = new System.Windows.Forms.Label();
            this.LblUName = new System.Windows.Forms.Label();
            this.LblPwd = new System.Windows.Forms.Label();
            this.TxtBxUsrNm = new System.Windows.Forms.TextBox();
            this.TxtBxPwd = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMsg
            // 
            this.WelcomeMsg.AutoSize = true;
            this.WelcomeMsg.Font = new System.Drawing.Font("Lucida Calligraphy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsg.Location = new System.Drawing.Point(275, 75);
            this.WelcomeMsg.Name = "WelcomeMsg";
            this.WelcomeMsg.Padding = new System.Windows.Forms.Padding(2);
            this.WelcomeMsg.Size = new System.Drawing.Size(523, 40);
            this.WelcomeMsg.TabIndex = 0;
            this.WelcomeMsg.Text = "Welcome to My-Assistant (M-Asst.)";
            // 
            // LblUName
            // 
            this.LblUName.AutoSize = true;
            this.LblUName.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUName.Location = new System.Drawing.Point(450, 237);
            this.LblUName.Name = "LblUName";
            this.LblUName.Size = new System.Drawing.Size(127, 27);
            this.LblUName.TabIndex = 1;
            this.LblUName.Text = "Username";
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPwd.Location = new System.Drawing.Point(450, 285);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(118, 27);
            this.LblPwd.TabIndex = 2;
            this.LblPwd.Text = "Password";
            // 
            // TxtBxUsrNm
            // 
            this.TxtBxUsrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsrNm.Location = new System.Drawing.Point(590, 235);
            this.TxtBxUsrNm.Name = "TxtBxUsrNm";
            this.TxtBxUsrNm.Size = new System.Drawing.Size(100, 29);
            this.TxtBxUsrNm.TabIndex = 3;
            // 
            // TxtBxPwd
            // 
            this.TxtBxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPwd.Location = new System.Drawing.Point(590, 286);
            this.TxtBxPwd.Name = "TxtBxPwd";
            this.TxtBxPwd.PasswordChar = '*';
            this.TxtBxPwd.Size = new System.Drawing.Size(100, 29);
            this.TxtBxPwd.TabIndex = 4;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(360, 342);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(120, 40);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Login";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.Location = new System.Drawing.Point(500, 342);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(120, 40);
            this.BtnReg.TabIndex = 6;
            this.BtnReg.Text = "Register";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(640, 343);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(120, 40);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 741);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtBxPwd);
            this.Controls.Add(this.TxtBxUsrNm);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblUName);
            this.Controls.Add(this.WelcomeMsg);
            this.Name = "Home";
            this.Text = "MAsst. Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMsg;
        private System.Windows.Forms.Label LblUName;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.TextBox TxtBxUsrNm;
        private System.Windows.Forms.TextBox TxtBxPwd;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnCancel;
    }
}

