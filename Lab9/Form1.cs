using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class fMain : Form
    {
        double sum = 0;
        double sum1 = 0;
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Перетворення текстових рядків, які ввів користувач у змінні числового типу
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);

            // Обчислення кількості рядків та стовпчиків таблиці
            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 1;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 1;

            // Вивід заголовків рядків та стовпців таблиці
            for (int i = 0; i < gv.RowCount; i++)
            {
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            }
            gv.RowHeadersWidth = 80;
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }

            // Для автоматичного підлаштування розмірів стовпчиків та рядків можна використовувати ці методи
            //gv.AutoResizeColumns();
            //gv.AutoResizeRows();
            int cl, rw;
            double x1, x2, y;

            // Розрахунок і вивід результатів
            rw = 0;
            x1 = x1min;
            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    // y = x1 + x2;
                    //y = Math.Pow(Math.Cos(x1-Math.Sqrt(x2/(x1+53*(x2*x2)))),4);
                    y = Math.Log(x2)/(Math.Pow(Math.Sqrt(0.6*x1*Math.Sin(x2)*Math.Cos(Math.Pow(x1, 4))),5));
                    if (y < 0)
                    {
                        sum1 = Math.Pow(y, 2);
                        sum += sum1;
                    }
                 
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    
                    x2 += dx2;
                    cl++;
            
                }
                x1 += dx1;
                rw++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";
            gv.Rows.Clear();

            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
            {
                gv.Columns[Cl].HeaderCell.Value = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Cуму квадратів всіх від'ємних розрахованих проміжних значень: {0}", sum.ToString("0.000")));
        }

        private void tbx1min_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx1min.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx1min.Text = tbx1min.Text.Remove(tbx1min.Text.Length - 1);
            }
        }

        private void tbx1max_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx1max.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx1max.Text = tbx1max.Text.Remove(tbx1max.Text.Length - 1);
            }
        }

        private void tbdx1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbdx1.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbdx1.Text = tbdx1.Text.Remove(tbdx1.Text.Length - 1);
            }
        }

        private void tbx2min_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx2min.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx2min.Text = tbx2min.Text.Remove(tbx2min.Text.Length - 1);
            }
        }

        private void tbx2max_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbx2max.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbx2max.Text = tbx2max.Text.Remove(tbx2max.Text.Length - 1);
            }
}

        private void tbdx2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbdx2.Text, "[^0-9,]"))
            {
                MessageBox.Show("Заборонено використання літер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbdx2.Text = tbdx2.Text.Remove(tbdx2.Text.Length - 1);
            }
        }
    }
}
