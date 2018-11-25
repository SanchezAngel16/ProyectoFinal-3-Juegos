namespace Proyecto_Final
{
    partial class Loteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loteria));
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.griton = new System.Windows.Forms.PictureBox();
            this.tableroComputadora = new System.Windows.Forms.TableLayoutPanel();
            this.tableroPersona = new System.Windows.Forms.TableLayoutPanel();
            this.lblJugador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.griton)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.Location = new System.Drawing.Point(348, 310);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Size = new System.Drawing.Size(75, 23);
            this.btn_Empezar.TabIndex = 1;
            this.btn_Empezar.Text = "Empezar";
            this.btn_Empezar.UseVisualStyleBackColor = true;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // griton
            // 
            this.griton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.griton.Image = ((System.Drawing.Image)(resources.GetObject("griton.Image")));
            this.griton.Location = new System.Drawing.Point(295, 54);
            this.griton.Name = "griton";
            this.griton.Size = new System.Drawing.Size(191, 250);
            this.griton.TabIndex = 2;
            this.griton.TabStop = false;
            // 
            // tableroComputadora
            // 
            this.tableroComputadora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableroComputadora.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableroComputadora.ColumnCount = 3;
            this.tableroComputadora.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.Location = new System.Drawing.Point(518, 54);
            this.tableroComputadora.Name = "tableroComputadora";
            this.tableroComputadora.RowCount = 3;
            this.tableroComputadora.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroComputadora.Size = new System.Drawing.Size(250, 350);
            this.tableroComputadora.TabIndex = 3;
            // 
            // tableroPersona
            // 
            this.tableroPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableroPersona.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableroPersona.ColumnCount = 3;
            this.tableroPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.Location = new System.Drawing.Point(12, 54);
            this.tableroPersona.Name = "tableroPersona";
            this.tableroPersona.RowCount = 3;
            this.tableroPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableroPersona.Size = new System.Drawing.Size(250, 350);
            this.tableroPersona.TabIndex = 4;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(115, 28);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(45, 13);
            this.lblJugador.TabIndex = 5;
            this.lblJugador.Text = "Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computadora";
            // 
            // Loteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.tableroPersona);
            this.Controls.Add(this.tableroComputadora);
            this.Controls.Add(this.griton);
            this.Controls.Add(this.btn_Empezar);
            this.Name = "Loteria";
            this.Text = "Loteria Mexicana";
            ((System.ComponentModel.ISupportInitialize)(this.griton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.PictureBox griton;
        private System.Windows.Forms.TableLayoutPanel tableroComputadora;
        private System.Windows.Forms.TableLayoutPanel tableroPersona;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label label2;
    }
}