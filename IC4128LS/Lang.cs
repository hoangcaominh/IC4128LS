using System;
using System.IO;
using System.Windows.Forms;

namespace IC4128LS
{
    public partial class Lang : Form
    {
        public Lang()
        {
            File.WriteAllText("lang.txt", "");
            InitializeComponent();
        }

        private void BtnEn_Click(object sender, EventArgs e)
        {
            File.WriteAllText("lang.txt", "en");
            Close();
        }

        private void BtnJp_Click(object sender, EventArgs e)
        {
            File.WriteAllText("lang.txt", "ja");
            Close();
        }

        private void BtnZh_Click(object sender, EventArgs e)
        {
            File.WriteAllText("lang.txt", "zh");
            Close();
        }
    }
}
