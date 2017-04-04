using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignStackOverflow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Entropy(2, 4);
            Entropy(2, 6);
            Entropy(1, 4);

        }
        double ln(double x)
        {
            return Math.Log(x, Math.E);
        }
        double log2(double p)
        {
            return (ln(p) / ln(2));
        }
        public double Entropy(int a, int total)
        {
            double p1 = (double)a / total;
            double p2 = (double)(total - a)/total;
            double b = log2(p1);
            double result =( -p1 * (log2(p1)) )-( p2 * (log2(p2)));
            return result;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
