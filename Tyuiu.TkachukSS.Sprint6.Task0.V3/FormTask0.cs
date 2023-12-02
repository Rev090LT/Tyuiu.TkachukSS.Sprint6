using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TkachukSS.Sprint6.Task0.V3.Lib;

namespace Tyuiu.TkachukSS.Sprint6.Task0.V3
{
    public partial class FormTask0 : Form
    {
        public FormTask0()
        {
            InitializeComponent();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РПСб-23-1 Ткачук Семён Сергеевич", "Alert");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVar.Text)));
            }
            catch 
            { 
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar>=58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            } 
        }
    }
}
