using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MODELO;

namespace WindowsFormsApplication1
{
    public partial class IngresoProceso : Form
    {
        int existe = 0;
        DateTime fecha;
        DateTime fecha1;
        ConnectionBD Puente;
        ConnectionBD Puente1;
        SqlCommand comando1;
        SqlCommand comando2;
        SqlDataReader lector;
        SqlDataReader lector1;
        public IngresoProceso()
        {
            InitializeComponent();
        }
      
        public void Limpiar()
        {
            
            ComboBoxTipoProceso.Text = "";
            ComboBoxTipoNovedad.Text = "";
            TxtConceptoNovedad.Text = "";
            TxtDocAprendiz.Text = "";
            label1.Text = "";
            Estado.Text = "";


        }

        public int Revisar()
        {
            int ok = 0;
            if (ComboBoxTipoProceso.Text == "") { ok = 1; }
            if (DateFecha.Value.Equals("")) { ok = 1; }
            if (DateFechaRadicacion.Value.Equals("")) { ok = 1; }
            if (ComboBoxTipoNovedad.Text == "") { ok = 1; }
            if (TxtConceptoNovedad.Text == "") { ok = 1; }
            if (TxtDocAprendiz.Text == "") { ok = 1; }  
            return ok;
        }
        public void desercion()
        {

            object Tipo;
            Tipo = ComboBoxTipoNovedad.SelectedItem;
            ComboBoxTipoNovedad.Items.Clear();
            if (ComboBoxTipoProceso.SelectedItem.ToString() == "DESERCION")
            {
                object PA = "INASISTENCIA 3 DIAS";
                object LA = "INASISTENCIA DESPUES DE REALIZAR MATRICULA";
                ComboBoxTipoNovedad.Items.Add(PA);
                ComboBoxTipoNovedad.Items.Add(LA);
            }
            if (ComboBoxTipoProceso.SelectedItem.ToString() == "RETIRO VOLUNTARIO")
            {
                if (label1.Text == "M")
                {
                    object BR = "CAMBIO DE CIUDAD";
                    object WE = "EMBARAZO O EMBARAZO RIESGOSO";
                    object QW = "INCAPACIDAD INDEFINIDA";
                    object RT = "MOTIVOS DE SALUD";
                    object ER = "DESMOTIVACION POR BAJO RENDIMIENTO";
                    object SD = "FALTA EMPATIA CON LOS INSTRUCTORES";
                    object GF = "ORIENTACION VOCACIONAL";
                    object FG = "FACTORES ECONOMICOS";
                    ComboBoxTipoNovedad.Items.Add(BR);
                    ComboBoxTipoNovedad.Items.Add(WE);
                    ComboBoxTipoNovedad.Items.Add(QW);
                    ComboBoxTipoNovedad.Items.Add(RT);
                    ComboBoxTipoNovedad.Items.Add(ER);
                    ComboBoxTipoNovedad.Items.Add(SD);
                    ComboBoxTipoNovedad.Items.Add(GF);
                    ComboBoxTipoNovedad.Items.Add(FG);

                }
                else
                {
                    object BR = "CAMBIO DE CIUDAD";
                    object QW = "INCAPACIDAD INDEFINIDA";
                    object RT = "MOTIVOS DE SALUD";
                    object TY = "SERVICIO MILITAR";
                    object ER = "DESMOTIVACION POR BAJO RENDIMIENTO";
                    object SD = "FALTA EMPATIA CON LOS INSTRUCTORES";
                    object GF = "ORIENTACION VOCACIONAL";
                    object FG = "FACTORES ECONOMICOS";
                    ComboBoxTipoNovedad.Items.Add(BR);
                    ComboBoxTipoNovedad.Items.Add(QW);
                    ComboBoxTipoNovedad.Items.Add(RT);
                    ComboBoxTipoNovedad.Items.Add(TY);
                    ComboBoxTipoNovedad.Items.Add(ER);
                    ComboBoxTipoNovedad.Items.Add(SD);
                    ComboBoxTipoNovedad.Items.Add(GF);
                    ComboBoxTipoNovedad.Items.Add(FG);
                }
            }
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Revisar() == 0)
                {

                    MetodoIngresarProceso.TipoProceso = ComboBoxTipoProceso.Text.ToUpper();
                    MetodoIngresarProceso.DateFecha = DateFecha.Value;
                    MetodoIngresarProceso.DateFechaRadicacion = DateFechaRadicacion.Value;
                    MetodoIngresarProceso.TipoNovedad = ComboBoxTipoNovedad.Text.ToUpper();
                    MetodoIngresarProceso.ConceptoNovedad = TxtConceptoNovedad.Text.ToUpper();
                    MetodoIngresarProceso.DocumentoAprendiz = TxtDocAprendiz.Text.ToUpper();
                    MetodoIngresarProceso.IngresarProceso(MetodoIngresarProceso.IdProceso,
                  MetodoIngresarProceso.TipoProceso, MetodoIngresarProceso.DateFecha,
                   MetodoIngresarProceso.FechaRadicacion, MetodoIngresarProceso.TipoNovedad,
                   MetodoIngresarProceso.ConceptoNovedad, MetodoIngresarProceso.DocumentoAprendiz);
                    DateFecha.Value = fecha;
                    DateFechaRadicacion.Value = fecha1;

                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    Limpiar();
                    
                }
                
            }


            catch (Exception ex)
            { MessageBox.Show("Error" + ex.ToString()); }
            if (Revisar() == 0)
            {
                try
                {
                    Puente = new ConnectionBD();
                    comando1 = new SqlCommand();
                    comando1.CommandText = "ActualizarEstado";
                    comando1.CommandType = CommandType.StoredProcedure;
                    comando1.Parameters.AddWithValue("@documentoaprendiz", TxtDocAprendiz.Text);
                    comando1.Connection = Puente.RetornarConnexion();
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("ACTUALIZACION EXITOSA");
                    
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Faltan campos por llenar", "Advertencia" + ex, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }
                Limpiar();
            }
        }

        private void IngresoProceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.IngresarProceso = 0;
            
           
        }

        private void TxtNumeroProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
        }

        private void TxtDocAprendiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Numeros(e);
            
        }

        private void ComboBoxTipoProceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
            
        }

        private void ComboBoxTipoNovedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void TxtConceptoNovedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Letras(e);
        }

        private void ComboBoxTipoProceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
           desercion();
            
        }

        private void TxtDocAprendiz_Leave(object sender, EventArgs e)
        {

            if(TxtDocAprendiz.Text.Length>=1)
            { 

           existe = 0;
            ConnectionBD Puente;
            Puente = new ConnectionBD();
            SqlCommand Commando = new SqlCommand("select Genero from Aprendiz where DocumentoAprendiz= '" + TxtDocAprendiz.Text + "'", Puente.RetornarConnexion());
            lector = Commando.ExecuteReader();
            while (lector.Read())
            {
                label1.Text = lector.GetString(0);
                lector.NextResult();
                existe = 1;
               
            }
            lector.Close();
            Commando.Dispose();
            
            if (existe == 0)
            {

                    MessageBox.Show("El aprendiz no esta registado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Limpiar();

             }

            ConnectionBD Puente1;
            Puente1 = new ConnectionBD();
            SqlCommand Commando2 = new SqlCommand("select Estado from Aprendiz where DocumentoAprendiz= '" + TxtDocAprendiz.Text + "'", Puente.RetornarConnexion());
            lector1 = Commando2.ExecuteReader();
            while (lector1.Read())
            {
                Estado.Text = lector1.GetString(0);
                lector1.NextResult();

            }
            lector1.Close();
            if (Estado.Text.Equals("INACTIVO"))
            {
               MessageBox.Show("El aprendiz esta inactivo, no se le permite realizar el proceso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
            }


            }
        }
        private void IngresoProceso_Load(object sender, EventArgs e)
        {
            fecha = DateFecha.Value;
            fecha1 = DateFechaRadicacion.Value;
        }
     
       

      
    }
    }


   

