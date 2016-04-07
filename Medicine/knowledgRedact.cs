using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine
{
    public partial class knowledgRedact : Form
    {
        public knowledgRedact()
        {
            InitializeComponent();
        }

        private void redactFS_Click(object sender, EventArgs e)
        {
            FSredact FSr = new FSredact();
            FSr.ShowDialog();
        }

        private void knowledgRedact_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
