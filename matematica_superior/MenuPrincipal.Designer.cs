namespace matematica_superior
{
    partial class MenuPrincipal
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
            this.complejosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaPolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAvanzadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raicesPrimitivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complejosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // complejosToolStripMenuItem
            // 
            this.complejosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formaPolarToolStripMenuItem,
            this.operacionesAvanzadasToolStripMenuItem,
            this.raicesPrimitivasToolStripMenuItem,
            this.fasoresToolStripMenuItem});
            this.complejosToolStripMenuItem.Name = "complejosToolStripMenuItem";
            this.complejosToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.complejosToolStripMenuItem.Text = "Complejos";
            // 
            // formaPolarToolStripMenuItem
            // 
            this.formaPolarToolStripMenuItem.Name = "formaPolarToolStripMenuItem";
            this.formaPolarToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.formaPolarToolStripMenuItem.Text = "Operaciones Basicas";
            this.formaPolarToolStripMenuItem.Click += new System.EventHandler(this.formaPolarToolStripMenuItem_Click);
            // 
            // operacionesAvanzadasToolStripMenuItem
            // 
            this.operacionesAvanzadasToolStripMenuItem.Name = "operacionesAvanzadasToolStripMenuItem";
            this.operacionesAvanzadasToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.operacionesAvanzadasToolStripMenuItem.Text = "Operaciones avanzadas";
            this.operacionesAvanzadasToolStripMenuItem.Click += new System.EventHandler(this.operacionesAvanzadasToolStripMenuItem_Click);
            // 
            // raicesPrimitivasToolStripMenuItem
            // 
            this.raicesPrimitivasToolStripMenuItem.Name = "raicesPrimitivasToolStripMenuItem";
            this.raicesPrimitivasToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.raicesPrimitivasToolStripMenuItem.Text = "Raices primitivas";
            this.raicesPrimitivasToolStripMenuItem.Click += new System.EventHandler(this.raicesPrimitivasToolStripMenuItem_Click);
            // 
            // fasoresToolStripMenuItem
            // 
            this.fasoresToolStripMenuItem.Name = "fasoresToolStripMenuItem";
            this.fasoresToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.fasoresToolStripMenuItem.Text = "Fasores";
            this.fasoresToolStripMenuItem.Click += new System.EventHandler(this.fasoresToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 528);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem complejosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaPolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAvanzadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raicesPrimitivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasoresToolStripMenuItem;
    }
}

