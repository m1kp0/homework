using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace igra_recept
{
    public partial class igra_dz_texnologia : Form
    {
        List<string> kostryla = new List<string>();

        public igra_dz_texnologia()
        {
            InitializeComponent();
            kostryla.Clear();
        }

      
        private void nactroiki_bytton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void рецепт_button_Click(object sender, EventArgs e)
        {
            рецепт_панель.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            рецепт_панель.Visible = false;
        }

        private void мука1кг_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void яйцо1шт_Click(object sender, EventArgs e)
        {
            kostryla.Add("яйцо 1 шт");
            яйцолабел.Text = "добавлено: яйцо 1 шт";
        }

        private void воздух_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void мука100г_Click(object sender, EventArgs e)
        {
            kostryla.Add("мука 100г");
            яйцолабел.Text = "добавлено: мука 100г";
        }

        private void масло100г_Click(object sender, EventArgs e)
        {
            kostryla.Add("масло 100г");
            яйцолабел.Text = "добавлено: масло 100г";
        }

        private void опилки_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void сахар100г_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void молоко100мл_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kostryla.Add("сахар 10г");
            яйцолабел.Text = "добавлено: сахар 10г";
        }

        private void ложка_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void соль_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void молоко1л_Click(object sender, EventArgs e)
        {
            kostryla.Add("молоко 1л");
            яйцолабел.Text = "добавлено: молоко 1л";
        }

        private void железо_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }

        private void перемешать_Click(object sender, EventArgs e)
        {
            kostryla.Add("перемешалось");
            яйцолабел.Text = "перемешалось";
        }

        private void впечь_Click(object sender, EventArgs e)
        {
            if (kostryla.Count == 13)
            {
                яйцолабел.Text = "вы победили";
            }
            else
            {
                яйцолабел.Text = "попробуйте еще раз с начала";
                kostryla.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
