using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicine
{
    //Наблюдения и их значения
    [Serializable]
    public class Notice
    {
        public String name = "";
        public String value = "";
        public String minValue = "";
        public String maxValue = "";
        public Notice(String n = "", String v = "", String min = "", String max = "")
        {
            name = n;
            value = v;
            minValue = min;
            maxValue = max;
        }

    }

    //Разовая дозировка
    [Serializable]
    public struct DozirbyOnce
    {
        public String kind;
        public UInt32 value;
        public UInt32 maxValue;
        public UInt32 minValue;
        public DozirbyOnce(String k = "", UInt32 v = 0, UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;
            value = v;
            maxValue = max;
            minValue = min;
        }
        public DozirbyOnce(String k = "", UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;           
            maxValue = max;
            minValue = min;
            value = 0;
        }
        public DozirbyOnce(String k = "", UInt32 v = 0)
        {
            kind = k;
            value = v;
            maxValue = 0;
            minValue = 0;
        }

    }
    //Суточная дозировка
    [Serializable]
    public struct DozirbyDay
    {
        public String kind;
        public UInt32 value;
        public UInt32 minValue;
        public UInt32 maxValue;
        public DozirbyDay(String k = "", UInt32 v = 0, UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;
            value = v;
            maxValue = max;
            minValue = min;
        }
        public DozirbyDay(String k = "", UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;
            value = 0;
            maxValue = max;
            minValue = min;
        }
        public DozirbyDay(String k = "", UInt32 v = 0)
        {
            kind = k;
            value = v;
            maxValue = 0;
            minValue = 0;
        }
    }
    //Дозировка за курс
    [Serializable]
    public struct DozirbyCourse
    {
        public String kind;
        public UInt32 value;
        public UInt32 minValue;
        public UInt32 maxValue;
        public DozirbyCourse(String k = "", UInt32 v = 0, UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;
            value = v;
            maxValue = max;
            minValue = min;
        }
        public DozirbyCourse(String k = "", UInt32 min = 0, UInt32 max = 0)
        {
            kind = k;
            value = 0;
            maxValue = max;
            minValue = min;
        }
        public DozirbyCourse(String k = "", UInt32 v = 0)
        {
            kind = k;
            value = v;
            maxValue = 0;
            minValue = 0;
        }
    }
    //Дозировка
    [Serializable]
    public struct Dozir
    {
        public DozirbyOnce byOnce;
        public DozirbyDay byDay;
        public DozirbyCourse byCourse;
        public Dozir(DozirbyOnce o = new DozirbyOnce(), DozirbyDay d = new DozirbyDay(), DozirbyCourse c = new DozirbyCourse())
        {
            byOnce = o;
            byDay = d;
            byCourse = c;
        }
    }
    //Варианты назначения - форма выпуска и дозировка
    [Serializable]
    public struct Variant
    {
        public Variant(String f = "", Dozir d = new Dozir())
        {
            FormOut = f;
            Dozirovka = d;
        }
        Dozir Dozirovka;
        public String FormOut;
    }
    //Действующее вещество, его противопоказания, несовместимости, варианты назначения
    [Serializable]
    public class DV
    {
        public DV(String n, List<Variant> v)
        {
            name = n;      
            Variants = v;
        }
        public DV(String n, List<DV> vD, List<Notice> vN)
        {
            name = n;
            vsDV = vD;
            vsNotice = vN;
        }
        public DV(String n, List<DV> vD, List<Notice> vN, List<Variant> v)
        {
            name = n;
            vsDV = vD;
            vsNotice = vN;
            Variants = v;
        }

        public String name ="";
        public List<DV> vsDV = new List<DV>();
        public List<Notice> vsNotice = new List<Notice>();
        public List<Variant> Variants = new List<Variant>();

    }
    [Serializable]
    public class FarmGroup
    {
        public FarmGroup(String n, List<DV> d)
        {
            name = n;
            DVs = d;
        }
        public String name = "";
        public List<DV> DVs = new List<DV>();
    }
    [Serializable]
    public struct Illnes
    {
        public String name;
        public List<FarmGroup> FSs;
        public Illnes(String n, List<FarmGroup> fsS)
        {
            name = n;
            FSs = fsS;
        }
    }

    [Serializable]
    public struct History
    {
        public String gender;
        public UInt32 age;
        public String Ill;
        public List<Notice> Notices;
        public History(String g, UInt32 a, String i, List<Notice> n)
        {
            gender = g;
            age = a;
            Ill = i;
            Notices = n;
        }
    }
    public static class FS
    {
        public static List<FarmGroup> FarmGroups = new List<FarmGroup>();
    }


    public static class Knowledge
    {
        public static List<Illnes> Ill = new List<Illnes>();
    }

    public static class RealHistories
    {
        public static List<History> Hs = new List<History>();
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
