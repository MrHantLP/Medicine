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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void startRedact_Click(object sender, EventArgs e)
        {
            knowledgRedact fKR = new knowledgRedact();
            fKR.ShowDialog();


        }

        private void Main_Load(object sender, EventArgs e)
        {

           // FS.FarmGroups.Add(new FarmGroup("Группа", new List<DV>()));
            //FS.FarmGroups[0].DVs.Add(new DV("ДВ-о", new List<DV>(), new List<Notice>()));
            //Knowledge.Ill.Add(new Illnes("Конюктивит", new List<FarmGroup>()));
            //Knowledge.Ill[0].FSs.Add(new FarmGroup("Фарм группа", new List<DV>()));
            //List<Variant> v = new List<Variant>();
            //v.Add(new Variant("таблетки", new Dozir(new DozirbyOnce("мг", 10), new DozirbyDay("мг", 100), new DozirbyCourse("мг", 1000))));
            //Knowledge.Ill[0].FSs[0].DVs.Add(new DV("Хорошее ДВ", v));

           
            //BinarySerialization.WriteToBinaryFile<List<Illnes>>("knowledge.bin", Knowledge.Ill);
            //BinarySerialization.WriteToBinaryFile<List<FarmGroup>>("farmspavochnik.bin", FS.FarmGroups);
            //BinarySerialization.WriteToBinaryFile<List<History>>("histories.bin", RealHistories.Hs);
           
            Knowledge.Ill = BinarySerialization.ReadFromBinaryFile<List<Illnes>>("knowledge.bin");
            FS.FarmGroups = BinarySerialization.ReadFromBinaryFile<List<FarmGroup>>("farmspavochnik.bin");
            RealHistories.Hs = BinarySerialization.ReadFromBinaryFile<List<History>>("histories.bin");
            Console.Write("Базы данных считаны");
           
        }
    }
}
