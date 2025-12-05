using System;
using System.Windows.Forms;

namespace Article07
{
    public partial class Form1 : Form
    {
        // Biến lưu giá trị đang tính toán
        private decimal currentValue = 0;
        private decimal storedValue = 0;
        private string currentOperator = "";
        private bool newInput = true;
        private bool calculated = false;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== CÁC SỰ KIỆN CHO NÚT SỐ =====
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newInput || txtDisplay.Text == "0" || calculated)
            {
                txtDisplay.Text = btn.Text;
                newInput = false;
                calculated = false;
            }
            else
            {
                // Giới hạn độ dài số để tránh tràn
                if (txtDisplay.Text.Length < 15)
                {
                    txtDisplay.Text += btn.Text;
                }
            }
        }

        // ===== CÁC SỰ KIỆN CHO PHÉP TOÁN =====
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!newInput && currentOperator != "")
            {
                Calculate();
            }

            currentOperator = btn.Text;
            storedValue = decimal.Parse(txtDisplay.Text);
            newInput = true;
            calculated = false;
        }

        // Nút =
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (currentOperator != "" && !newInput)
            {
                Calculate();
                currentOperator = "";
                calculated = true;
            }
            newInput = true;
        }

        // Nút Clear (C)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            currentValue = 0;
            storedValue = 0;
            currentOperator = "";
            newInput = true;
            calculated = false;
        }

        // Nút Clear Entry (CE)
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            newInput = true;
        }

        // Nút Backspace (⌫)
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                newInput = true;
            }
        }

        // Nút Decimal Point (.)
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                txtDisplay.Text = "0.";
                newInput = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        // Nút ± (Đổi dấu)
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                value = -value;
                txtDisplay.Text = value.ToString();
            }
        }

        // Nút % (Phần trăm)
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                value = value / 100;
                txtDisplay.Text = value.ToString();
                newInput = true;
            }
        }

        // ===== PHƯƠNG THỨC TÍNH TOÁN =====
        private void Calculate()
        {
            if (!decimal.TryParse(txtDisplay.Text, out decimal secondValue))
                return;

            try
            {
                switch (currentOperator)
                {
                    case "+":
                        storedValue = storedValue + secondValue;
                        break;
                    case "-":
                        storedValue = storedValue - secondValue;
                        break;
                    case "×":
                        storedValue = storedValue * secondValue;
                        break;
                    case "÷":
                        if (secondValue == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDisplay.Text = "0";
                            storedValue = 0;
                            currentOperator = "";
                            newInput = true;
                            return;
                        }
                        storedValue = storedValue / secondValue;
                        break;
                }

                // Hiển thị kết quả (cắt bớt số thập phân nếu cần)
                txtDisplay.Text = FormatResult(storedValue);
                newInput = true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Kết quả quá lớn!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                storedValue = 0;
                currentOperator = "";
                newInput = true;
            }
        }

        // Format kết quả để hiển thị đẹp
        private string FormatResult(decimal value)
        {
            string result = value.ToString();

            // Nếu có số thập phân và quá dài, làm tròn
            if (result.Contains(".") && result.Length > 15)
            {
                value = Math.Round(value, 10);
                result = value.ToString();
            }

            // Nếu vẫn quá dài, dùng scientific notation
            if (result.Length > 15)
            {
                result = value.ToString("E6");
            }

            return result;
        }

        // Xử lý phím từ bàn phím
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0.PerformClick();
                    return true;
                case Keys.D1:
                case Keys.NumPad1:
                    btn1.PerformClick();
                    return true;
                case Keys.D2:
                case Keys.NumPad2:
                    btn2.PerformClick();
                    return true;
                case Keys.D3:
                case Keys.NumPad3:
                    btn3.PerformClick();
                    return true;
                case Keys.D4:
                case Keys.NumPad4:
                    btn4.PerformClick();
                    return true;
                case Keys.D5:
                case Keys.NumPad5:
                    btn5.PerformClick();
                    return true;
                case Keys.D6:
                case Keys.NumPad6:
                    btn6.PerformClick();
                    return true;
                case Keys.D7:
                case Keys.NumPad7:
                    btn7.PerformClick();
                    return true;
                case Keys.D8:
                case Keys.NumPad8:
                    btn8.PerformClick();
                    return true;
                case Keys.D9:
                case Keys.NumPad9:
                    btn9.PerformClick();
                    return true;
                case Keys.Add:
                    btnPlus.PerformClick();
                    return true;
                case Keys.Subtract:
                    btnMinus.PerformClick();
                    return true;
                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    return true;
                case Keys.Divide:
                    btnDivide.PerformClick();
                    return true;
                case Keys.Enter:
                    btnEquals.PerformClick();
                    return true;
                case Keys.Escape:
                    btnClear.PerformClick();
                    return true;
                case Keys.Back:
                    btnBackspace.PerformClick();
                    return true;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    btnDecimal.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}