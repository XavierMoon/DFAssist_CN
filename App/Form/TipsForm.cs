using System;
using System.Windows.Forms;

namespace App
{
    public partial class TipsForm : Form
    {
        private string Roullete;
        private string Instance;
        private string Tip;
        private string Macro;

        public TipsForm(string Roullete, string Instance, string Tip, string Macro = null)
        {
            this.Roullete = Roullete;
            this.Instance = Instance;
            this.Tip = Tip.Replace("\r\n","\n").Replace("\n", Environment.NewLine);
            this.Macro = Macro;
            InitializeComponent();
        }

        private void TipsForm_Load(object sender, EventArgs e)
        {
            if (Macro == null)
            {
                panel_macro.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Macro, true);
        }

        private void TipsForm_Shown(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
            textBox1.Text = Tip;
            TopMost = false;
        }
    }
}
