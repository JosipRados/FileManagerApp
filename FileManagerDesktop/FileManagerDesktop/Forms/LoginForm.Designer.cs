namespace FileManagerDesktop.Forms
{
    partial class LoginForm
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(232, 91);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(294, 27);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(232, 193);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(294, 27);
            tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(232, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(294, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 59);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "USERNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 160);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
    }
}