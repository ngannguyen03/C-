namespace Article08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDisplay.Size = new System.Drawing.Size(320, 32);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblMemory
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblMemory.ForeColor = System.Drawing.Color.Blue;
            this.lblMemory.Location = new System.Drawing.Point(15, 16);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(13, 13);
            this.lblMemory.TabIndex = 1;
            this.lblMemory.Text = "M";
            this.lblMemory.Visible = false;

            // Thiết lập kích thước và vị trí buttons
            int btnWidth = 60;
            int btnHeight = 40;
            int startX = 12;
            int startY = 60;
            int spacing = 5;

            // Row 1: Memory buttons
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMC.Location = new System.Drawing.Point(startX, startY);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMC.TabIndex = 2;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);

            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMR.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMR.TabIndex = 3;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);

            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMS.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMS.TabIndex = 4;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);

            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMPlus.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMPlus.TabIndex = 5;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);

            this.btnMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMMinus.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 4, startY);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMMinus.TabIndex = 6;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);

            // Row 2: Clear functions
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClear.Location = new System.Drawing.Point(startX, startY + btnHeight + spacing);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClearEntry.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY + btnHeight + spacing);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnClearEntry.TabIndex = 8;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);

            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBackspace.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + btnHeight + spacing);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnBackspace.TabIndex = 9;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);

            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPercent.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY + btnHeight + spacing);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnPercent.TabIndex = 10;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);

            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReciprocal.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 4, startY + btnHeight + spacing);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnReciprocal.TabIndex = 11;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);

            // Row 3: Scientific functions và toán tử
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSquare.Location = new System.Drawing.Point(startX, startY + (btnHeight + spacing) * 2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnSquare.TabIndex = 12;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);

            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSquareRoot.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY + (btnHeight + spacing) * 2);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnSquareRoot.TabIndex = 13;
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);

            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlusMinus.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + (btnHeight + spacing) * 2);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnPlusMinus.TabIndex = 14;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);

            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDivide.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY + (btnHeight + spacing) * 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);

            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMultiply.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 4, startY + (btnHeight + spacing) * 2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);

            // Row 4: 7, 8, 9, -, +
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn7.Location = new System.Drawing.Point(startX, startY + (btnHeight + spacing) * 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn8.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY + (btnHeight + spacing) * 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn9.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + (btnHeight + spacing) * 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMinus.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY + (btnHeight + spacing) * 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);

            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlus.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 4, startY + (btnHeight + spacing) * 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnPlus.TabIndex = 21;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);

            // Row 5: 4, 5, 6
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn4.Location = new System.Drawing.Point(startX, startY + (btnHeight + spacing) * 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn5.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY + (btnHeight + spacing) * 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn6.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + (btnHeight + spacing) * 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);

            // Row 6: 1, 2, 3, = (kết hợp 2 hàng)
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.Location = new System.Drawing.Point(startX, startY + (btnHeight + spacing) * 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.Location = new System.Drawing.Point(startX + btnWidth + spacing, startY + (btnHeight + spacing) * 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);

            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + (btnHeight + spacing) * 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEquals.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 3, startY + (btnHeight + spacing) * 5);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(btnWidth, btnHeight * 2 + spacing);
            this.btnEquals.TabIndex = 28;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);

            // Row 7: 0, .
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn0.Location = new System.Drawing.Point(startX, startY + (btnHeight + spacing) * 6);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(btnWidth * 2 + spacing, btnHeight);
            this.btn0.TabIndex = 29;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);

            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDecimal.Location = new System.Drawing.Point(startX + (btnWidth + spacing) * 2, startY + (btnHeight + spacing) * 6);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDecimal.TabIndex = 30;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 456);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Article08 - Advanced Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}