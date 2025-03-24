namespace wReservasHotel
{
    partial class formReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoches = new System.Windows.Forms.TextBox();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.editarNombre = new System.Windows.Forms.TextBox();
            this.editarFecha = new System.Windows.Forms.DateTimePicker();
            this.editarHabitacion = new System.Windows.Forms.TextBox();
            this.editarTipo = new System.Windows.Forms.ComboBox();
            this.editarNoches = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservar o seleccionar (Habitacion y fecha)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(90, 116);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(273, 22);
            this.dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Habitación";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(111, 165);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(100, 22);
            this.txtHabitacion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(90, 214);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(273, 24);
            this.cmbTipo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Noches";
            // 
            // txtNoches
            // 
            this.txtNoches.Location = new System.Drawing.Point(111, 271);
            this.txtNoches.Name = "txtNoches";
            this.txtNoches.Size = new System.Drawing.Size(84, 22);
            this.txtNoches.TabIndex = 10;
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.HorizontalScrollbar = true;
            this.listBoxReservas.ItemHeight = 16;
            this.listBoxReservas.Location = new System.Drawing.Point(674, 67);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(373, 212);
            this.listBoxReservas.TabIndex = 11;
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.SystemColors.Info;
            this.btnReserva.Location = new System.Drawing.Point(16, 343);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(108, 38);
            this.btnReserva.TabIndex = 12;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(444, 343);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Location = new System.Drawing.Point(205, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 38);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // editarNombre
            // 
            this.editarNombre.Location = new System.Drawing.Point(418, 67);
            this.editarNombre.Name = "editarNombre";
            this.editarNombre.Size = new System.Drawing.Size(214, 22);
            this.editarNombre.TabIndex = 15;
            // 
            // editarFecha
            // 
            this.editarFecha.Location = new System.Drawing.Point(417, 120);
            this.editarFecha.Name = "editarFecha";
            this.editarFecha.Size = new System.Drawing.Size(214, 22);
            this.editarFecha.TabIndex = 16;
            // 
            // editarHabitacion
            // 
            this.editarHabitacion.Location = new System.Drawing.Point(417, 170);
            this.editarHabitacion.Name = "editarHabitacion";
            this.editarHabitacion.Size = new System.Drawing.Size(165, 22);
            this.editarHabitacion.TabIndex = 17;
            // 
            // editarTipo
            // 
            this.editarTipo.FormattingEnabled = true;
            this.editarTipo.Location = new System.Drawing.Point(417, 217);
            this.editarTipo.Name = "editarTipo";
            this.editarTipo.Size = new System.Drawing.Size(214, 24);
            this.editarTipo.TabIndex = 18;
            // 
            // editarNoches
            // 
            this.editarNoches.Location = new System.Drawing.Point(420, 270);
            this.editarNoches.Name = "editarNoches";
            this.editarNoches.Size = new System.Drawing.Size(101, 22);
            this.editarNoches.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "EDITAR";
            // 
            // formReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editarNoches);
            this.Controls.Add(this.editarTipo);
            this.Controls.Add(this.editarHabitacion);
            this.Controls.Add(this.editarFecha);
            this.Controls.Add(this.editarNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.listBoxReservas);
            this.Controls.Add(this.txtNoches);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formReservas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoches;
        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox editarNombre;
        private System.Windows.Forms.DateTimePicker editarFecha;
        private System.Windows.Forms.TextBox editarHabitacion;
        private System.Windows.Forms.ComboBox editarTipo;
        private System.Windows.Forms.TextBox editarNoches;
        private System.Windows.Forms.Label label7;
    }
}

