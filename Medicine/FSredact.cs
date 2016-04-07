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
    public partial class FSredact : Form
    {
        public FSredact()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFG_Click(object sender, EventArgs e)
        {
            addFG addingFG = new addFG(this);
            addingFG.ShowDialog();

        }

        private void FSredact_Load(object sender, EventArgs e)
        {

        }

        private void FSredact_Activated(object sender, EventArgs e)
        {
            farmGroups.Items.Clear();
            foreach (var item in FS.FarmGroups)
            {
                farmGroups.Items.Add(item.name);
            }
            farmGroups.Sorted = true;
            
        }

        private void farmGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            DVs.Items.Clear();
            int currentI = farmGroups.SelectedIndex;
            foreach (var item in FS.FarmGroups[currentI].DVs)
            {
                DVs.Items.Add(item.name);
            }
            farmGroups.Sorted = true;
        }

        private void farmGroups_DoubleClick(object sender, EventArgs e)
        {

            String name = farmGroups.SelectedItem.ToString();
            addFG addingFG = new addFG(this, name);
            addingFG.ShowDialog();
        }

        private void addDV_Click(object sender, EventArgs e)
        {   
            addDV addingDV= new addDV(this, farmGroups.SelectedIndex);
            addingDV.ShowDialog();
        }

        private void DVs_DoubleClick(object sender, EventArgs e)
        {
            addDV addingDV = new addDV(this, farmGroups.SelectedIndex, DVs.SelectedIndex);
            addingDV.ShowDialog();
        }
    }
}
