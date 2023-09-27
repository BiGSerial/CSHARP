using System;

namespace ClientesApp2
{
    partial class Frm_login
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
            this.usr_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_in_user = new System.Windows.Forms.TextBox();
            this.box_in_psw = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usr_txt
            // 
            this.usr_txt.AutoSize = true;
            this.usr_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_txt.Location = new System.Drawing.Point(30, 41);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.Size = new System.Drawing.Size(139, 31);
            this.usr_txt.TabIndex = 0;
            this.usr_txt.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SENHA";
            // 
            // box_in_user
            // 
            this.box_in_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_in_user.Location = new System.Drawing.Point(188, 41);
            this.box_in_user.Name = "box_in_user";
            this.box_in_user.Size = new System.Drawing.Size(245, 35);
            this.box_in_user.TabIndex = 2;
            this.box_in_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box_in_psw
            // 
            this.box_in_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_in_psw.Location = new System.Drawing.Point(188, 86);
            this.box_in_psw.Name = "box_in_psw";
            this.box_in_psw.Size = new System.Drawing.Size(245, 35);
            this.box_in_psw.TabIndex = 3;
            this.box_in_psw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(459, 41);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 80);
            this.enter_btn.TabIndex = 5;
            this.enter_btn.Text = "ENTRAR";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 183);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.box_in_psw);
            this.Controls.Add(this.box_in_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usr_txt);
            this.Name = "Frm_login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label usr_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_in_user;
        private System.Windows.Forms.TextBox box_in_psw;
        private System.Windows.Forms.Button enter_btn;
    }
}

