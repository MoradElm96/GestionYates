
namespace GestionYates.Vistas
{
    partial class FrmAterrizaje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAlquilerToolStripMenuItem,
            this.alquileresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoAlquilerToolStripMenuItem
            // 
            this.nuevoAlquilerToolStripMenuItem.Name = "nuevoAlquilerToolStripMenuItem";
            this.nuevoAlquilerToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.nuevoAlquilerToolStripMenuItem.Text = "Nuevo Alquiler";
            // 
            // alquileresToolStripMenuItem
            // 
            this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.alquileresToolStripMenuItem.Text = "Alquileres";
            // 
            // FrmAterrizaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 566);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAterrizaje";
            this.Text = "FrmAterrizaje";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem;
    }
}