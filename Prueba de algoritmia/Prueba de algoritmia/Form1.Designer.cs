namespace Prueba_de_algoritmia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnejec = new System.Windows.Forms.Button();
            this.txtTamañoLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtListaBase = new System.Windows.Forms.TextBox();
            this.txtNumConsultas = new System.Windows.Forms.TextBox();
            this.txtConsultas = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnejec
            // 
            this.btnejec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnejec.Location = new System.Drawing.Point(152, 242);
            this.btnejec.Name = "btnejec";
            this.btnejec.Size = new System.Drawing.Size(149, 42);
            this.btnejec.TabIndex = 0;
            this.btnejec.Text = "Ejecutar";
            this.btnejec.UseVisualStyleBackColor = true;
            this.btnejec.Click += new System.EventHandler(this.btnejec_Click);
            // 
            // txtTamañoLista
            // 
            this.txtTamañoLista.Location = new System.Drawing.Point(266, 39);
            this.txtTamañoLista.Name = "txtTamañoLista";
            this.txtTamañoLista.Size = new System.Drawing.Size(162, 20);
            this.txtTamañoLista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño de la lista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Listado de números:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Consultas a evaluar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Números a evaluar:";
            // 
            // txtListaBase
            // 
            this.txtListaBase.Location = new System.Drawing.Point(266, 86);
            this.txtListaBase.Name = "txtListaBase";
            this.txtListaBase.Size = new System.Drawing.Size(162, 20);
            this.txtListaBase.TabIndex = 6;
            // 
            // txtNumConsultas
            // 
            this.txtNumConsultas.Location = new System.Drawing.Point(266, 130);
            this.txtNumConsultas.Name = "txtNumConsultas";
            this.txtNumConsultas.Size = new System.Drawing.Size(162, 20);
            this.txtNumConsultas.TabIndex = 7;
            // 
            // txtConsultas
            // 
            this.txtConsultas.Location = new System.Drawing.Point(266, 175);
            this.txtConsultas.Name = "txtConsultas";
            this.txtConsultas.Size = new System.Drawing.Size(162, 20);
            this.txtConsultas.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(139, 346);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(162, 108);
            this.txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(456, 504);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtConsultas);
            this.Controls.Add(this.txtNumConsultas);
            this.Controls.Add(this.txtListaBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamañoLista);
            this.Controls.Add(this.btnejec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prueba de algoritmia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnejec;
        private System.Windows.Forms.TextBox txtTamañoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtListaBase;
        private System.Windows.Forms.TextBox txtNumConsultas;
        private System.Windows.Forms.TextBox txtConsultas;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

