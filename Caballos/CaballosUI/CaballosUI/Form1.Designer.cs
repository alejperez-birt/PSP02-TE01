using System.Threading;

namespace CaballosUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.prB_Caballo01 = new System.Windows.Forms.ProgressBar();
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.lbl_Caballo01 = new System.Windows.Forms.Label();
            this.lbl_Caballo02 = new System.Windows.Forms.Label();
            this.prB_Caballo02 = new System.Windows.Forms.ProgressBar();
            this.lbl_Caballo03 = new System.Windows.Forms.Label();
            this.prB_Caballo03 = new System.Windows.Forms.ProgressBar();
            this.lbl_Caballo04 = new System.Windows.Forms.Label();
            this.prB_Caballo04 = new System.Windows.Forms.ProgressBar();
            this.txt_Ganador = new System.Windows.Forms.TextBox();
            this.lbl_Resultado04 = new System.Windows.Forms.Label();
            this.lbl_Resultado03 = new System.Windows.Forms.Label();
            this.lbl_Resultado02 = new System.Windows.Forms.Label();
            this.lbl_Resultado01 = new System.Windows.Forms.Label();
            this.lbl_Ganador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prB_Caballo01
            // 
            this.prB_Caballo01.Location = new System.Drawing.Point(115, 135);
            this.prB_Caballo01.Name = "prB_Caballo01";
            this.prB_Caballo01.Size = new System.Drawing.Size(494, 40);
            this.prB_Caballo01.TabIndex = 0;
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empezar.Location = new System.Drawing.Point(26, 39);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(100, 40);
            this.btn_Empezar.TabIndex = 1;
            this.btn_Empezar.Text = "Empezar";
            this.btn_Empezar.UseVisualStyleBackColor = true;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Enabled = false;
            this.btn_Reiniciar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.Location = new System.Drawing.Point(509, 39);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(100, 40);
            this.btn_Reiniciar.TabIndex = 2;
            this.btn_Reiniciar.Text = "Reiniciar";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // lbl_Caballo01
            // 
            this.lbl_Caballo01.AutoSize = true;
            this.lbl_Caballo01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caballo01.Location = new System.Drawing.Point(26, 148);
            this.lbl_Caballo01.Name = "lbl_Caballo01";
            this.lbl_Caballo01.Size = new System.Drawing.Size(70, 17);
            this.lbl_Caballo01.TabIndex = 3;
            this.lbl_Caballo01.Text = "Caballo 01";
            // 
            // lbl_Caballo02
            // 
            this.lbl_Caballo02.AutoSize = true;
            this.lbl_Caballo02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caballo02.Location = new System.Drawing.Point(26, 225);
            this.lbl_Caballo02.Name = "lbl_Caballo02";
            this.lbl_Caballo02.Size = new System.Drawing.Size(70, 17);
            this.lbl_Caballo02.TabIndex = 5;
            this.lbl_Caballo02.Text = "Caballo 02";
            // 
            // prB_Caballo02
            // 
            this.prB_Caballo02.Location = new System.Drawing.Point(115, 212);
            this.prB_Caballo02.Name = "prB_Caballo02";
            this.prB_Caballo02.Size = new System.Drawing.Size(494, 40);
            this.prB_Caballo02.TabIndex = 4;
            // 
            // lbl_Caballo03
            // 
            this.lbl_Caballo03.AutoSize = true;
            this.lbl_Caballo03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caballo03.Location = new System.Drawing.Point(26, 301);
            this.lbl_Caballo03.Name = "lbl_Caballo03";
            this.lbl_Caballo03.Size = new System.Drawing.Size(70, 17);
            this.lbl_Caballo03.TabIndex = 7;
            this.lbl_Caballo03.Text = "Caballo 03";
            // 
            // prB_Caballo03
            // 
            this.prB_Caballo03.Location = new System.Drawing.Point(115, 288);
            this.prB_Caballo03.Name = "prB_Caballo03";
            this.prB_Caballo03.Size = new System.Drawing.Size(494, 40);
            this.prB_Caballo03.TabIndex = 6;
            // 
            // lbl_Caballo04
            // 
            this.lbl_Caballo04.AutoSize = true;
            this.lbl_Caballo04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caballo04.Location = new System.Drawing.Point(26, 378);
            this.lbl_Caballo04.Name = "lbl_Caballo04";
            this.lbl_Caballo04.Size = new System.Drawing.Size(70, 17);
            this.lbl_Caballo04.TabIndex = 9;
            this.lbl_Caballo04.Text = "Caballo 04";
            // 
            // prB_Caballo04
            // 
            this.prB_Caballo04.Location = new System.Drawing.Point(115, 365);
            this.prB_Caballo04.Name = "prB_Caballo04";
            this.prB_Caballo04.Size = new System.Drawing.Size(494, 40);
            this.prB_Caballo04.TabIndex = 8;
            // 
            // txt_Ganador
            // 
            this.txt_Ganador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Ganador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ganador.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Ganador.Location = new System.Drawing.Point(222, 40);
            this.txt_Ganador.Name = "txt_Ganador";
            this.txt_Ganador.Size = new System.Drawing.Size(200, 39);
            this.txt_Ganador.TabIndex = 10;
            this.txt_Ganador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Ganador.Visible = false;
            // 
            // lbl_Resultado04
            // 
            this.lbl_Resultado04.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado04.Location = new System.Drawing.Point(539, 408);
            this.lbl_Resultado04.Name = "lbl_Resultado04";
            this.lbl_Resultado04.Size = new System.Drawing.Size(66, 17);
            this.lbl_Resultado04.TabIndex = 14;
            this.lbl_Resultado04.Text = "Resultado";
            this.lbl_Resultado04.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Resultado04.Visible = false;
            // 
            // lbl_Resultado03
            // 
            this.lbl_Resultado03.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado03.Location = new System.Drawing.Point(539, 331);
            this.lbl_Resultado03.Name = "lbl_Resultado03";
            this.lbl_Resultado03.Size = new System.Drawing.Size(66, 17);
            this.lbl_Resultado03.TabIndex = 13;
            this.lbl_Resultado03.Text = "Resultado";
            this.lbl_Resultado03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Resultado03.Visible = false;
            // 
            // lbl_Resultado02
            // 
            this.lbl_Resultado02.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado02.Location = new System.Drawing.Point(539, 255);
            this.lbl_Resultado02.Name = "lbl_Resultado02";
            this.lbl_Resultado02.Size = new System.Drawing.Size(66, 17);
            this.lbl_Resultado02.TabIndex = 12;
            this.lbl_Resultado02.Text = "Resultado";
            this.lbl_Resultado02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Resultado02.Visible = false;
            // 
            // lbl_Resultado01
            // 
            this.lbl_Resultado01.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado01.Location = new System.Drawing.Point(539, 178);
            this.lbl_Resultado01.Name = "lbl_Resultado01";
            this.lbl_Resultado01.Size = new System.Drawing.Size(66, 17);
            this.lbl_Resultado01.TabIndex = 11;
            this.lbl_Resultado01.Text = "Resultado";
            this.lbl_Resultado01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Resultado01.Visible = false;
            // 
            // lbl_Ganador
            // 
            this.lbl_Ganador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ganador.Location = new System.Drawing.Point(222, 20);
            this.lbl_Ganador.Name = "lbl_Ganador";
            this.lbl_Ganador.Size = new System.Drawing.Size(200, 17);
            this.lbl_Ganador.TabIndex = 15;
            this.lbl_Ganador.Text = "GANADOR";
            this.lbl_Ganador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Ganador.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 463);
            this.Controls.Add(this.lbl_Ganador);
            this.Controls.Add(this.lbl_Resultado04);
            this.Controls.Add(this.lbl_Resultado03);
            this.Controls.Add(this.lbl_Resultado02);
            this.Controls.Add(this.lbl_Resultado01);
            this.Controls.Add(this.txt_Ganador);
            this.Controls.Add(this.lbl_Caballo04);
            this.Controls.Add(this.prB_Caballo04);
            this.Controls.Add(this.lbl_Caballo03);
            this.Controls.Add(this.prB_Caballo03);
            this.Controls.Add(this.lbl_Caballo02);
            this.Controls.Add(this.prB_Caballo02);
            this.Controls.Add(this.lbl_Caballo01);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.btn_Empezar);
            this.Controls.Add(this.prB_Caballo01);
            this.Name = "Form1";
            this.Text = "Caballos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prB_Caballo01;
        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Label lbl_Caballo01;
        private System.Windows.Forms.Label lbl_Caballo02;
        private System.Windows.Forms.ProgressBar prB_Caballo02;
        private System.Windows.Forms.Label lbl_Caballo03;
        private System.Windows.Forms.ProgressBar prB_Caballo03;
        private System.Windows.Forms.Label lbl_Caballo04;
        private System.Windows.Forms.ProgressBar prB_Caballo04;
        private System.Windows.Forms.TextBox txt_Ganador;
        private System.Windows.Forms.Label lbl_Resultado04;
        private System.Windows.Forms.Label lbl_Resultado03;
        private System.Windows.Forms.Label lbl_Resultado02;
        private System.Windows.Forms.Label lbl_Resultado01;
        private System.Windows.Forms.Label lbl_Ganador;

    }
}

