namespace CoffeeManagement.GUI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            btLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(149, 60);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(205, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(149, 113);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(205, 27);
            txtPass.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(98, 166);
            btLogin.Margin = new Padding(3, 4, 3, 4);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(114, 40);
            btLogin.TabIndex = 2;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 64);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 117);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 281);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Khai báo biến giao diện
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}