using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCTurningText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Try t = new Try();
            t.DispText(e, "Haut", -125, -300, this);
            t.DispText(e, "Bas", -125, -300, this);
            t.DispText(e, "Gauche", -125, -300, this);
            t.DispText(e, "Droite", -125, -300, this);
        }
    }
}
