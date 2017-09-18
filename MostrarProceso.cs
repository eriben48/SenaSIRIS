using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MODELO;

namespace WindowsFormsApplication1
{
    public partial class MostrarProceso : Form
    {
        public object DataGriedProceso { get; private set; }

        public MostrarProceso()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            TxtNumeroProceso.Text = "";
            TxtFechaRadicacion.Text = "";
            TxtTipoProceso.Text = "";
            TxtDocAprendiz.Text = "";
        }
        private void MostrarProceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.MostrarProceso = 0;
        }


        private void BtnNumeroProceso_Click(object sender, EventArgs e)
        {
            MetodoMostrarProceso.IdProceso = TxtNumeroProceso.Text;
            MetodoMostrarProceso.MostrarIdProceso(MetodoMostrarProceso.IdProceso);
            MetodoMostrarProceso.da.Fill(MetodoMostrarProceso.ds);
            DataGridProceso.DataSource = MetodoMostrarProceso.ds.Tables[0];
            Limpiar();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MetodoMostrarProceso.MostrarTodoProceso();
            MetodoMostrarProceso.da.Fill(MetodoMostrarProceso.ds);
            DataGridProceso.DataSource = MetodoMostrarProceso.ds.Tables[0];
            Limpiar();
        }

        private void BtnFechaRadicacion_Click(object sender, EventArgs e)
        {
            MetodoMostrarProceso.FechaRadicacion = TxtFechaRadicacion.Text;
            MetodoMostrarProceso.MostrarFechaRadicacion(MetodoMostrarProceso.FechaRadicacion);
            MetodoMostrarProceso.da.Fill(MetodoMostrarProceso.ds);
            DataGridProceso.DataSource = MetodoMostrarProceso.ds.Tables[0];
            Limpiar();
        }

        private void BtnTipoProceso_Click(object sender, EventArgs e)
        {
            MetodoMostrarProceso.TipoProceso = TxtTipoProceso.Text;
            MetodoMostrarProceso.MostrarTipoProceso(MetodoMostrarProceso.TipoProceso);
            MetodoMostrarProceso.da.Fill(MetodoMostrarProceso.ds);
            DataGridProceso.DataSource = MetodoMostrarProceso.ds.Tables[0];
            Limpiar();
        }

        private void BtnDocAprendiz_Click(object sender, EventArgs e)
        {
            MetodoMostrarProceso.DocumentoAprendiz = TxtDocAprendiz.Text;
            MetodoMostrarProceso.MostrarDocumentoAprendiz(MetodoMostrarProceso.DocumentoAprendiz);
            MetodoMostrarProceso.da.Fill(MetodoMostrarProceso.ds);
            DataGridProceso.DataSource = MetodoMostrarProceso.ds.Tables[0];
            Limpiar();
        }

        private void TxtNumeroProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtFechaRadicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtTipoProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void TxtDocAprendiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }
    }
 
}
