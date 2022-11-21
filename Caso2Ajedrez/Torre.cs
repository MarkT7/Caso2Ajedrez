using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso2Ajedrez
{
    public class Torre:PiezaAjedrez
    {
        public void Mover()
        {
            MessageBox.Show("La torre se mueve horizontalmente!");
        }
    }
}
