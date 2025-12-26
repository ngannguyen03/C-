namespace QuanLyShopQuanAo.GUI
{
    partial class frmAlert
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMsg = new Label();
            lblIcon = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMsg.ForeColor = Color.White;
            lblMsg.Location = new Point(50, 10);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(280, 50);
            lblMsg.TabIndex = 2;
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(0, 10);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(50, 50);
            lblIcon.TabIndex = 1;
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(317, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.Click += btnClose_Click;
            // 
            // frmAlert
            // 
            ClientSize = new Size(348, 61);
            Controls.Add(btnClose);
            Controls.Add(lblIcon);
            Controls.Add(lblMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlert";
            ShowInTaskbar = false;
            TopMost = true;
            ResumeLayout(false);
        }

        private Label lblMsg, lblIcon;
        private System.Windows.Forms.Timer timer1;
        private Button btnClose;
    }
}