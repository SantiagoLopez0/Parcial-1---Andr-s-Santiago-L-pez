using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parcial_1___Andrés_Santiago_López
{
    public partial class Employee : Form
    {
        
        

        public RichTextBox producosRegistrados = new RichTextBox();
        public Employee() { 
        
            
            InitializeComponent();

            producosRegistrados = registroRtxt;

            producosRegistrados.ReadOnly = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void volverLoginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void registrarVentaBtn_Click(object sender, EventArgs e)
        {
            String resultado = "";

            NumericUpDown cantidadPanes = cantidadPanesInput;
            CheckedListBox panes = tipoDePanesCheckList;
            NumericUpDown precioVenta = precioVentaInput;

            TextBox nombre = nombreClienteInput;
            NumericUpDown cedula = cedulaInput;
            DateTimePicker fecha = fechaInput;

            resultado = "\nCantidad de panes seleccionados por el cliente: " + cantidadPanesInput.Value;

            if (panes.CheckedItems.Count != 0)
            {
                resultado = resultado + "\nTipo de panes elegidos por el cliente: ";
                for (int i = 0; i < panes.CheckedItems.Count; i++)
                {
                    resultado = resultado + panes.CheckedItems[i].ToString() + "\n";
                }
            }

            resultado = resultado + "\nEl precio de la venta es: " + precioVenta.Value +
                                    "\nNombre de cliente: " + nombre.Text +
                                    "\nCedula del cliente: " + cedula.Value +
                                    "\nFecha de la venta: " + fecha.Text +
                                    "\n---------------------------------------------------------------------------------";

            producosRegistrados.Text = producosRegistrados.Text + resultado;



        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cantidadPanesInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cantidadPanesInput.Text))
            {
                e.Cancel = true;
                cantidadPanesInput.Focus();
                errorProvider.SetError(cantidadPanesInput, "Campo requerido para registrar producto!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cantidadPanesInput, "");
            }
        }

        private void precioVentaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(precioVentaInput.Text))
            {
                e.Cancel = true;
                precioVentaInput.Focus();
                errorProvider.SetError(precioVentaInput, "Campo requerido para registrar producto!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(precioVentaInput, "");
            }
        }

        private void nombreClienteInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreClienteInput.Text))
            {
                e.Cancel = true;
                nombreClienteInput.Focus();
                errorProvider.SetError(nombreClienteInput, "Campo requerido para registrar producto!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(nombreClienteInput, "");
            }
        }

        private void cedulaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedulaInput.Text))
            {
                e.Cancel = true;
                cedulaInput.Focus();
                errorProvider.SetError(cedulaInput, "Campo requerido para registrar producto!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cedulaInput, "");
            }
        }

        private void fechaInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fechaInput.Text))
            {
                e.Cancel = true;
                fechaInput.Focus();
                errorProvider.SetError(fechaInput, "Campo requerido para registrar producto!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(fechaInput, "");
            }
        }
    }
}
