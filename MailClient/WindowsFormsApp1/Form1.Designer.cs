namespace WindowsFormsApp1
{
    partial class Post_Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecipientsEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.TextBox();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.UsersNameLabel = new System.Windows.Forms.Label();
            this.UsersName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsersEmail
            // 
            this.UsersEmail.Location = new System.Drawing.Point(12, 56);
            this.UsersEmail.Name = "UsersEmail";
            this.UsersEmail.Size = new System.Drawing.Size(199, 20);
            this.UsersEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your e-mail(works with GMail only)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter e-mail of recipient";
            // 
            // RecipientsEmail
            // 
            this.RecipientsEmail.Location = new System.Drawing.Point(12, 108);
            this.RecipientsEmail.Name = "RecipientsEmail";
            this.RecipientsEmail.Size = new System.Drawing.Size(199, 20);
            this.RecipientsEmail.TabIndex = 3;
            this.RecipientsEmail.TextChanged += new System.EventHandler(this.RecipientsEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your message(will be send as HTML code)";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 218);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(776, 180);
            this.Message.TabIndex = 5;
            this.Message.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter your e-mail password";
            // 
            // UsersPassword
            // 
            this.UsersPassword.Location = new System.Drawing.Point(255, 56);
            this.UsersPassword.Name = "UsersPassword";
            this.UsersPassword.PasswordChar = '*';
            this.UsersPassword.Size = new System.Drawing.Size(199, 20);
            this.UsersPassword.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Send E-mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(15, 158);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(199, 20);
            this.Subject.TabIndex = 10;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(12, 142);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(69, 13);
            this.SubjectLabel.TabIndex = 11;
            this.SubjectLabel.Text = "Enter subject";
            // 
            // UsersNameLabel
            // 
            this.UsersNameLabel.AutoSize = true;
            this.UsersNameLabel.Location = new System.Drawing.Point(252, 92);
            this.UsersNameLabel.Name = "UsersNameLabel";
            this.UsersNameLabel.Size = new System.Drawing.Size(84, 13);
            this.UsersNameLabel.TabIndex = 12;
            this.UsersNameLabel.Text = "Enter your name";
            // 
            // UsersName
            // 
            this.UsersName.Location = new System.Drawing.Point(255, 108);
            this.UsersName.Name = "UsersName";
            this.UsersName.Size = new System.Drawing.Size(199, 20);
            this.UsersName.TabIndex = 13;
            // 
            // Post_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.UsersName);
            this.Controls.Add(this.UsersNameLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsersPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecipientsEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersEmail);
            this.Name = "Post_Client";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsersEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RecipientsEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsersPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label UsersNameLabel;
        private System.Windows.Forms.TextBox UsersName;
    }
}

