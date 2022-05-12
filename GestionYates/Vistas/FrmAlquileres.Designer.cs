
namespace GestionYates.Vistas
{
    partial class FrmAlquileres
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
            this.btnAlquilerMasLargo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerDatosYate = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALQUILERES";
            // 
            // btnAlquilerMasLargo
            // 
            this.btnAlquilerMasLargo.Location = new System.Drawing.Point(57, 332);
            this.btnAlquilerMasLargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlquilerMasLargo.Name = "btnAlquilerMasLargo";
            this.btnAlquilerMasLargo.Size = new System.Drawing.Size(137, 26);
            this.btnAlquilerMasLargo.TabIndex = 1;
            this.btnAlquilerMasLargo.Text = "ALQUILER MAS LARGO";
            this.btnAlquilerMasLargo.UseVisualStyleBackColor = true;
            this.btnAlquilerMasLargo.Click += new System.EventHandler(this.btnAlquilerMasLargo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(216, 332);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 26);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerDatosYate
            // 
            this.btnVerDatosYate.Location = new System.Drawing.Point(374, 332);
            this.btnVerDatosYate.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerDatosYate.Name = "btnVerDatosYate";
            this.btnVerDatosYate.Size = new System.Drawing.Size(137, 26);
            this.btnVerDatosYate.TabIndex = 3;
            this.btnVerDatosYate.Text = "VER DATOS DEL YATE";
            this.btnVerDatosYate.UseVisualStyleBackColor = true;
            this.btnVerDatosYate.Click += new System.EventHandler(this.btnVerDatosYate_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(541, 332);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 26);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(263, 77);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(191, 20);
            this.txtPuerto.TabIndex = 6;
            this.txtPuerto.TextChanged += new System.EventHandler(this.txtPuerto_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 206);
            this.dataGridView1.TabIndex = 7;
            // 
            // FrmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerDatosYate);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlquilerMasLargo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAlquileres";
            this.Text = "FrmAlquileres";
            this.Load += new System.EventHandler(this.FrmAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlquilerMasLargo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerDatosYate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}