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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_Loteria = new System.Windows.Forms.Button();
            this.btn_Sopa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Timbiriche1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Loteria
            // 
            this.btn_Loteria.Location = new System.Drawing.Point(12, 150);
            this.btn_Loteria.Name = "btn_Loteria";
            this.btn_Loteria.Size = new System.Drawing.Size(154, 25);
            this.btn_Loteria.TabIndex = 0;
            this.btn_Loteria.Text = "Loteria Mexicana";
            this.btn_Loteria.UseVisualStyleBackColor = true;
            this.btn_Loteria.Click += new System.EventHandler(this.btn_Loteria_Click);
            // 
            // btn_Sopa
            // 
            this.btn_Sopa.Location = new System.Drawing.Point(331, 151);
            this.btn_Sopa.Name = "btn_Sopa";
            this.btn_Sopa.Size = new System.Drawing.Size(154, 23);
            this.btn_Sopa.TabIndex = 2;
            this.btn_Sopa.Text = "Sopa de Letras";
            this.btn_Sopa.UseVisualStyleBackColor = true;
            this.btn_Sopa.Click += new System.EventHandler(this.btn_Sopa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 131);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(172, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 131);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(331, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 131);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Timbiriche1
            // 
            this.btn_Timbiriche1.Location = new System.Drawing.Point(172, 152);
            this.btn_Timbiriche1.Name = "btn_Timbiriche1";
            this.btn_Timbiriche1.Size = new System.Drawing.Size(153, 23);
            this.btn_Timbiriche1.TabIndex = 1;
            this.btn_Timbiriche1.Text = "Timbiriche";
            this.btn_Timbiriche1.UseVisualStyleBackColor = true;
            this.btn_Timbiriche1.Click += new System.EventHandler(this.btn_Timbiriche_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Sopa);
            this.Controls.Add(this.btn_Timbiriche1);
            this.Controls.Add(this.btn_Loteria);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Loteria;
        private System.Windows.Forms.Button btn_Sopa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Timbiriche1;
    }
}

