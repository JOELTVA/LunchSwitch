using System.Collections.Generic;

namespace LunchSwitch
{
    partial class FrontPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Controller controller = new Controller();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.lblLogIn = new System.Windows.Forms.Label();
            this.txtUserIdLogIn = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogInMessage = new System.Windows.Forms.Label();
            this.lBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(1166, 216);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(439, 39);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "Already a member? Log in";
            // 
            // txtUserIdLogIn
            // 
            this.txtUserIdLogIn.Location = new System.Drawing.Point(1316, 288);
            this.txtUserIdLogIn.Name = "txtUserIdLogIn";
            this.txtUserIdLogIn.Size = new System.Drawing.Size(270, 38);
            this.txtUserIdLogIn.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1351, 369);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(1181, 454);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(403, 47);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(1185, 291);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(112, 32);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "User id:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(1185, 369);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 32);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogInMessage
            // 
            this.lblLogInMessage.AutoSize = true;
            this.lblLogInMessage.Location = new System.Drawing.Point(1186, 557);
            this.lblLogInMessage.Name = "lblLogInMessage";
            this.lblLogInMessage.Size = new System.Drawing.Size(0, 32);
            this.lblLogInMessage.TabIndex = 6;
            // 
            // lBoxUsers
            // 
            this.lBoxUsers.FormattingEnabled = true;
            this.lBoxUsers.ItemHeight = 31;
            this.lBoxUsers.Location = new System.Drawing.Point(127, 134);
            this.lBoxUsers.Name = "lBoxUsers";
            this.lBoxUsers.Size = new System.Drawing.Size(628, 500);
            this.lBoxUsers.TabIndex = 7;
            //foreach(user u in controller.FindAllUsers())
            //{
            //    this.lBoxUsers.Items.Add(u.fullName);
            //}
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(2125, 990);
            this.Controls.Add(this.lBoxUsers);
            this.Controls.Add(this.lblLogInMessage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserIdLogIn);
            this.Controls.Add(this.lblLogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrontPage";
            this.Text = "Lunch switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.TextBox txtUserIdLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogInMessage;
        private System.Windows.Forms.ListBox lBoxUsers;
    }
}

