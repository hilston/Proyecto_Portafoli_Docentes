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
    public partial class frm_mant_portafolio : Form
    {
        public frm_mant_portafolio()
        {
            InitializeComponent();
        }

        private void frm_mant_portafolio_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("doc01", "D:\\TAREA1.pdf",false,"add", "del","ver");
            dataGridView1.Rows.Add("doc02", "D:\\TAREA1.pdf", false, "add", "del", "ver");
            dataGridView1.Rows.Add("doc03", "D:\\TAREA1.pdf", false, "add", "del", "ver");
            dataGridView1.Rows.Add("doc04", "D:\\TAREA1.pdf", false, "add", "del", "ver");
            dataGridView1.Rows.Add("doc05", "D:\\TAREA1.pdf", false, "add", "del", "ver");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dataGridView1.CurrentRow;
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Archivos pdf(*.pdf)|*.pdf";
                abrir.Title = "Archivos pdf";
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    fila.Cells[1].Value = abrir.FileName;
                    fila.Cells[2].Value = true;
                }
                else
                {
                    abrir.Dispose();
                }
            }
            else
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    fila.Cells[2].Value = false;
                    fila.Cells[1].Value = "";
                }
                else {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = fila.Cells[1].Value.ToString();
                    proc.Start();
                    proc.Close();
                }
            }
        }
    }
}
