using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaTarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = Color.FromArgb(245, 245, 245); // gris claro

        }


        private bool ValidarCampos()
        {
            bool valido = true;

            errorProvider1.Clear();

            // Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }

            // Edad (solo menores de 18)
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                errorProvider1.SetError(txtEdad, "Ingrese un número válido");
                valido = false;
            }
            else if (edad <= 0 || edad >= 18)
            {
                errorProvider1.SetError(txtEdad, "Solo se permiten menores de 18 años");
                valido = false;
            }

            // Correo
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                !txtCorreo.Text.Contains("@") ||
                !txtCorreo.Text.Contains("."))
            {
                errorProvider1.SetError(txtCorreo, "Correo no válido");
                valido = false;
            }

            // Teléfono (solo números y mínimo 8 dígitos)
            if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length < 8)
            {
                errorProvider1.SetError(txtTelefono, "Teléfono no válido");
                valido = false;
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Corrige los errores antes de continuar");
                    return;
                }

                MessageBox.Show("Datos guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            errorProvider1.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var opcion = MessageBox.Show(
        "¿Deseas salir?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
