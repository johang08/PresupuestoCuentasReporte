using PresupuestoCuentas.BLL;
using PresupuestoCuentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestoCuentas.UI.Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CuentaIDnumericUpDown.Value = 0;
            DescripciontextBox1.Text = string.Empty;
            MontoNumericUpDown.Value = 0;
        }
        private Cuenta LlenaClase()
        {
            Cuenta cuenta = new Cuenta()
            {
                CuentaId = Convert.ToInt32(CuentaIDnumericUpDown.Value),
                Descripcion = DescripciontextBox1.Text,
                TipoId = (int)TipoComboBox.SelectedValue,
                Monto = Convert.ToDouble(MontoNumericUpDown.Value)
            };
            return cuenta;
        }
        private void LlenaCampo(Cuenta cuenta)
        {

            CuentaIDnumericUpDown.Value = cuenta.CuentaId;
            DescripciontextBox1.Text = cuenta.Descripcion;
            TipoComboBox.SelectedIndex = cuenta.TipoId;
            MontoNumericUpDown.Value = Convert.ToDecimal(cuenta.Monto);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}

