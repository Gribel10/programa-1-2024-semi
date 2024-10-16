
namespace Parcial2
{
    partial class Frm_usuario
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
            this.grbusuario = new System.Windows.Forms.GroupBox();
            this.lbltelefonoFrm_usuario = new System.Windows.Forms.Label();
            this.lbldirecciónFrm_usuario = new System.Windows.Forms.Label();
            this.txttelefonoFrm_usuario = new System.Windows.Forms.TextBox();
            this.lblnombreFrm_usuario = new System.Windows.Forms.Label();
            this.txtnombreFrm_usuario = new System.Windows.Forms.TextBox();
            this.lblclaveFrm_usuario = new System.Windows.Forms.Label();
            this.txtclaveFrm_usuario = new System.Windows.Forms.TextBox();
            this.lblusuarioFrm_usuario = new System.Windows.Forms.Label();
            this.txtusuarioFrm_usuario = new System.Windows.Forms.TextBox();
            this.grdusuarioFrm_usuario = new System.Windows.Forms.DataGridView();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNavegacionFrm_usuario = new System.Windows.Forms.GroupBox();
            this.lblRegistrosFrm_usuario = new System.Windows.Forms.Label();
            this.btnUltimoFrm_usuario = new System.Windows.Forms.Button();
            this.btnSiguienteFrm_usuario = new System.Windows.Forms.Button();
            this.btnAnteriorFrm_usuario = new System.Windows.Forms.Button();
            this.btnPrimeroFrm_usuario = new System.Windows.Forms.Button();
            this.grbEdicionFrm_usuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarFrm_usuario = new System.Windows.Forms.Button();
            this.btnModificarFrm_usuario = new System.Windows.Forms.Button();
            this.btnNuevoFrm_usuario = new System.Windows.Forms.Button();
            this.lblBuscarFrm_usuario = new System.Windows.Forms.Label();
            this.txtBuscarFrm_usuario = new System.Windows.Forms.TextBox();
            this.txtdirecciónFrm_usuario = new System.Windows.Forms.TextBox();
            this.grbusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuarioFrm_usuario)).BeginInit();
            this.grbNavegacionFrm_usuario.SuspendLayout();
            this.grbEdicionFrm_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbusuario
            // 
            this.grbusuario.Controls.Add(this.txtdirecciónFrm_usuario);
            this.grbusuario.Controls.Add(this.lbltelefonoFrm_usuario);
            this.grbusuario.Controls.Add(this.lbldirecciónFrm_usuario);
            this.grbusuario.Controls.Add(this.txttelefonoFrm_usuario);
            this.grbusuario.Controls.Add(this.lblnombreFrm_usuario);
            this.grbusuario.Controls.Add(this.txtnombreFrm_usuario);
            this.grbusuario.Controls.Add(this.lblclaveFrm_usuario);
            this.grbusuario.Controls.Add(this.txtclaveFrm_usuario);
            this.grbusuario.Controls.Add(this.lblusuarioFrm_usuario);
            this.grbusuario.Controls.Add(this.txtusuarioFrm_usuario);
            this.grbusuario.Enabled = false;
            this.grbusuario.Location = new System.Drawing.Point(13, 23);
            this.grbusuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbusuario.Name = "grbusuario";
            this.grbusuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbusuario.Size = new System.Drawing.Size(529, 383);
            this.grbusuario.TabIndex = 18;
            this.grbusuario.TabStop = false;
            this.grbusuario.Text = "usuario";
            // 
            // lbltelefonoFrm_usuario
            // 
            this.lbltelefonoFrm_usuario.AutoSize = true;
            this.lbltelefonoFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefonoFrm_usuario.Location = new System.Drawing.Point(38, 248);
            this.lbltelefonoFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefonoFrm_usuario.Name = "lbltelefonoFrm_usuario";
            this.lbltelefonoFrm_usuario.Size = new System.Drawing.Size(106, 29);
            this.lbltelefonoFrm_usuario.TabIndex = 9;
            this.lbltelefonoFrm_usuario.Text = "telefono:";
            // 
            // lbldirecciónFrm_usuario
            // 
            this.lbldirecciónFrm_usuario.AutoSize = true;
            this.lbldirecciónFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldirecciónFrm_usuario.Location = new System.Drawing.Point(41, 191);
            this.lbldirecciónFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldirecciónFrm_usuario.Name = "lbldirecciónFrm_usuario";
            this.lbldirecciónFrm_usuario.Size = new System.Drawing.Size(118, 29);
            this.lbldirecciónFrm_usuario.TabIndex = 7;
            this.lbldirecciónFrm_usuario.Text = "dirección:";
            // 
            // txttelefonoFrm_usuario
            // 
            this.txttelefonoFrm_usuario.Location = new System.Drawing.Point(175, 255);
            this.txttelefonoFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefonoFrm_usuario.Name = "txttelefonoFrm_usuario";
            this.txttelefonoFrm_usuario.Size = new System.Drawing.Size(132, 22);
            this.txttelefonoFrm_usuario.TabIndex = 6;
            // 
            // lblnombreFrm_usuario
            // 
            this.lblnombreFrm_usuario.AutoSize = true;
            this.lblnombreFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreFrm_usuario.Location = new System.Drawing.Point(41, 143);
            this.lblnombreFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombreFrm_usuario.Name = "lblnombreFrm_usuario";
            this.lblnombreFrm_usuario.Size = new System.Drawing.Size(102, 29);
            this.lblnombreFrm_usuario.TabIndex = 5;
            this.lblnombreFrm_usuario.Text = "nombre:";
            // 
            // txtnombreFrm_usuario
            // 
            this.txtnombreFrm_usuario.Location = new System.Drawing.Point(175, 148);
            this.txtnombreFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreFrm_usuario.Name = "txtnombreFrm_usuario";
            this.txtnombreFrm_usuario.Size = new System.Drawing.Size(333, 22);
            this.txtnombreFrm_usuario.TabIndex = 4;
            // 
            // lblclaveFrm_usuario
            // 
            this.lblclaveFrm_usuario.AutoSize = true;
            this.lblclaveFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclaveFrm_usuario.Location = new System.Drawing.Point(41, 94);
            this.lblclaveFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclaveFrm_usuario.Name = "lblclaveFrm_usuario";
            this.lblclaveFrm_usuario.Size = new System.Drawing.Size(75, 29);
            this.lblclaveFrm_usuario.TabIndex = 3;
            this.lblclaveFrm_usuario.Text = "clave:";
            // 
            // txtclaveFrm_usuario
            // 
            this.txtclaveFrm_usuario.Location = new System.Drawing.Point(175, 98);
            this.txtclaveFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtclaveFrm_usuario.Name = "txtclaveFrm_usuario";
            this.txtclaveFrm_usuario.Size = new System.Drawing.Size(333, 22);
            this.txtclaveFrm_usuario.TabIndex = 2;
            // 
            // lblusuarioFrm_usuario
            // 
            this.lblusuarioFrm_usuario.AutoSize = true;
            this.lblusuarioFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioFrm_usuario.Location = new System.Drawing.Point(41, 46);
            this.lblusuarioFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuarioFrm_usuario.Name = "lblusuarioFrm_usuario";
            this.lblusuarioFrm_usuario.Size = new System.Drawing.Size(98, 29);
            this.lblusuarioFrm_usuario.TabIndex = 1;
            this.lblusuarioFrm_usuario.Text = "usuario:";
            // 
            // txtusuarioFrm_usuario
            // 
            this.txtusuarioFrm_usuario.Location = new System.Drawing.Point(175, 50);
            this.txtusuarioFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuarioFrm_usuario.Name = "txtusuarioFrm_usuario";
            this.txtusuarioFrm_usuario.Size = new System.Drawing.Size(132, 22);
            this.txtusuarioFrm_usuario.TabIndex = 0;
            // 
            // grdusuarioFrm_usuario
            // 
            this.grdusuarioFrm_usuario.AllowUserToAddRows = false;
            this.grdusuarioFrm_usuario.AllowUserToDeleteRows = false;
            this.grdusuarioFrm_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdusuarioFrm_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumno,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdusuarioFrm_usuario.Location = new System.Drawing.Point(564, 96);
            this.grdusuarioFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.grdusuarioFrm_usuario.Name = "grdusuarioFrm_usuario";
            this.grdusuarioFrm_usuario.ReadOnly = true;
            this.grdusuarioFrm_usuario.RowHeadersWidth = 51;
            this.grdusuarioFrm_usuario.Size = new System.Drawing.Size(579, 310);
            this.grdusuarioFrm_usuario.TabIndex = 19;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "ID";
            this.idAlumno.MinimumWidth = 6;
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            this.idAlumno.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // grbNavegacionFrm_usuario
            // 
            this.grbNavegacionFrm_usuario.Controls.Add(this.lblRegistrosFrm_usuario);
            this.grbNavegacionFrm_usuario.Controls.Add(this.btnUltimoFrm_usuario);
            this.grbNavegacionFrm_usuario.Controls.Add(this.btnSiguienteFrm_usuario);
            this.grbNavegacionFrm_usuario.Controls.Add(this.btnAnteriorFrm_usuario);
            this.grbNavegacionFrm_usuario.Controls.Add(this.btnPrimeroFrm_usuario);
            this.grbNavegacionFrm_usuario.Location = new System.Drawing.Point(36, 450);
            this.grbNavegacionFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionFrm_usuario.Name = "grbNavegacionFrm_usuario";
            this.grbNavegacionFrm_usuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionFrm_usuario.Size = new System.Drawing.Size(284, 71);
            this.grbNavegacionFrm_usuario.TabIndex = 20;
            this.grbNavegacionFrm_usuario.TabStop = false;
            this.grbNavegacionFrm_usuario.Text = "Navegacion";
            // 
            // lblRegistrosFrm_usuario
            // 
            this.lblRegistrosFrm_usuario.AutoSize = true;
            this.lblRegistrosFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosFrm_usuario.Location = new System.Drawing.Point(101, 30);
            this.lblRegistrosFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosFrm_usuario.Name = "lblRegistrosFrm_usuario";
            this.lblRegistrosFrm_usuario.Size = new System.Drawing.Size(77, 29);
            this.lblRegistrosFrm_usuario.TabIndex = 10;
            this.lblRegistrosFrm_usuario.Text = "x de n";
            // 
            // btnUltimoFrm_usuario
            // 
            this.btnUltimoFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoFrm_usuario.Location = new System.Drawing.Point(229, 17);
            this.btnUltimoFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoFrm_usuario.Name = "btnUltimoFrm_usuario";
            this.btnUltimoFrm_usuario.Size = new System.Drawing.Size(47, 47);
            this.btnUltimoFrm_usuario.TabIndex = 3;
            this.btnUltimoFrm_usuario.Text = ">|";
            this.btnUltimoFrm_usuario.UseVisualStyleBackColor = true;
            this.btnUltimoFrm_usuario.Click += new System.EventHandler(this.btnUltimoFrm_usuario_Click);
            // 
            // btnSiguienteFrm_usuario
            // 
            this.btnSiguienteFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteFrm_usuario.Location = new System.Drawing.Point(185, 17);
            this.btnSiguienteFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteFrm_usuario.Name = "btnSiguienteFrm_usuario";
            this.btnSiguienteFrm_usuario.Size = new System.Drawing.Size(47, 47);
            this.btnSiguienteFrm_usuario.TabIndex = 2;
            this.btnSiguienteFrm_usuario.Text = ">";
            this.btnSiguienteFrm_usuario.UseVisualStyleBackColor = true;
            this.btnSiguienteFrm_usuario.Click += new System.EventHandler(this.btnSiguienteFrm_usuario_Click);
            // 
            // btnAnteriorFrm_usuario
            // 
            this.btnAnteriorFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorFrm_usuario.Location = new System.Drawing.Point(53, 22);
            this.btnAnteriorFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorFrm_usuario.Name = "btnAnteriorFrm_usuario";
            this.btnAnteriorFrm_usuario.Size = new System.Drawing.Size(47, 47);
            this.btnAnteriorFrm_usuario.TabIndex = 1;
            this.btnAnteriorFrm_usuario.Text = "<";
            this.btnAnteriorFrm_usuario.UseVisualStyleBackColor = true;
            this.btnAnteriorFrm_usuario.Click += new System.EventHandler(this.btnAnteriorFrm_usuario_Click);
            // 
            // btnPrimeroFrm_usuario
            // 
            this.btnPrimeroFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroFrm_usuario.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroFrm_usuario.Name = "btnPrimeroFrm_usuario";
            this.btnPrimeroFrm_usuario.Size = new System.Drawing.Size(47, 47);
            this.btnPrimeroFrm_usuario.TabIndex = 0;
            this.btnPrimeroFrm_usuario.Text = "|<";
            this.btnPrimeroFrm_usuario.UseVisualStyleBackColor = true;
            this.btnPrimeroFrm_usuario.Click += new System.EventHandler(this.btnPrimeroFrm_usuario_Click);
            // 
            // grbEdicionFrm_usuario
            // 
            this.grbEdicionFrm_usuario.Controls.Add(this.btnEliminarFrm_usuario);
            this.grbEdicionFrm_usuario.Controls.Add(this.btnModificarFrm_usuario);
            this.grbEdicionFrm_usuario.Controls.Add(this.btnNuevoFrm_usuario);
            this.grbEdicionFrm_usuario.Location = new System.Drawing.Point(368, 450);
            this.grbEdicionFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionFrm_usuario.Name = "grbEdicionFrm_usuario";
            this.grbEdicionFrm_usuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionFrm_usuario.Size = new System.Drawing.Size(392, 71);
            this.grbEdicionFrm_usuario.TabIndex = 14;
            this.grbEdicionFrm_usuario.TabStop = false;
            this.grbEdicionFrm_usuario.Text = "Navegacion";
            // 
            // btnEliminarFrm_usuario
            // 
            this.btnEliminarFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFrm_usuario.Location = new System.Drawing.Point(252, 23);
            this.btnEliminarFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFrm_usuario.Name = "btnEliminarFrm_usuario";
            this.btnEliminarFrm_usuario.Size = new System.Drawing.Size(129, 47);
            this.btnEliminarFrm_usuario.TabIndex = 6;
            this.btnEliminarFrm_usuario.Text = "Eliminar";
            this.btnEliminarFrm_usuario.UseVisualStyleBackColor = true;
            this.btnEliminarFrm_usuario.Click += new System.EventHandler(this.btnEliminarFrm_usuario_Click);
            // 
            // btnModificarFrm_usuario
            // 
            this.btnModificarFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFrm_usuario.Location = new System.Drawing.Point(116, 23);
            this.btnModificarFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarFrm_usuario.Name = "btnModificarFrm_usuario";
            this.btnModificarFrm_usuario.Size = new System.Drawing.Size(139, 47);
            this.btnModificarFrm_usuario.TabIndex = 5;
            this.btnModificarFrm_usuario.Text = "Modificar";
            this.btnModificarFrm_usuario.UseVisualStyleBackColor = true;
            this.btnModificarFrm_usuario.Click += new System.EventHandler(this.btnModificarFrm_usuario_Click);
            // 
            // btnNuevoFrm_usuario
            // 
            this.btnNuevoFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoFrm_usuario.Location = new System.Drawing.Point(8, 23);
            this.btnNuevoFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoFrm_usuario.Name = "btnNuevoFrm_usuario";
            this.btnNuevoFrm_usuario.Size = new System.Drawing.Size(111, 47);
            this.btnNuevoFrm_usuario.TabIndex = 4;
            this.btnNuevoFrm_usuario.Text = "Nuevo";
            this.btnNuevoFrm_usuario.UseVisualStyleBackColor = true;
            this.btnNuevoFrm_usuario.Click += new System.EventHandler(this.btnNuevoFrm_usuario_Click);
            // 
            // lblBuscarFrm_usuario
            // 
            this.lblBuscarFrm_usuario.AutoSize = true;
            this.lblBuscarFrm_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarFrm_usuario.Location = new System.Drawing.Point(559, 23);
            this.lblBuscarFrm_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarFrm_usuario.Name = "lblBuscarFrm_usuario";
            this.lblBuscarFrm_usuario.Size = new System.Drawing.Size(117, 29);
            this.lblBuscarFrm_usuario.TabIndex = 16;
            this.lblBuscarFrm_usuario.Text = "BUSCAR:";
            this.lblBuscarFrm_usuario.Click += new System.EventHandler(this.lblBuscarFrm_usuario_Click);
            // 
            // txtBuscarFrm_usuario
            // 
            this.txtBuscarFrm_usuario.Location = new System.Drawing.Point(684, 23);
            this.txtBuscarFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarFrm_usuario.Name = "txtBuscarFrm_usuario";
            this.txtBuscarFrm_usuario.Size = new System.Drawing.Size(461, 22);
            this.txtBuscarFrm_usuario.TabIndex = 21;
            this.txtBuscarFrm_usuario.TextChanged += new System.EventHandler(this.txtBuscarFrm_usuario_TextChanged);
            // 
            // txtdirecciónFrm_usuario
            // 
            this.txtdirecciónFrm_usuario.Location = new System.Drawing.Point(175, 198);
            this.txtdirecciónFrm_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtdirecciónFrm_usuario.Name = "txtdirecciónFrm_usuario";
            this.txtdirecciónFrm_usuario.Size = new System.Drawing.Size(132, 22);
            this.txtdirecciónFrm_usuario.TabIndex = 10;
            // 
            // Frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 547);
            this.Controls.Add(this.txtBuscarFrm_usuario);
            this.Controls.Add(this.lblBuscarFrm_usuario);
            this.Controls.Add(this.grbEdicionFrm_usuario);
            this.Controls.Add(this.grbNavegacionFrm_usuario);
            this.Controls.Add(this.grdusuarioFrm_usuario);
            this.Controls.Add(this.grbusuario);
            this.Name = "Frm_usuario";
            this.Text = "Frm_usuario";
            this.Load += new System.EventHandler(this.Frm_usuario_Load);
            this.grbusuario.ResumeLayout(false);
            this.grbusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuarioFrm_usuario)).EndInit();
            this.grbNavegacionFrm_usuario.ResumeLayout(false);
            this.grbNavegacionFrm_usuario.PerformLayout();
            this.grbEdicionFrm_usuario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbusuario;
        private System.Windows.Forms.Label lbltelefonoFrm_usuario;
        private System.Windows.Forms.Label lbldirecciónFrm_usuario;
        private System.Windows.Forms.TextBox txttelefonoFrm_usuario;
        private System.Windows.Forms.Label lblnombreFrm_usuario;
        private System.Windows.Forms.TextBox txtnombreFrm_usuario;
        private System.Windows.Forms.Label lblclaveFrm_usuario;
        private System.Windows.Forms.TextBox txtclaveFrm_usuario;
        private System.Windows.Forms.Label lblusuarioFrm_usuario;
        private System.Windows.Forms.TextBox txtusuarioFrm_usuario;
        private System.Windows.Forms.DataGridView grdusuarioFrm_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.GroupBox grbNavegacionFrm_usuario;
        private System.Windows.Forms.Label lblRegistrosFrm_usuario;
        private System.Windows.Forms.Button btnUltimoFrm_usuario;
        private System.Windows.Forms.Button btnSiguienteFrm_usuario;
        private System.Windows.Forms.Button btnAnteriorFrm_usuario;
        private System.Windows.Forms.Button btnPrimeroFrm_usuario;
        private System.Windows.Forms.GroupBox grbEdicionFrm_usuario;
        private System.Windows.Forms.Button btnEliminarFrm_usuario;
        private System.Windows.Forms.Button btnModificarFrm_usuario;
        private System.Windows.Forms.Button btnNuevoFrm_usuario;
        private System.Windows.Forms.Label lblBuscarFrm_usuario;
        private System.Windows.Forms.TextBox txtBuscarFrm_usuario;
        private System.Windows.Forms.TextBox txtdirecciónFrm_usuario;
    }
}