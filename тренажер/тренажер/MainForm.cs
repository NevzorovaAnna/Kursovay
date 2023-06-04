using System;
using System.Diagnostics;


namespace тренажер
{
    public partial class MainForm : Form
    {
        public InputForm input_form;
        private ComboBox Level;
        private Button button1;
        private Button button2;
        private Label label1;
        public Rezult rezult;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input_form = new InputForm();
            input_form.Level = Level.SelectedIndex;
            input_form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezult form_p = new Rezult();
            form_p.Show();
        }
    }
}