namespace Student_Information_Systems
{
    partial class frmMain
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblIntroductionTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(313, 97);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(121, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(153, 33);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(208, 26);
            this.lblIntroduction.TabIndex = 3;
            this.lblIntroduction.Text = "Welcome To Student Information Systems!\r\nYour New MarkBook Application\r\n";
            // 
            // lblIntroductionTwo
            // 
            this.lblIntroductionTwo.AutoSize = true;
            this.lblIntroductionTwo.Location = new System.Drawing.Point(169, 68);
            this.lblIntroductionTwo.Name = "lblIntroductionTwo";
            this.lblIntroductionTwo.Size = new System.Drawing.Size(169, 13);
            this.lblIntroductionTwo.TabIndex = 4;
            this.lblIntroductionTwo.Text = "Click One Of The Buttons To Start";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 158);
            this.Controls.Add(this.lblIntroductionTwo);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNewUser);
            this.Name = "frmMain";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblIntroductionTwo;
    }
}

