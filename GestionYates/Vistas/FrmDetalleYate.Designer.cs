
namespace GestionYates.Vistas
{
    partial class FrmDetalleYate
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotalAlquileres = new System.Windows.Forms.Button();
            this.btnActualizarFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.rdbEnReparacion = new System.Windows.Forms.RadioButton();
            this.rdbDisponible = new System.Windows.Forms.RadioButton();
            this.rdbAlquilado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textCodigoYate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.grpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLE DEL YATE";
            // 
            // btnTotalAlquileres
            // 
            this.btnTotalAlquileres.Location = new System.Drawing.Point(12, 526);
            this.btnTotalAlquileres.Name = "btnTotalAlquileres";
            this.btnTotalAlquileres.Size = new System.Drawing.Size(183, 32);
            this.btnTotalAlquileres.TabIndex = 2;
            this.btnTotalAlquileres.Text = "TOTAL ALQUILERES";
            this.btnTotalAlquileres.UseVisualStyleBackColor = true;
            // 
            // btnActualizarFoto
            // 
            this.btnActualizarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarFoto.Location = new System.Drawing.Point(237, 526);
            this.btnActualizarFoto.Name = "btnActualizarFoto";
            this.btnActualizarFoto.Size = new System.Drawing.Size(228, 32);
            this.btnActualizarFoto.TabIndex = 3;
            this.btnActualizarFoto.Text = "ACTUALIZAR FOTO Y ESTADO";
            this.btnActualizarFoto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(499, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(183, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(191, 124);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(397, 100);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(88, 253);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // nupPrecio
            // 
            this.nupPrecio.Location = new System.Drawing.Point(191, 253);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(120, 22);
            this.nupPrecio.TabIndex = 8;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(368, 253);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(220, 232);
            this.pcbFoto.TabIndex = 9;
            this.pcbFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Foto:";
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.Location = new System.Drawing.Point(310, 443);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(49, 32);
            this.btnAbrirFoto.TabIndex = 11;
            this.btnAbrirFoto.Text = "...";
            this.btnAbrirFoto.UseVisualStyleBackColor = true;
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.rdbEnReparacion);
            this.grpEstado.Controls.Add(this.rdbDisponible);
            this.grpEstado.Controls.Add(this.rdbAlquilado);
            this.grpEstado.Location = new System.Drawing.Point(91, 293);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(220, 125);
            this.grpEstado.TabIndex = 12;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado";
            // 
            // rdbEnReparacion
            // 
            this.rdbEnReparacion.AutoSize = true;
            this.rdbEnReparacion.Location = new System.Drawing.Point(53, 83);
            this.rdbEnReparacion.Name = "rdbEnReparacion";
            this.rdbEnReparacion.Size = new System.Drawing.Size(118, 21);
            this.rdbEnReparacion.TabIndex = 2;
            this.rdbEnReparacion.TabStop = true;
            this.rdbEnReparacion.Text = "En reparación";
            this.rdbEnReparacion.UseVisualStyleBackColor = true;
            // 
            // rdbDisponible
            // 
            this.rdbDisponible.AutoSize = true;
            this.rdbDisponible.Location = new System.Drawing.Point(53, 56);
            this.rdbDisponible.Name = "rdbDisponible";
            this.rdbDisponible.Size = new System.Drawing.Size(95, 21);
            this.rdbDisponible.TabIndex = 1;
            this.rdbDisponible.TabStop = true;
            this.rdbDisponible.Text = "Disponible";
            this.rdbDisponible.UseVisualStyleBackColor = true;
            // 
            // rdbAlquilado
            // 
            this.rdbAlquilado.AutoSize = true;
            this.rdbAlquilado.Location = new System.Drawing.Point(53, 29);
            this.rdbAlquilado.Name = "rdbAlquilado";
            this.rdbAlquilado.Size = new System.Drawing.Size(87, 21);
            this.rdbAlquilado.TabIndex = 0;
            this.rdbAlquilado.TabStop = true;
            this.rdbAlquilado.Text = "Alquilado";
            this.rdbAlquilado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Código del yate:";
            // 
            // textCodigoYate
            // 
            this.textCodigoYate.Location = new System.Drawing.Point(283, 89);
            this.textCodigoYate.Name = "textCodigoYate";
            this.textCodigoYate.Size = new System.Drawing.Size(182, 22);
            this.textCodigoYate.TabIndex = 14;
            // 
            // FrmDetalleYate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 596);
            this.Controls.Add(this.textCodigoYate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.btnAbrirFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarFoto);
            this.Controls.Add(this.btnTotalAlquileres);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleYate";
            this.Text = "FrmDetalleYate";
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTotalAlquileres;
        private System.Windows.Forms.Button btnActualizarFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nupPrecio;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.RadioButton rdbEnReparacion;
        private System.Windows.Forms.RadioButton rdbDisponible;
        private System.Windows.Forms.RadioButton rdbAlquilado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCodigoYate;
    }
}