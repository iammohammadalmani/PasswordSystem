namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            username21 = new TextBox();
            password21 = new TextBox();
            password22 = new TextBox();
            button1 = new Button();
            error2 = new Label();
            showPassBtn2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(56, 30);
            label1.Name = "label1";
            label1.Size = new Size(682, 86);
            label1.TabIndex = 0;
            label1.Text = "Create a new account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 127);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter username and password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 174);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 208);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 3;
            label4.Text = "Passwrod:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(232, 241);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 4;
            label5.Text = "Re-enter Password:";
            // 
            // username21
            // 
            username21.Location = new Point(393, 176);
            username21.Name = "username21";
            username21.Size = new Size(159, 23);
            username21.TabIndex = 5;
            username21.TextChanged += username21_TextChanged;
            // 
            // password21
            // 
            password21.Location = new Point(393, 208);
            password21.Name = "password21";
            password21.Size = new Size(159, 23);
            password21.TabIndex = 6;
            // 
            // password22
            // 
            password22.Location = new Point(393, 243);
            password22.Name = "password22";
            password22.Size = new Size(159, 23);
            password22.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(341, 292);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 8;
            button1.Text = "Create new account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // error2
            // 
            error2.AutoSize = true;
            error2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            error2.ForeColor = Color.Red;
            error2.Location = new Point(383, 337);
            error2.Name = "error2";
            error2.Size = new Size(40, 15);
            error2.TabIndex = 9;
            error2.Text = "label6";
            error2.Visible = false;
            // 
            // showPassBtn2
            // 
            showPassBtn2.Location = new Point(558, 207);
            showPassBtn2.Name = "showPassBtn2";
            showPassBtn2.Size = new Size(75, 23);
            showPassBtn2.TabIndex = 10;
            showPassBtn2.Text = "Hide";
            showPassBtn2.UseVisualStyleBackColor = true;
            showPassBtn2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showPassBtn2);
            Controls.Add(error2);
            Controls.Add(button1);
            Controls.Add(password22);
            Controls.Add(password21);
            Controls.Add(username21);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox username21;
        private TextBox password21;
        private TextBox password22;
        private Button button1;
        private Label error2;
        private Button showPassBtn2;
    }
}