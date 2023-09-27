namespace ClientesApp2
{
    partial class Frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_paciente = new System.Windows.Forms.Button();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.pnl_top.Controls.Add(this.flowLayoutPanel1);
            this.pnl_top.Controls.Add(this.btn_fechar);
            this.pnl_top.Controls.Add(this.btn_minimizar);
            this.pnl_top.Controls.Add(this.btn_maximizar);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 30);
            this.pnl_top.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 402);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(764, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(24, 23);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_minimizar.FlatAppearance.BorderSize = 0;
            this.btn_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(704, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(24, 23);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_maximizar.FlatAppearance.BorderSize = 0;
            this.btn_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(734, 3);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(24, 23);
            this.btn_maximizar.TabIndex = 0;
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_menu.Controls.Add(this.btn_sair);
            this.pnl_menu.Controls.Add(this.btn_relatorio);
            this.pnl_menu.Controls.Add(this.btn_paciente);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 420);
            this.pnl_menu.TabIndex = 1;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_sair.Image")));
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.Location = new System.Drawing.Point(3, 172);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(194, 54);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_relatorio.FlatAppearance.BorderSize = 0;
            this.btn_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio.ForeColor = System.Drawing.Color.White;
            this.btn_relatorio.Image = ((System.Drawing.Image)(resources.GetObject("btn_relatorio.Image")));
            this.btn_relatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorio.Location = new System.Drawing.Point(3, 112);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(194, 54);
            this.btn_relatorio.TabIndex = 1;
            this.btn_relatorio.Text = "RELATORIO";
            this.btn_relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_paciente
            // 
            this.btn_paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_paciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_paciente.FlatAppearance.BorderSize = 0;
            this.btn_paciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paciente.ForeColor = System.Drawing.Color.White;
            this.btn_paciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_paciente.Image")));
            this.btn_paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paciente.Location = new System.Drawing.Point(3, 52);
            this.btn_paciente.Name = "btn_paciente";
            this.btn_paciente.Size = new System.Drawing.Size(194, 54);
            this.btn_paciente.TabIndex = 0;
            this.btn_paciente.Text = "PACIENTES";
            this.btn_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_paciente.UseVisualStyleBackColor = false;
            this.btn_paciente.Click += new System.EventHandler(this.btn_paciente_Click);
            // 
            // pnl_principal
            // 
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_principal.Location = new System.Drawing.Point(200, 30);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(600, 420);
            this.pnl_principal.TabIndex = 2;
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_principal);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_top.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_maximizar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_paciente;
        private System.Windows.Forms.Panel pnl_principal;
    }
}