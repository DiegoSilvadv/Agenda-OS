namespace Agenda_OS
{
    partial class FormAgenda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.labUsuarioMone = new System.Windows.Forms.Label();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnAgendaOS = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlUC = new System.Windows.Forms.Panel();
            this.labUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.labUsuarioMone);
            this.pnlMenu.Controls.Add(this.btnServicos);
            this.pnlMenu.Controls.Add(this.btnTecnicos);
            this.pnlMenu.Controls.Add(this.btnAgendaOS);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(137, 590);
            this.pnlMenu.TabIndex = 0;
            // 
            // labUsuarioMone
            // 
            this.labUsuarioMone.AutoSize = true;
            this.labUsuarioMone.Location = new System.Drawing.Point(703, 13);
            this.labUsuarioMone.Name = "labUsuarioMone";
            this.labUsuarioMone.Size = new System.Drawing.Size(0, 13);
            this.labUsuarioMone.TabIndex = 6;
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btnServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Heading Compressed Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnServicos.Location = new System.Drawing.Point(0, 316);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(137, 55);
            this.btnServicos.TabIndex = 4;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = false;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btnTecnicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTecnicos.FlatAppearance.BorderSize = 0;
            this.btnTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnicos.Font = new System.Drawing.Font("Heading Compressed Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnicos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTecnicos.Location = new System.Drawing.Point(0, 255);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(137, 55);
            this.btnTecnicos.TabIndex = 3;
            this.btnTecnicos.Text = "Técnicos";
            this.btnTecnicos.UseVisualStyleBackColor = false;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnAgendaOS
            // 
            this.btnAgendaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btnAgendaOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendaOS.FlatAppearance.BorderSize = 0;
            this.btnAgendaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaOS.Font = new System.Drawing.Font("Heading Compressed Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaOS.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgendaOS.Location = new System.Drawing.Point(0, 194);
            this.btnAgendaOS.Name = "btnAgendaOS";
            this.btnAgendaOS.Size = new System.Drawing.Size(137, 55);
            this.btnAgendaOS.TabIndex = 2;
            this.btnAgendaOS.Text = "Agenda - OS";
            this.btnAgendaOS.UseVisualStyleBackColor = false;
            this.btnAgendaOS.Click += new System.EventHandler(this.btnAgendaOS_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Heading Compressed Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClientes.Location = new System.Drawing.Point(0, 133);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(137, 55);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnlUC
            // 
            this.pnlUC.Controls.Add(this.pictureBox2);
            this.pnlUC.Controls.Add(this.labUsuario);
            this.pnlUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUC.Location = new System.Drawing.Point(137, 0);
            this.pnlUC.Name = "pnlUC";
            this.pnlUC.Size = new System.Drawing.Size(663, 590);
            this.pnlUC.TabIndex = 1;
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Location = new System.Drawing.Point(585, 48);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(46, 13);
            this.labUsuario.TabIndex = 6;
            this.labUsuario.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 503);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.pnlUC);
            this.Controls.Add(this.pnlMenu);
            this.KeyPreview = true;
            this.Name = "FormAgenda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda-Os";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgendaOs_FormClosing);
            this.Load += new System.EventHandler(this.frmAgendaOs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAgendaOs_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgendaOs_KeyPress);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUC.ResumeLayout(false);
            this.pnlUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnAgendaOS;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlUC;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Label labUsuarioMone;
        private System.Windows.Forms.Label labUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

