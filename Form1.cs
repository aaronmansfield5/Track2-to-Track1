using System.Drawing;
using System.Windows.Forms;

namespace Track2toTrack1
{
    public partial class Form1 : Form
    {
        float firstWidth = 409;
        float firstHeight = 263;
        public Form1()
        {
            InitializeComponent();
        }

        private void HasPin_CheckedChanged(object sender, System.EventArgs e)
        {
            Pin.Visible = HasPin.Checked;
        }

        private void Generate_Click(object sender, System.EventArgs e)
        {
            string PAN = Track2.Text.Split('=')[0];
            string Other = Track2.Text.Split('=')[1].Substring(0, 7);
            string Rest = Track2.Text.Split('=')[1].Remove(0, 7);
            if (HasPin.Checked)
            {
                Track1.Text = $"{PAN}^{Surname.Text.ToUpper()}/{Forename.Text.ToUpper()}^{Other}0000000000{Rest}000000^{Pin.Text}";
            }
            else
            {
                Track1.Text = $"{PAN}^{Surname.Text.ToUpper()}/{Forename.Text.ToUpper()}^{Other}0000000000{Rest}000000";
            }
            Clipboard.SetText(Track1.Text);
        }
        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            float size1 = this.Size.Width / firstWidth;
            float size2 = this.Size.Height / firstHeight;
            SizeF scale = new SizeF(size1, size2);
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));
                control.Scale(scale);
            }
        }
    }
}