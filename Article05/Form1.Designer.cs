namespace Article05
{
    partial class Form1
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
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(107, 46);
            tbSoX.Margin = new Padding(4, 5, 4, 5);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(199, 27);
            tbSoX.TabIndex = 0;
            tbSoX.TextChanged += tbSoX_TextChanged;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(107, 108);
            tbSoY.Margin = new Padding(4, 5, 4, 5);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(199, 27);
            tbSoY.TabIndex = 1;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(107, 169);
            tbKetQua.Margin = new Padding(4, 5, 4, 5);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(199, 27);
            tbKetQua.TabIndex = 2;
            // 
            // btCong
            // 
            btCong.Location = new Point(67, 231);
            btCong.Margin = new Padding(4, 5, 4, 5);
            btCong.Name = "btCong";
            btCong.Size = new Size(100, 38);
            btCong.TabIndex = 3;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(173, 231);
            btNhan.Margin = new Padding(4, 5, 4, 5);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(100, 38);
            btNhan.TabIndex = 4;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(280, 231);
            btThoat.Margin = new Padding(4, 5, 4, 5);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(100, 38);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 6;
            label1.Text = "Số x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "Số y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 8;
            label3.Text = "Kết quả:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}