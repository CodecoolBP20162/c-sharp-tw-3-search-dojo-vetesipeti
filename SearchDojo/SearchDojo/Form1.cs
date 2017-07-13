using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            String pattern =String.Format(@"{0}", textBoxPattern.Text);
            String text = richTextBox_Text.Text;
           // Match m = Regex.Match(text, @"\d+");

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach(Match match in matches) listView1.Items.Add(match.Value);


        }
    }
}
