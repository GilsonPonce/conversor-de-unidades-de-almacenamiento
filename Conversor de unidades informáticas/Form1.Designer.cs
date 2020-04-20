namespace Conversor_de_unidades_informáticas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtdigite = new System.Windows.Forms.TextBox();
            this.cmbexpresado = new System.Windows.Forms.ComboBox();
            this.cmbconvertir = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCálculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el valor a convertir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expresado en:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "El resultado es:";
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.White;
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(98, 139);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(180, 20);
            this.txtresultado.TabIndex = 4;
            // 
            // txtdigite
            // 
            this.txtdigite.Location = new System.Drawing.Point(157, 28);
            this.txtdigite.Name = "txtdigite";
            this.txtdigite.Size = new System.Drawing.Size(176, 20);
            this.txtdigite.TabIndex = 5;
            this.txtdigite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdigite_KeyPress);
            // 
            // cmbexpresado
            // 
            this.cmbexpresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbexpresado.FormattingEnabled = true;
            this.cmbexpresado.Items.AddRange(new object[] {
            "bit",
            "byte",
            "kilobyte",
            "megabyte",
            "gigabyte",
            "terabyte",
            "petabyte      ",
            "exabyte       ",
            "zettabyte     ",
            "yottabyte"});
            this.cmbexpresado.Location = new System.Drawing.Point(157, 64);
            this.cmbexpresado.Name = "cmbexpresado";
            this.cmbexpresado.Size = new System.Drawing.Size(121, 21);
            this.cmbexpresado.TabIndex = 6;
            this.cmbexpresado.SelectedIndexChanged += new System.EventHandler(this.cmbexpresado_SelectedIndexChanged);
            this.cmbexpresado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbexpresado_KeyPress);
            // 
            // cmbconvertir
            // 
            this.cmbconvertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbconvertir.Enabled = false;
            this.cmbconvertir.FormattingEnabled = true;
            this.cmbconvertir.Location = new System.Drawing.Point(157, 98);
            this.cmbconvertir.Name = "cmbconvertir";
            this.cmbconvertir.Size = new System.Drawing.Size(121, 21);
            this.cmbconvertir.TabIndex = 7;
            this.cmbconvertir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbconvertir_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opionesToolStripMenuItem
            // 
            this.opionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálcularToolStripMenuItem,
            this.nuevoCálculoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opionesToolStripMenuItem.Name = "opionesToolStripMenuItem";
            this.opionesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.opionesToolStripMenuItem.Text = "Opiones";
            // 
            // cálcularToolStripMenuItem
            // 
            this.cálcularToolStripMenuItem.Name = "cálcularToolStripMenuItem";
            this.cálcularToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cálcularToolStripMenuItem.Text = "Cálcular";
            this.cálcularToolStripMenuItem.Click += new System.EventHandler(this.cálcularToolStripMenuItem_Click);
            // 
            // nuevoCálculoToolStripMenuItem
            // 
            this.nuevoCálculoToolStripMenuItem.Name = "nuevoCálculoToolStripMenuItem";
            this.nuevoCálculoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoCálculoToolStripMenuItem.Text = "Nuevo cálculo";
            this.nuevoCálculoToolStripMenuItem.Click += new System.EventHandler(this.nuevoCálculoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(89, 183);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(99, 23);
            this.btnnuevo.TabIndex = 9;
            this.btnnuevo.Text = "Nuevo cálculo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(284, 141);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 18);
            this.lblnombre.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(194, 183);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(99, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Cálcular";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Aqua;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(337, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Acerca de ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(369, 218);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.cmbconvertir);
            this.Controls.Add(this.cmbexpresado);
            this.Controls.Add(this.txtdigite);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de unidades";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtdigite;
        private System.Windows.Forms.ComboBox cmbexpresado;
        private System.Windows.Forms.ComboBox cmbconvertir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCálculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ToolStripMenuItem cálcularToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

