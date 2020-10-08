namespace Programacion2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtMateriaCarrera = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.groupBoxRol = new System.Windows.Forms.GroupBox();
            this.rbEstud = new System.Windows.Forms.RadioButton();
            this.rbProf = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia_Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblmessaje = new System.Windows.Forms.Label();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(304, 217);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Legajo";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(314, 166);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera";
            this.lblCarrera.Visible = false;
            // 
            // txtMateriaCarrera
            // 
            this.txtMateriaCarrera.Enabled = false;
            this.txtMateriaCarrera.Location = new System.Drawing.Point(394, 163);
            this.txtMateriaCarrera.Name = "txtMateriaCarrera";
            this.txtMateriaCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtMateriaCarrera.TabIndex = 13;
            this.txtMateriaCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMateriaCarrera_KeyPress);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(394, 130);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 14;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(92, 123);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 15;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rbFem);
            this.groupBoxSexo.Controls.Add(this.rbMasc);
            this.groupBoxSexo.Location = new System.Drawing.Point(50, 174);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(117, 71);
            this.groupBoxSexo.TabIndex = 16;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(22, 42);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(71, 17);
            this.rbFem.TabIndex = 1;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(22, 19);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // groupBoxRol
            // 
            this.groupBoxRol.Controls.Add(this.rbEstud);
            this.groupBoxRol.Controls.Add(this.rbProf);
            this.groupBoxRol.Location = new System.Drawing.Point(351, 53);
            this.groupBoxRol.Name = "groupBoxRol";
            this.groupBoxRol.Size = new System.Drawing.Size(117, 71);
            this.groupBoxRol.TabIndex = 17;
            this.groupBoxRol.TabStop = false;
            this.groupBoxRol.Text = "Rol";
            this.groupBoxRol.Enter += new System.EventHandler(this.groupBoxRol_Enter);
            // 
            // rbEstud
            // 
            this.rbEstud.AutoSize = true;
            this.rbEstud.Location = new System.Drawing.Point(22, 42);
            this.rbEstud.Name = "rbEstud";
            this.rbEstud.Size = new System.Drawing.Size(60, 17);
            this.rbEstud.TabIndex = 1;
            this.rbEstud.TabStop = true;
            this.rbEstud.Text = "Alumno";
            this.rbEstud.UseVisualStyleBackColor = true;
            this.rbEstud.CheckedChanged += new System.EventHandler(this.rbEstud_CheckedChanged);
            // 
            // rbProf
            // 
            this.rbProf.AutoSize = true;
            this.rbProf.Location = new System.Drawing.Point(22, 19);
            this.rbProf.Name = "rbProf";
            this.rbProf.Size = new System.Drawing.Size(64, 17);
            this.rbProf.TabIndex = 0;
            this.rbProf.TabStop = true;
            this.rbProf.Text = "Profesor";
            this.rbProf.UseVisualStyleBackColor = true;
            this.rbProf.CheckedChanged += new System.EventHandler(this.rbProf_CheckedChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Dni,
            this.FecNac,
            this.Sexo,
            this.Legajo,
            this.Materia_Carrera});
            this.dgv.Location = new System.Drawing.Point(50, 265);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(724, 134);
            this.dgv.TabIndex = 20;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            // 
            // FecNac
            // 
            this.FecNac.HeaderText = "FecNac";
            this.FecNac.Name = "FecNac";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Materia_Carrera
            // 
            this.Materia_Carrera.HeaderText = "Materia_Carrera";
            this.Materia_Carrera.Name = "Materia_Carrera";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fec Nac";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMateria.Location = new System.Drawing.Point(314, 166);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 18;
            this.lblMateria.Text = "Materia";
            this.lblMateria.Visible = false;
            // 
            // lblmessaje
            // 
            this.lblmessaje.AutoSize = true;
            this.lblmessaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblmessaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessaje.ForeColor = System.Drawing.Color.Red;
            this.lblmessaje.Location = new System.Drawing.Point(299, 166);
            this.lblmessaje.Name = "lblmessaje";
            this.lblmessaje.Size = new System.Drawing.Size(89, 13);
            this.lblmessaje.TabIndex = 19;
            this.lblmessaje.Text = "Ingrese su Rol";
            this.lblmessaje.Click += new System.EventHandler(this.lblmessaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblmessaje);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.groupBoxRol);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtMateriaCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxRol.ResumeLayout(false);
            this.groupBoxRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtMateriaCarrera;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.GroupBox groupBoxRol;
        private System.Windows.Forms.RadioButton rbEstud;
        private System.Windows.Forms.RadioButton rbProf;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia_Carrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblmessaje;
    }
}

