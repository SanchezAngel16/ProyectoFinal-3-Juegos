namespace Proyecto_Final
{
    partial class Main
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
            this.btn_Loteria = new System.Windows.Forms.Button();
            this.btn_Timbiriche = new System.Windows.Forms.Button();
            this.btn_Sopa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Loteria
            // 
            this.btn_Loteria.Location = new System.Drawing.Point(316, 41);
            this.btn_Loteria.Name = "btn_Loteria";
            this.btn_Loteria.Size = new System.Drawing.Size(154, 25);
            this.btn_Loteria.TabIndex = 0;
            this.btn_Loteria.Text = "Loteria Mexicana";
            this.btn_Loteria.UseVisualStyleBackColor = true;
            this.btn_Loteria.Click += new System.EventHandler(this.btn_Loteria_Click);
            // 
            // btn_Timbiriche
            // 
            this.btn_Timbiriche.Location = new System.Drawing.Point(355, 72);
            this.btn_Timbiriche.Name = "btn_Timbiriche";
            this.btn_Timbiriche.Size = new System.Drawing.Size(75, 23);
            this.btn_Timbiriche.TabIndex = 1;
            this.btn_Timbiriche.Text = "Timbiriche";
            this.btn_Timbiriche.UseVisualStyleBackColor = true;
            this.btn_Timbiriche.Click += new System.EventHandler(this.btn_Timbiriche_Click);
            // 
            // btn_Sopa
            // 
            this.btn_Sopa.Location = new System.Drawing.Point(316, 101);
            this.btn_Sopa.Name = "btn_Sopa";
            this.btn_Sopa.Size = new System.Drawing.Size(154, 23);
            this.btn_Sopa.TabIndex = 2;
            this.btn_Sopa.Text = "Sopa de Letras";
            this.btn_Sopa.UseVisualStyleBackColor = true;
            this.btn_Sopa.Click += new System.EventHandler(this.btn_Sopa_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sopa);
            this.Controls.Add(this.btn_Timbiriche);
            this.Controls.Add(this.btn_Loteria);
            this.Name = "Main";
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Loteria;
        private System.Windows.Forms.Button btn_Timbiriche;
        private System.Windows.Forms.Button btn_Sopa;
    }
}

