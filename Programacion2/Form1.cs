using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitades;

namespace Programacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //inicializo la restriccion el DTP al comienzo
            dateTimePicker1.MinDate = new DateTime(1960, 6, 20);
            dateTimePicker1.MaxDate = new DateTime(2010, 6, 20);

        }


        public void cargarTabla()

        {
            //  legajo alumnos numeros profesor letras

            if (rbMasc.Checked == true)
            {
                if (rbProf.Checked == true)
                {
                    Profesor prof = new Profesor(txtNombre.Text, Convert.ToInt32(txtDni.Text), dateTimePicker1.Value, 'M', txtLegajo.Text, txtMateriaCarrera.Text);

                    dgv.Rows.Add(prof.Nombre, prof.Dni, prof.FechNac, prof.Sexo, prof.Legajo, prof.Materia);

                   

                    


                }
                if (rbEstud.Checked == true)
                {
                    Alumno alu = new Alumno(txtNombre.Text, Convert.ToInt32(txtDni.Text), dateTimePicker1.Value, 'M', txtLegajo.Text, txtMateriaCarrera.Text);

                    dgv.Rows.Add(alu.Nombre, alu.Dni, alu.FechNac, alu.Sexo, alu.Legajo, alu.Carrera);


                }
              
            }

            if (rbFem.Checked == true)
            {
                if (rbProf.Checked == true)
                {
                    Profesor prof = new Profesor(txtNombre.Text, Convert.ToInt32(txtDni.Text), dateTimePicker1.Value, 'F', txtLegajo.Text, txtMateriaCarrera.Text);

                    dgv.Rows.Add(prof.Nombre, prof.Dni, prof.FechNac, prof.Sexo, prof.Legajo, prof.Materia);

                }
                

                if (rbEstud.Checked == true)
                {
                    Alumno alu = new Alumno(txtNombre.Text, Convert.ToInt32(txtDni.Text), dateTimePicker1.Value, 'F', txtLegajo.Text, txtMateriaCarrera.Text);

                    dgv.Rows.Add(alu.Nombre, alu.Dni, alu.FechNac, alu.Sexo, alu.Legajo, alu.Carrera);


                }
            }

        }

        public void tablaAcampo()
        {

            if (dgv.CurrentRow.Cells[3].Value.ToString() == "F")
            {
                rbFem.Checked = true;
            }
            if (dgv.CurrentRow.Cells[3].Value.ToString() == "M")
            {
                rbMasc.Checked = true;
            }

            txtNombre.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtDni.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[2].Value.ToString());
            txtLegajo.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            txtMateriaCarrera.Text = dgv.CurrentRow.Cells[5].Value.ToString();

        

        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tablaAcampo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmessaje_Click(object sender, EventArgs e)
        {

        }
          



    private void groupBoxRol_Enter(object sender, EventArgs e)
        {


        }

        private void rbProf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProf.Checked == true)
            {
                lblmessaje.Visible = false;
                lblCarrera.Visible = true;
                txtMateriaCarrera.Enabled = true;
            }
        }

        private void rbEstud_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstud.Checked == true)
            {
                lblmessaje.Visible = false;
                lblMateria.Visible = true;
                txtMateriaCarrera.Enabled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMateriaCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.MinDate = new DateTime(1960, 6, 20);
            //dateTimePicker1.MaxDate = new DateTime(2010, 6, 20); 
        }

        //public void solonumeros(a)
        //{
        //    if (Char.IsLetter(a.KeyChar))
        //    {
        //        a.hand
        //    }
        //}


        //*********** REGIONES Copiar ********
        //#region Atributos

        //#endregion

        //#region Propiedades

        //#endregion

        //#region Constructores

        //#endregion

        //#region Métodos

        //#endregion


    }
}
