﻿namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signUp = new Button();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            newPass = new TextBox();
            change = new Button();
            SuspendLayout();
            // 
            // signUp
            // 
            signUp.Location = new Point(12, 150);
            signUp.Name = "signUp";
            signUp.Size = new Size(82, 23);
            signUp.TabIndex = 0;
            signUp.Text = "Signup";
            signUp.UseVisualStyleBackColor = true;
            signUp.Click += SignUp_Click;
            // 
            // username
            // 
            username.Location = new Point(12, 50);
            username.Name = "username";
            username.Size = new Size(536, 23);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(12, 103);
            password.Name = "password";
            password.Size = new Size(536, 23);
            password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Change Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 271);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 6;
            label4.Text = "New Password";
            // 
            // newPass
            // 
            newPass.Location = new Point(12, 298);
            newPass.Name = "newPass";
            newPass.Size = new Size(536, 23);
            newPass.TabIndex = 7;
            // 
            // change
            // 
            change.Location = new Point(12, 344);
            change.Name = "change";
            change.Size = new Size(75, 23);
            change.TabIndex = 8;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(change);
            Controls.Add(newPass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(signUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signUp;
        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox newPass;
        private Button change;
    }
}
