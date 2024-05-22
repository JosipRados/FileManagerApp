namespace FileManagerDesktop.Forms
{
    partial class ReAuthenticationForm
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
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(74, 43);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(310, 27);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(74, 108);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(310, 27);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(74, 168);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(310, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ReAuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 232);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Name = "ReAuthenticationForm";
            Text = "ReAuthenticationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
    }
}