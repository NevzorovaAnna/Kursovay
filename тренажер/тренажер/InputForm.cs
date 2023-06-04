using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тренажер
{
    public partial class InputForm : Form
    {
        public const int InputSize = 65;
        public int Level;
        public int Second;
        public int ErrorsCount;
        public int CurrentString;
        int idx;

        public string[] lines;
        public InputForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Second++;
            SecondLable.Text = "Время: " + Second.ToString() + " сек";
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            Second = 0;
            ErrorsCount = 0;
            CurrentString = 0;
            timer.Enabled = false;

            string Path = Application.StartupPath;

            if (Level == 0)
            {
                Path += "\\easy.txt";
                LevelLable.Text = "Низкий";
            }
            if (Level == 1)
            {
                Path += "\\medium.txt";
                LevelLable.Text = "Средний";
            }
            if (Level == 2)
            {
                Path += "\\hard.txt";
                LevelLable.Text = "Высокий";
            }
            lines = System.IO.File.ReadAllLines(Path);
            InputString.Click += InputString_Click;
        }

        private void InputString_Click(object? sender, EventArgs e)
        {
            timer.Enabled = true;
            TaskString.Text = lines[0];
        }

        private void InputString_TextChanged(object sender, EventArgs e)
        {

            if (TaskString.Text.Length == InputString.Text.Length)
            {
                if (CurrentString < 4)
                {
                    string proverka = InputString.Text;
                    int dop = lines[CurrentString].Length - proverka.Length;
                    idx = 0;
                    for (int i = 0; i < dop; i++)
                    {
                        proverka += '-';
                    }
                    foreach (char symb in lines[CurrentString])
                    {
                        if (symb != proverka[idx])
                        {
                            ErrorsCount++;
                        }
                        idx++;
                        ErrorsLable.Text = "Ошибки: " + ErrorsCount.ToString();
                    }


                }
                else
                {
                    string proverka = InputString.Text;
                    int dop = lines[CurrentString].Length - proverka.Length;
                    idx = 0;
                    for (int i = 0; i < dop; i++)
                    {
                        proverka += '-';
                    }
                    foreach (char symb in lines[CurrentString])
                    {
                        if (symb != proverka[idx])
                        {
                            ErrorsCount++;
                        }
                        idx++;
                    }
                    timer.Enabled = false;
                    ErrorsLable.Text = ErrorsCount.ToString();
                    using (progressContext db = new progressContext())
                    {
                        progress progress1 = new progress { urov = LevelLable.Text, time = Second, mistakes = ErrorsCount };
                        db.progress.Add(progress1);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Уровень пройден.");
                    this.Close();


                }
                InputString.Clear();
                CurrentString++;
                if (CurrentString < 5)
                {
                    TaskString.Text = lines[CurrentString];
                }
            }
        }
    }
}