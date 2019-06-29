using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        int n = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Inputformbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(inputformbox.SelectedIndex == 0)
            {
                TextBox Count = new TextBox();
                Count.Name = "Counter" + n;
                Label CountName = new Label();
                CountName.Text = "Counter" + n;
                this.Controls.Add(CountName);
                this.Controls.Add(Count);
                n++;
            }
        }
    }
}
