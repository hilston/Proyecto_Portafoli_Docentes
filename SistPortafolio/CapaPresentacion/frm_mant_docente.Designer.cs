namespace CapaPresentacion
{
    partial class frm_mant_docente
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.txt_iddocente = new System.Windows.Forms.TextBox();
            this.lbl_materno = new System.Windows.Forms.Label();
            this.lbl_paterno = new System.Windows.Forms.Label();
            this.lbl_iddocente = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 164);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(307, 300);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(208, 300);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Actualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(105, 300);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 14;
            this.btn_Insert.Text = "Agregar";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(332, 30);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(105, 62);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(199, 20);
            this.txt_nombres.TabIndex = 8;
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(106, 122);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(199, 20);
            this.txt_materno.TabIndex = 9;
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(106, 92);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(198, 20);
            this.txt_paterno.TabIndex = 10;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(23, 65);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(52, 13);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // txt_iddocente
            // 
            this.txt_iddocente.Location = new System.Drawing.Point(105, 33);
            this.txt_iddocente.Name = "txt_iddocente";
            this.txt_iddocente.Size = new System.Drawing.Size(198, 20);
            this.txt_iddocente.TabIndex = 11;
            // 
            // lbl_materno
            // 
            this.lbl_materno.AutoSize = true;
            this.lbl_materno.Location = new System.Drawing.Point(23, 125);
            this.lbl_materno.Name = "lbl_materno";
            this.lbl_materno.Size = new System.Drawing.Size(68, 13);
            this.lbl_materno.TabIndex = 5;
            this.lbl_materno.Text = "Ap. Materno:";
            // 
            // lbl_paterno
            // 
            this.lbl_paterno.AutoSize = true;
            this.lbl_paterno.Location = new System.Drawing.Point(23, 95);
            this.lbl_paterno.Name = "lbl_paterno";
            this.lbl_paterno.Size = new System.Drawing.Size(66, 13);
            this.lbl_paterno.TabIndex = 6;
            this.lbl_paterno.Text = "Ap. Paterno:";
            // 
            // lbl_iddocente
            // 
            this.lbl_iddocente.AutoSize = true;
            this.lbl_iddocente.Location = new System.Drawing.Point(23, 36);
            this.lbl_iddocente.Name = "lbl_iddocente";
            this.lbl_iddocente.Size = new System.Drawing.Size(66, 13);
            this.lbl_iddocente.TabIndex = 7;
            this.lbl_iddocente.Text = "Id. Docente:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(23, 185);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(23, 215);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 5;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(23, 155);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 4;
            this.lbl_dni.Text = "DNI:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(107, 182);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(198, 20);
            this.txt_telefono.TabIndex = 10;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(107, 212);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(199, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(106, 152);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(199, 20);
            this.txt_dni.TabIndex = 8;
            // 
            // frm_mant_docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_iddocente);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_materno);
            this.Controls.Add(this.lbl_paterno);
            this.Controls.Add(this.lbl_iddocente);
            this.Name = "frm_mant_docente";
            this.Text = "frm_mant_docente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txt_iddocente;
        private System.Windows.Forms.Label lbl_materno;
        private System.Windows.Forms.Label lbl_paterno;
        private System.Windows.Forms.Label lbl_iddocente;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_dni;
    }
}