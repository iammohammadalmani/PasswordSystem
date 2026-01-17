namespace WinFormsApp1
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
            username = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            error = new Label();
            label1 = new Label();
            showPassBtn = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(474, 160);
            username.Name = "username";
            username.Size = new Size(195, 23);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(475, 205);
            password.Name = "password";
            password.Size = new Size(195, 23);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(371, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 205);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(477, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(439, 284);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 21);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            error.ForeColor = Color.Red;
            error.Location = new Point(362, 322);
            error.Name = "error";
            error.Size = new Size(332, 15);
            error.TabIndex = 7;
            error.Text = "Error: Useroname or Password is wrong. Please enter again";
            error.TextAlign = ContentAlignment.MiddleCenter;
            error.Visible = false;
            error.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(945, 86);
            label1.TabIndex = 0;
            label1.Text = "Enter Username and Passowrd";
            label1.Click += label1_Click;
            // 
            // showPassBtn
            // 
            showPassBtn.Location = new Point(676, 206);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(75, 23);
            showPassBtn.TabIndex = 8;
            showPassBtn.Text = "Hide";
            showPassBtn.UseVisualStyleBackColor = true;
            showPassBtn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 530);
            Controls.Add(showPassBtn);
            Controls.Add(error);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox username;
        private TextBox password;
        private Label label2;
        private Label label3;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label error;
        private Label label1;
        private Button showPassBtn;
    }
}
