using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void answerButton_Click(object sender, EventArgs e)
        {
            double[] p = new double[8] { 0.1, 0.1, 0.15, 0.15, 0.15, 0.15, 0.1, 0.1 };
            string[] pred = new string[8] { "Бесспорно", "Никаких сомнений", "Вероянтее всего", 
                                            "Хорошие перспективы", "Спроси позже", "Лучше не рассказывать",
                                            "Даже не думай", "Весьма сомнительно"};

            double a = rnd.NextDouble();

            for (int i = 0; i < 8; i++)
            {
                a -= p[i];
                if (a <= 0)
                {
                    answerLabel.Text = pred[i];
                    break;
                }
            }
        }
    }
}
