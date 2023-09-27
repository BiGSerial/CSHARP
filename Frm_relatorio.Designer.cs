namespace ClientesApp2
{
    partial class Frm_relatorio
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
            this.text_construct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_construct
            // 
            this.text_construct.AutoSize = true;
            this.text_construct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_construct.ForeColor = System.Drawing.Color.White;
            this.text_construct.Location = new System.Drawing.Point(302, 210);
            this.text_construct.Name = "text_construct";
            this.text_construct.Size = new System.Drawing.Size(256, 31);
            this.text_construct.TabIndex = 0;
            this.text_construct.Text = "EM CONSTRUÇÃO";
            // 
            // Frm_relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_construct);
            this.Name = "Frm_relatorio";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_relatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_construct;
    }
}