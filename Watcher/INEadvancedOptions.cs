using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Watcher.Properties;

namespace Watcher
{
    public partial class INEadvancedOptions : Form
    {
        public INEadvancedOptions()
        {
            InitializeComponent();
            LoadOptions();
        }

        public void LoadOptions()
        {
            x1TextBox.Text = Settings.Default.X1.ToString();
            y1TextBox.Text = Settings.Default.Y1.ToString();
            x2TextBox.Text = Settings.Default.X2.ToString();
            y2TextBox.Text = Settings.Default.Y2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.X1 = -180;
            Settings.Default.Y1 = 0;
            Settings.Default.X2 = -180;
            Settings.Default.Y2 = 396;
            Settings.Default.Save();
            Close();
        }
    }
}
