
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
            this.alquileresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoAlquilerToolStripMenuItem
            // 
            this.nuevoAlquilerToolStripMenuItem.Name = "nuevoAlquilerToolStripMenuItem";
            this.nuevoAlquilerToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.nuevoAlquilerToolStripMenuItem.Text = "Nuevo Alquiler";
            this.nuevoAlquilerToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlquilerToolStripMenuItem_Click);
            // 
            // alquileresToolStripMenuItem
            // 
            this.alquileresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem1});
            this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.alquileresToolStripMenuItem.Text = "Alquileres";
            this.alquileresToolStripMenuItem.Click += new System.EventHandler(this.alquileresToolStripMenuItem_Click);
            // 
            // alquileresToolStripMenuItem1
            // 
            this.alquileresToolStripMenuItem1.Name = "alquileresToolStripMenuItem1";
            this.alquileresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.alquileresToolStripMenuItem1.Text = "Alquileres";
            this.alquileresToolStripMenuItem1.Click += new System.EventHandler(this.alquileresToolStripMenuItem1_Click);
            // 
            // FrmAterrizaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 460);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem1;
    }
}