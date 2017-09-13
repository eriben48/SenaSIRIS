using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AntesdeCerrar
    {
        public static Form Formulario;
        public static void Antesdecerrar(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Cerrar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Formulario.Dispose();

            }
            else
            {
                e.Cancel = true;
            }
                
            }
        }
    
}
