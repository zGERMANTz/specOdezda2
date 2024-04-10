namespace specOdezda2
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
            panel1 = new Panel();
            button1 = new Button();
            passField = new TextBox();
            loginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 426);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.BackgroundImage = Properties.Resources._9020497_user_login_member_account_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(497, 364);
            button1.Name = "button1";
            button1.Size = new Size(78, 50);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            passField.BackColor = SystemColors.ScrollBar;
            passField.Location = new Point(99, 245);
            passField.Name = "passField";
            passField.Size = new Size(355, 23);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            loginField.BackColor = SystemColors.ScrollBar;
            loginField.Location = new Point(99, 155);
            loginField.Name = "loginField";
            loginField.Size = new Size(355, 23);
            loginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7479640_confidentiality_lock_security_protection_safety_icon;
            pictureBox2.Location = new Point(40, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4714991_avatar_engineer_people_person_profile_icon;
            pictureBox1.Location = new Point(40, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.ForeColor = Color.Red;
            closeButton.Location = new Point(570, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(14, 15);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(587, 426);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 426);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private PictureBox pictureBox2;
        private TextBox passField;
        private Button button1;
    }
}