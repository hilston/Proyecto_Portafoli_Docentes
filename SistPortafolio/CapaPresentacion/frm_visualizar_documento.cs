using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
namespace CapaPresentacion
{
    public partial class frm_visualizar_documento : Form
    {
        public frm_visualizar_documento()
        {
            InitializeComponent();
        }

        private void frm_visualizar_documento_Load(object sender, EventArgs e)
        {
            string ruta;
            string pdfPath = Path.Combine(Application.StartupPath, "D:\\TAREA1.pdf");
            Process.Start(pdfPath);
        }
    }
}
