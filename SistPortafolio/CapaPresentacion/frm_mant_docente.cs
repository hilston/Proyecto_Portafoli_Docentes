using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frm_mant_docente : Form
    {
        public frm_mant_docente()
        {
            InitializeComponent();
        }
        public void limpiarcampos() {
            txt_iddocente.Text = "";
            txt_nombres.Text = "";
            txt_paterno.Text = "";
            txt_materno.Text = "";
            txt_dni.Text = "";
            txt_telefono.Text = "";
            txt_direccion.Text="";

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try {
                string msj=CapaNegocio.DocenteBL.Insert(txt_iddocente.Text, txt_nombres.Text, txt_paterno.Text, txt_materno.Text, txt_dni.Text, txt_telefono.Text, txt_direccion.Text);
                MessageBox.Show(msj);
                limpiarcampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = CapaNegocio.DocenteBL.Update(txt_iddocente.Text, txt_nombres.Text, txt_paterno.Text, txt_materno.Text, txt_dni.Text, txt_telefono.Text, txt_direccion.Text);
                MessageBox.Show(msj);
                limpiarcampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = CapaNegocio.DocenteBL.Delete(txt_iddocente.Text);
                MessageBox.Show(msj);
                limpiarcampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
