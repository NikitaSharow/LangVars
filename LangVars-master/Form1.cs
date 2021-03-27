using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> rus = new Dictionary<string, string>();
        public static Dictionary<string, string> eng = new Dictionary<string, string>();
        public static Dictionary<string, string> ukr = new Dictionary<string, string>();

        public static void allWords()
        {
            rus.Add("Выберите язык", "Выберите язык");
            eng.Add("Выберите язык", "Choose language");
            ukr.Add("Выберите язык", "Виберіть мову");
            rus.Add("Выберите язык(орган)", "Выберите язык");
            eng.Add("Выберите язык(орган)", "Choose tooth");
            ukr.Add("Выберите язык(орган)", "Виберіть язик");
            rus.Add("Выберите сложность", "Выберите сложность");
            eng.Add("Выберите сложность", "Choose difficulty");
            ukr.Add("Выберите сложность", "Виберіть складність");
            rus.Add("Новичок", "Новичок");
            eng.Add("Новичок", "Newbie");
            ukr.Add("Новичок", "Новачок");
            rus.Add("Любитель", "Любитель");
            eng.Add("Любитель", "amateur");
            ukr.Add("Любитель", "Любiтель");
            rus.Add("Профи", "Профи");
            eng.Add("Профи", "Pro");
            ukr.Add("Профи", "Профі");

        }

        void rename(Dictionary<string, string> words)
        {
            label1.Text = words["Выберите язык"];
            label2.Text = words["Выберите язык(орган)"];
            label3.Text = words["Выберите сложность"];
            button1.Text = words["Новичок"];
            button2.Text = words["Любитель"];
            button3.Text = words["Профи"];
        }

        public Form1()
        {
            InitializeComponent();
            allWords();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rename(eng);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rename(rus);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rename(ukr);
        }
    }
}
