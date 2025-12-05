using System;
using System.Windows.Forms;

namespace Article08
{
    public partial class Form1 : Form
    {
        // Biến cho tính toán
        private decimal currentValue = 0;
        private decimal memoryValue = 0;
        private string currentOperator = "";
        private bool newInput = true;
        private bool calculated = false;
        private bool memoryUsed = false;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== SỰ KIỆN CHO CÁC NÚT SỐ VÀ TOÁN TỬ =====

        // Nút số (0-9)
        private void NumberButton_Click(object sender, EventArgs e)
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
                if (txtDisplay.Text.Length < 20)
                {
                    txtDisplay.Text += btn.Text;
                }
            }
        }

        // ===== CÁC SỰ KIỆN CHO TOÁN TỬ RIÊNG BIỆT =====

        // Nút ÷ (Chia)
        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperator("÷");
        }

        // Nút × (Nhân)
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperator("×");
        }

        // Nút - (Trừ)
        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        // Nút + (Cộng)
        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        // ===== PHƯƠNG THỨC HỖ TRỢ CHO TOÁN TỬ =====

        private void SetOperator(string op)
        {
            if (!newInput && currentOperator != "")
            {
                Calculate();
            }

            currentOperator = op;
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                currentValue = value;
            }
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
            currentOperator = "";
            newInput = true;
            calculated = false;
            memoryUsed = false;
        }

        // Nút Clear Entry (CE)
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            newInput = true;
        }

        // Nút Backspace (←)
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1 && txtDisplay.Text != "-")
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                newInput = true;
            }
        }

        // Nút Decimal (.)
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

        // Nút 1/x (Nghịch đảo)
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                if (value == 0)
                {
                    MessageBox.Show("Không thể tính nghịch đảo của 0", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                value = 1 / value;
                txtDisplay.Text = FormatResult(value);
                newInput = true;
            }
        }

        // Nút √ (Căn bậc 2)
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                if (value < 0)
                {
                    MessageBox.Show("Không thể tính căn bậc 2 của số âm", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = Math.Sqrt((double)value);
                txtDisplay.Text = FormatResult((decimal)result);
                newInput = true;
            }
        }

        // Nút x² (Bình phương)
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                value = value * value;
                txtDisplay.Text = FormatResult(value);
                newInput = true;
            }
        }

        // ===== CÁC NÚT MEMORY =====

        // MC - Memory Clear
        private void btnMC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            memoryUsed = false;
            UpdateMemoryIndicator();
        }

        // MR - Memory Recall
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
            newInput = true;
            memoryUsed = true;
        }

        // MS - Memory Store
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                memoryValue = value;
                memoryUsed = true;
                UpdateMemoryIndicator();
            }
        }

        // M+ - Memory Add
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                memoryValue += value;
                memoryUsed = true;
                UpdateMemoryIndicator();
            }
        }

        // M- - Memory Subtract
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out decimal value))
            {
                memoryValue -= value;
                memoryUsed = true;
                UpdateMemoryIndicator();
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
                        currentValue = currentValue + secondValue;
                        break;
                    case "-":
                        currentValue = currentValue - secondValue;
                        break;
                    case "×":
                        currentValue = currentValue * secondValue;
                        break;
                    case "÷":
                        if (secondValue == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDisplay.Text = "0";
                            currentValue = 0;
                            currentOperator = "";
                            newInput = true;
                            return;
                        }
                        currentValue = currentValue / secondValue;
                        break;
                }

                txtDisplay.Text = FormatResult(currentValue);
                newInput = true;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Kết quả quá lớn!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                currentValue = 0;
                currentOperator = "";
                newInput = true;
            }
        }

        // Format kết quả
        private string FormatResult(decimal value)
        {
            string result = value.ToString();

            if (result.Contains(".") && result.Length > 15)
            {
                value = Math.Round(value, 10);
                result = value.ToString();
            }

            if (result.Length > 20)
            {
                result = value.ToString("E10");
            }

            return result;
        }

        // Cập nhật chỉ báo memory
        private void UpdateMemoryIndicator()
        {
            lblMemory.Visible = memoryUsed;
        }

        // Xử lý phím bàn phím
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

        // Sự kiện load form
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMemoryIndicator();
        }
    }
}