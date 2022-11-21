using Caso2Ajedrez;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Peon peon1 =null;
        Torre torre1 = null;
        Caballo caballo1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peon1 = new Peon();
            torre1 = new Torre();
            caballo1 = new Caballo();
        }

        private void btnMoverTorre_Click(object sender, EventArgs e)
        {
            torre1.Mover();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peon1.Mover();
        }

        private void btnMoverCaballo_Click(object sender, EventArgs e)
        {
            caballo1.Mover();
        }
    }
}