namespace CapaPresentacion
{
    partial class frm_mant_portafolio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_idportafolio = new System.Windows.Forms.TextBox();
            this.txt_iddocente = new System.Windows.Forms.TextBox();
            this.lbl_idportafolio = new System.Windows.Forms.Label();
            this.lbl_iddocente = new System.Windows.Forms.Label();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDocumento,
            this.Ruta,
            this.Estado,
            this.Add,
            this.Delete,
            this.Ver});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_idportafolio
            // 
            this.txt_idportafolio.Location = new System.Drawing.Point(84, 13);
            this.txt_idportafolio.Name = "txt_idportafolio";
            this.txt_idportafolio.Size = new System.Drawing.Size(100, 20);
            this.txt_idportafolio.TabIndex = 1;
            // 
            // txt_iddocente
            // 
            this.txt_iddocente.Location = new System.Drawing.Point(84, 39);
            this.txt_iddocente.Name = "txt_iddocente";
            this.txt_iddocente.Size = new System.Drawing.Size(100, 20);
            this.txt_iddocente.TabIndex = 1;
            // 
            // lbl_idportafolio
            // 
            this.lbl_idportafolio.AutoSize = true;
            this.lbl_idportafolio.Location = new System.Drawing.Point(9, 16);
            this.lbl_idportafolio.Name = "lbl_idportafolio";
            this.lbl_idportafolio.Size = new System.Drawing.Size(63, 13);
            this.lbl_idportafolio.TabIndex = 2;
            this.lbl_idportafolio.Text = "Id Portafolio";
            // 
            // lbl_iddocente
            // 
            this.lbl_iddocente.AutoSize = true;
            this.lbl_iddocente.Location = new System.Drawing.Point(9, 42);
            this.lbl_iddocente.Name = "lbl_iddocente";
            this.lbl_iddocente.Size = new System.Drawing.Size(60, 13);
            this.lbl_iddocente.TabIndex = 2;
            this.lbl_iddocente.Text = "Id Docente";
            // 
            // NombreDocumento
            // 
            this.NombreDocumento.HeaderText = "Nombre Documento";
            this.NombreDocumento.Name = "NombreDocumento";
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(238, 42);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(330, 42);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(425, 42);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(238, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // frm_mant_portafolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 334);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_iddocente);
            this.Controls.Add(this.lbl_idportafolio);
            this.Controls.Add(this.txt_iddocente);
            this.Controls.Add(this.txt_idportafolio);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_mant_portafolio";
            this.Text = "frm_mant_portafolio";
            this.Load += new System.EventHandler(this.frm_mant_portafolio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_idportafolio;
        private System.Windows.Forms.TextBox txt_iddocente;
        private System.Windows.Forms.Label lbl_idportafolio;
        private System.Windows.Forms.Label lbl_iddocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
    }
}