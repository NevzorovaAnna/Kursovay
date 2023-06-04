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
    public partial class Rezult : Form
    {
        public Rezult()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (progressContext db = new progressContext())
            {
                var progress = db.progress.ToList();
                foreach (var item in progress)
                {
                    dataGridView1.Rows.Add(item.urov, item.time, item.mistakes);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            button1.Enabled = false;
            dataGridView1.Columns.Add("Column1", "Уровень");
            dataGridView1.Columns.Add("Column2", "Время");
            dataGridView1.Columns.Add("Column3", "Количество ошибок");
            LoadData();
        }
    }
}
