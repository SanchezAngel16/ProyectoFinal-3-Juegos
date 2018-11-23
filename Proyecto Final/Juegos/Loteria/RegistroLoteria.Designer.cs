namespace Proyecto_Final
{
    partial class RegistroLoteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroLoteria));
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelTableros = new System.Windows.Forms.TableLayoutPanel();
            this.tablero3 = new System.Windows.Forms.PictureBox();
            this.tablero2 = new System.Windows.Forms.PictureBox();
            this.tablero1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTableros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablero3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.Location = new System.Drawing.Point(297, 413);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(118, 23);
            this.btn_Empezar.TabIndex = 0;
            this.btn_Empezar.Text = "Empezar Juego";
            this.btn_Empezar.UseVisualStyleBackColor = true;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // panelTableros
            // 
            this.panelTableros.ColumnCount = 3;
            this.panelTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelTableros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelTableros.Controls.Add(this.tablero3, 2, 0);
            this.panelTableros.Controls.Add(this.tablero2, 1, 0);
            this.panelTableros.Controls.Add(this.tablero1, 0, 0);
            this.panelTableros.Location = new System.Drawing.Point(12, 108);
            this.panelTableros.Name = "panelTableros";
            this.panelTableros.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.panelTableros.RowCount = 1;
            this.panelTableros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTableros.Size = new System.Drawing.Size(691, 274);
            this.panelTableros.TabIndex = 3;
            // 
            // tablero3
            // 
            this.tablero3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablero3.Image = ((System.Drawing.Image)(resources.GetObject("tablero3.Image")));
            this.tablero3.Location = new System.Drawing.Point(461, 3);
            this.tablero3.Name = "tablero3";
            this.tablero3.Size = new System.Drawing.Size(220, 268);
            this.tablero3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablero3.TabIndex = 2;
            this.tablero3.TabStop = false;
            this.tablero3.Click += new System.EventHandler(this.tablero3_Click);
            // 
            // tablero2
            // 
            this.tablero2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablero2.Image = ((System.Drawing.Image)(resources.GetObject("tablero2.Image")));
            this.tablero2.Location = new System.Drawing.Point(235, 3);
            this.tablero2.Name = "tablero2";
            this.tablero2.Size = new System.Drawing.Size(220, 268);
            this.tablero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablero2.TabIndex = 1;
            this.tablero2.TabStop = false;
            this.tablero2.Click += new System.EventHandler(this.tablero2_Click);
            // 
            // tablero1
            // 
            this.tablero1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablero1.Image = ((System.Drawing.Image)(resources.GetObject("tablero1.Image")));
            this.tablero1.Location = new System.Drawing.Point(9, 3);
            this.tablero1.Name = "tablero1";
            this.tablero1.Size = new System.Drawing.Size(220, 268);
            this.tablero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablero1.TabIndex = 0;
            this.tablero1.TabStop = false;
            this.tablero1.Click += new System.EventHandler(this.tablero1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elige tu tablero";
            // 
            // RegistroLoteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(715, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTableros);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Empezar);
            this.Name = "RegistroLoteria";
            this.Text = "RegistroLoteria";
            this.panelTableros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablero3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablero1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel panelTableros;
        private System.Windows.Forms.PictureBox tablero1;
        private System.Windows.Forms.PictureBox tablero3;
        private System.Windows.Forms.PictureBox tablero2;
        private System.Windows.Forms.Label label2;
    }
}