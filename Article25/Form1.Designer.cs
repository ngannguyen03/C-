namespace Article25
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600); // Kích thước màn chơi
            this.Text = "Game Hứng Trứng (Article 28)";
            this.Name = "Form1";

            // QUAN TRỌNG: Bật KeyPreview để nhận phím bấm
            this.KeyPreview = true;

            // Gắn sự kiện Load và KeyDown
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        #endregion
    }
}