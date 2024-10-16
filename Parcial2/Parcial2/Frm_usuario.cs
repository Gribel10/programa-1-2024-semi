using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Frm_usuario : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        private object grdusuario;
        private object usuario;

        public Frm_usuario()
        {
            InitializeComponent();
        }

        private void Frm_usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void ActualizarDs()
        {
            throw new NotImplementedException();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["Frm_usuario"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdFrm_usuario"] };
            grdusuario.DataSource = miTabla;
            mostrarFrm_usuario();
        }

        private void mostrarFrm_usuario()
        {
            throw new NotImplementedException();
        }

        private void mostrarDatosDocentes()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtusuarioFrm_usuario.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtclaveFrm_usuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtnombreFrm_usuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtdirecciónFrm_usuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txttelefonoFrm_usuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosFrm_usuario.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteFrm_usuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarFrm_usuario();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de Frm_usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorFrm_usuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarFrm_usuario();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de Frm_usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoFrm_usuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarFrm_usuario();
        }

        private void btnPrimeroFrm_usuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarFrm_usuario();
        }

        private void estadoControles(Boolean estado)
        {
            grbusuario.Enabled = estado;
            grbusuario.Enabled = !estado;
            btnEliminarFrm_usuario.Enabled = !estado;
        }

        private void btnNuevoFrm_usuario_Click(object sender, EventArgs e)
        {
            if (btnNuevoFrm_usuario.Text == "Nuevo")
            {
                btnNuevoFrm_usuario.Text = "Guardar";
                btnModificarFrm_usuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] Docentes = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtusuarioFrm_usuario.Text, txtclaveFrm_usuario.Text, txtnombreFrm_usuario.Text, txtdirecciónFrm_usuario.Text, txttelefonoFrm_usuario.Text
                };
                String respuesta = objConexion.administrausuario(usuario);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Frm_usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoFrm_usuario.Text = "Nuevo";
                    btnModificarFrm_usuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }



            void limpiarCajas()
            {
                txtusuarioFrm_usuario.Text = "";
                txtclaveFrm_usuario.Text = "";
                txtnombreFrm_usuario.Text = "";
                txtdirecciónFrm_usuario.Text = "";
                txttelefonoFrm_usuario.Text = "";
            }
        }

        private void btnModificarFrm_usuario_Click(object sender, EventArgs e)
        {
            if (btnModificarFrm_usuario.Text == "Modificar")
            {
                btnNuevoFrm_usuario.Text = "Guardar";
                btnModificarFrm_usuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarFrm_usuario();
                btnNuevoFrm_usuario.Text = "Nuevo";
                btnModificarFrm_usuario.Text = "Modificar";
                estadoControles(false);
            }

        }

        private void btnEliminarFrm_usuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtnombreFrm_usuario.Text.Trim() + "?", "Eliminar Frm_usuario", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Frm_usuario = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarFrm_usuario(Frm_usuario);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Frm_usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarFrm_usuario();
                }
            }


        }

        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            NewMethod(dv);
        }

        private void NewMethod(DataView dv)
        {
            grdusuario.DataSource = dv;
        }

        private void lblBuscarFrm_usuario_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarFrm_usuario_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscarFrm_usuario.Text;
            BuscarNombre(nombre);
        }

        private void BuscarNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
 
}


