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
    public partial class addFG : Form
    {
        public addFG()
        {
            InitializeComponent();
        }

        private FSredact fsRedact;
        public addFG(FSredact fs)
        {
            InitializeComponent();
            fsRedact = fs;
        }
        private String currentFG = "";
        public addFG(FSredact fs, String name)
        {
            InitializeComponent();
            currentFG = name;  
            fsRedact = fs;
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            FS.FarmGroups.Remove(FS.FarmGroups.Find(x => x.name == FG.Text));
            BinarySerialization.WriteToBinaryFile<List<FarmGroup>>("farmspavochnik.bin", FS.FarmGroups);
            FG.Text = "";
            fsRedact.Invalidate();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            while (FG.Text.IndexOf("  ") != -1)
            {
                FG.Text = FG.Text.Replace("  ", " ");
            }
            if (FG.Text.Length > 1)
            {
                if (currentFG != "")
                {
                    FS.FarmGroups.Remove(FS.FarmGroups.Find(x => x.name == currentFG));
                    if (FS.FarmGroups.FindIndex(x => x.name == FG.Text) == -1)
                    {
                        FS.FarmGroups.Add(new FarmGroup(FG.Text, new List<DV>()));
                        BinarySerialization.WriteToBinaryFile<List<FarmGroup>>("farmspavochnik.bin", FS.FarmGroups);

                    }
                }
                else
                {
                    if (FS.FarmGroups.FindIndex(x => x.name == FG.Text) == -1)
                    {
                        FS.FarmGroups.Add(new FarmGroup(FG.Text, new List<DV>()));
                        BinarySerialization.WriteToBinaryFile<List<FarmGroup>>("farmspavochnik.bin", FS.FarmGroups);

                    }
                }
                fsRedact.Invalidate();
                this.Close();

            }
            else
            {
                MessageBox.Show("Поля для ввода дожно иметь длину больше 1 символа", "Ошибка при вводе", MessageBoxButtons.OK);
            }
        }

        private void addFG_Activated(object sender, EventArgs e)
        {
        }

        private void addFG_Load(object sender, EventArgs e)
        {
            delete.Visible = false;

            add.Text = "Добавить";
            if (currentFG != "")
            {
                add.Text = "Изменить";
                FG.Text = currentFG;
                delete.Visible = true;
            }
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
