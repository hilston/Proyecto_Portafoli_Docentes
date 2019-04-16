namespace CapaPresentacion
{
    partial class frm_mant_usuario
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
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_idusuario = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_materno = new System.Windows.Forms.Label();
            this.lbl_paterno = new System.Windows.Forms.Label();
            this.lbl_idusuario = new System.Windows.Forms.Label();
            this.lbl_Perfil = new System.Windows.Forms.Label();
            this.txt_perfil = new System.Windows.Forms.TextBox();
            this.lbl_nick = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 164);
            this.dataGridView1.TabIndex = 35;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(309, 329);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(210, 329);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "Actualizar";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(107, 329);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 33;
            this.btn_Insert.Text = "Agregar";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(334, 8);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 34;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(108, 162);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(199, 20);
            this.txt_dni.TabIndex = 24;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(107, 72);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(199, 20);
            this.txt_nombres.TabIndex = 25;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(109, 222);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(199, 20);
            this.txt_direccion.TabIndex = 26;
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(108, 132);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(199, 20);
            this.txt_materno.TabIndex = 27;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(109, 192);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(198, 20);
            this.txt_telefono.TabIndex = 28;
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(108, 102);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(198, 20);
            this.txt_paterno.TabIndex = 29;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(25, 165);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 18;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(25, 75);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(52, 13);
            this.lbl_Nombres.TabIndex = 17;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(25, 225);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(55, 13);
            this.lbl_direccion.TabIndex = 20;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_idusuario
            // 
            this.txt_idusuario.Location = new System.Drawing.Point(107, 11);
            this.txt_idusuario.Name = "txt_idusuario";
            this.txt_idusuario.Size = new System.Drawing.Size(198, 20);
            this.txt_idusuario.TabIndex = 30;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(25, 195);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 21;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_materno
            // 
            this.lbl_materno.AutoSize = true;
            this.lbl_materno.Location = new System.Drawing.Point(25, 135);
            this.lbl_materno.Name = "lbl_materno";
            this.lbl_materno.Size = new System.Drawing.Size(68, 13);
            this.lbl_materno.TabIndex = 19;
            this.lbl_materno.Text = "Ap. Materno:";
            // 
            // lbl_paterno
            // 
            this.lbl_paterno.AutoSize = true;
            this.lbl_paterno.Location = new System.Drawing.Point(25, 105);
            this.lbl_paterno.Name = "lbl_paterno";
            this.lbl_paterno.Size = new System.Drawing.Size(66, 13);
            this.lbl_paterno.TabIndex = 22;
            this.lbl_paterno.Text = "Ap. Paterno:";
            // 
            // lbl_idusuario
            // 
            this.lbl_idusuario.AutoSize = true;
            this.lbl_idusuario.Location = new System.Drawing.Point(25, 14);
            this.lbl_idusuario.Name = "lbl_idusuario";
            this.lbl_idusuario.Size = new System.Drawing.Size(61, 13);
            this.lbl_idusuario.TabIndex = 23;
            this.lbl_idusuario.Text = "Id. Usuario:";
            // 
            // lbl_Perfil
            // 
            this.lbl_Perfil.AutoSize = true;
            this.lbl_Perfil.Location = new System.Drawing.Point(25, 42);
            this.lbl_Perfil.Name = "lbl_Perfil";
            this.lbl_Perfil.Size = new System.Drawing.Size(33, 13);
            this.lbl_Perfil.TabIndex = 17;
            this.lbl_Perfil.Text = "Perfil:";
            // 
            // txt_perfil
            // 
            this.txt_perfil.Location = new System.Drawing.Point(107, 39);
            this.txt_perfil.Name = "txt_perfil";
            this.txt_perfil.Size = new System.Drawing.Size(199, 20);
            this.txt_perfil.TabIndex = 25;
            // 
            // lbl_nick
            // 
            this.lbl_nick.AutoSize = true;
            this.lbl_nick.Location = new System.Drawing.Point(23, 251);
            this.lbl_nick.Name = "lbl_nick";
            this.lbl_nick.Size = new System.Drawing.Size(58, 13);
            this.lbl_nick.TabIndex = 21;
            this.lbl_nick.Text = "Nickname:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(23, 281);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "Password:";
            // 
            // txt_nickname
            // 
            this.txt_nickname.Location = new System.Drawing.Point(107, 248);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(198, 20);
            this.txt_nickname.TabIndex = 28;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(107, 278);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(199, 20);
            this.txt_password.TabIndex = 26;
            // 
            // frm_mant_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_perfil);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_Perfil);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_nick);
            this.Controls.Add(this.txt_idusuario);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_materno);
            this.Controls.Add(this.lbl_paterno);
            this.Controls.Add(this.lbl_idusuario);
            this.Name = "frm_mant_usuario";
            this.Text = "frm_mant_usuario";
            this.Load += new System.EventHandler(this.frm_mant_usuario_Load);
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
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_idusuario;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_materno;
        private System.Windows.Forms.Label lbl_paterno;
        private System.Windows.Forms.Label lbl_idusuario;
        private System.Windows.Forms.Label lbl_Perfil;
        private System.Windows.Forms.TextBox txt_perfil;
        private System.Windows.Forms.Label lbl_nick;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.TextBox txt_password;
    }
}