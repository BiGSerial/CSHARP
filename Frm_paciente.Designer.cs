namespace ClientesApp2
{
    partial class Frm_paciente
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
            this.pnl_cad_pessoal = new System.Windows.Forms.Panel();
            this.txt_TituloCadUser = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_cad_pessoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cad_pessoal
            // 
            this.pnl_cad_pessoal.BackColor = System.Drawing.Color.Silver;
            this.pnl_cad_pessoal.Controls.Add(this.textBox1);
            this.pnl_cad_pessoal.Controls.Add(this.lbl_name);
            this.pnl_cad_pessoal.Controls.Add(this.flowLayoutPanel1);
            this.pnl_cad_pessoal.Controls.Add(this.txt_TituloCadUser);
            this.pnl_cad_pessoal.Location = new System.Drawing.Point(12, 12);
            this.pnl_cad_pessoal.Name = "pnl_cad_pessoal";
            this.pnl_cad_pessoal.Size = new System.Drawing.Size(903, 178);
            this.pnl_cad_pessoal.TabIndex = 0;
            // 
            // txt_TituloCadUser
            // 
            this.txt_TituloCadUser.AutoSize = true;
            this.txt_TituloCadUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TituloCadUser.Location = new System.Drawing.Point(12, 0);
            this.txt_TituloCadUser.Name = "txt_TituloCadUser";
            this.txt_TituloCadUser.Size = new System.Drawing.Size(181, 20);
            this.txt_TituloCadUser.TabIndex = 0;
            this.txt_TituloCadUser.Text = "CADASTRO PACIENTE";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 129);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(195, 24);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(108, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "NOME COMPLETO*:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Frm_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1190, 749);
            this.Controls.Add(this.pnl_cad_pessoal);
            this.Name = "Frm_paciente";
            this.Text = "Frm_paciente";
            this.pnl_cad_pessoal.ResumeLayout(false);
            this.pnl_cad_pessoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cad_pessoal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_TituloCadUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_name;
    }
}