namespace Proyecto_Final.Juegos.Timbiriche
{
    partial class Timbiriche
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
            this.panel_jugadores = new System.Windows.Forms.Panel();
            this.panel_jugador2 = new System.Windows.Forms.Panel();
            this.mov_j2 = new System.Windows.Forms.Label();
            this.puntos_j2 = new System.Windows.Forms.Label();
            this.jugador2 = new System.Windows.Forms.Label();
            this.panel_jugador1 = new System.Windows.Forms.Panel();
            this.mov_j1 = new System.Windows.Forms.Label();
            this.puntos_j1 = new System.Windows.Forms.Label();
            this.jugador1 = new System.Windows.Forms.Label();
            this.gameboard = new System.Windows.Forms.TableLayoutPanel();
            this.panel_jugadores.SuspendLayout();
            this.panel_jugador2.SuspendLayout();
            this.panel_jugador1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_jugadores
            // 
            this.panel_jugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_jugadores.AutoSize = true;
            this.panel_jugadores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_jugadores.Controls.Add(this.panel_jugador2);
            this.panel_jugadores.Controls.Add(this.panel_jugador1);
            this.panel_jugadores.Location = new System.Drawing.Point(343, 12);
            this.panel_jugadores.Name = "panel_jugadores";
            this.panel_jugadores.Size = new System.Drawing.Size(104, 204);
            this.panel_jugadores.TabIndex = 0;
            // 
            // panel_jugador2
            // 
            this.panel_jugador2.AutoSize = true;
            this.panel_jugador2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_jugador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_jugador2.Controls.Add(this.mov_j2);
            this.panel_jugador2.Controls.Add(this.puntos_j2);
            this.panel_jugador2.Controls.Add(this.jugador2);
            this.panel_jugador2.Location = new System.Drawing.Point(3, 121);
            this.panel_jugador2.Name = "panel_jugador2";
            this.panel_jugador2.Size = new System.Drawing.Size(98, 80);
            this.panel_jugador2.TabIndex = 1;
            // 
            // mov_j2
            // 
            this.mov_j2.AutoSize = true;
            this.mov_j2.Location = new System.Drawing.Point(14, 58);
            this.mov_j2.Margin = new System.Windows.Forms.Padding(3, 0, 8, 5);
            this.mov_j2.Name = "mov_j2";
            this.mov_j2.Size = new System.Drawing.Size(72, 13);
            this.mov_j2.TabIndex = 5;
            this.mov_j2.Text = "Movimientos: ";
            // 
            // puntos_j2
            // 
            this.puntos_j2.AutoSize = true;
            this.puntos_j2.Location = new System.Drawing.Point(14, 36);
            this.puntos_j2.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.puntos_j2.Name = "puntos_j2";
            this.puntos_j2.Size = new System.Drawing.Size(52, 13);
            this.puntos_j2.TabIndex = 4;
            this.puntos_j2.Text = "Puntos: 0";
            // 
            // jugador2
            // 
            this.jugador2.AutoSize = true;
            this.jugador2.Location = new System.Drawing.Point(14, 13);
            this.jugador2.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.jugador2.Name = "jugador2";
            this.jugador2.Size = new System.Drawing.Size(54, 13);
            this.jugador2.TabIndex = 3;
            this.jugador2.Text = "Jugador 2";
            // 
            // panel_jugador1
            // 
            this.panel_jugador1.AutoSize = true;
            this.panel_jugador1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_jugador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_jugador1.Controls.Add(this.mov_j1);
            this.panel_jugador1.Controls.Add(this.puntos_j1);
            this.panel_jugador1.Controls.Add(this.jugador1);
            this.panel_jugador1.Location = new System.Drawing.Point(3, 15);
            this.panel_jugador1.Name = "panel_jugador1";
            this.panel_jugador1.Size = new System.Drawing.Size(98, 83);
            this.panel_jugador1.TabIndex = 0;
            // 
            // mov_j1
            // 
            this.mov_j1.AutoSize = true;
            this.mov_j1.Location = new System.Drawing.Point(14, 61);
            this.mov_j1.Margin = new System.Windows.Forms.Padding(3, 0, 8, 5);
            this.mov_j1.Name = "mov_j1";
            this.mov_j1.Size = new System.Drawing.Size(72, 13);
            this.mov_j1.TabIndex = 2;
            this.mov_j1.Text = "Movimientos: ";
            // 
            // puntos_j1
            // 
            this.puntos_j1.AutoSize = true;
            this.puntos_j1.Location = new System.Drawing.Point(14, 39);
            this.puntos_j1.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.puntos_j1.Name = "puntos_j1";
            this.puntos_j1.Size = new System.Drawing.Size(52, 13);
            this.puntos_j1.TabIndex = 1;
            this.puntos_j1.Text = "Puntos: 0";
            // 
            // jugador1
            // 
            this.jugador1.AutoSize = true;
            this.jugador1.Location = new System.Drawing.Point(14, 16);
            this.jugador1.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(54, 13);
            this.jugador1.TabIndex = 0;
            this.jugador1.Text = "Jugador 1";
            // 
            // gameboard
            // 
            this.gameboard.AutoSize = true;
            this.gameboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameboard.ColumnCount = 1;
            this.gameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameboard.Location = new System.Drawing.Point(9, 12);
            this.gameboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.gameboard.Name = "gameboard";
            this.gameboard.RowCount = 2;
            this.gameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameboard.Size = new System.Drawing.Size(0, 0);
            this.gameboard.TabIndex = 1;
            // 
            // Timbiriche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(459, 325);
            this.Controls.Add(this.gameboard);
            this.Controls.Add(this.panel_jugadores);
            this.Name = "Timbiriche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timbiriche";
            this.panel_jugadores.ResumeLayout(false);
            this.panel_jugadores.PerformLayout();
            this.panel_jugador2.ResumeLayout(false);
            this.panel_jugador2.PerformLayout();
            this.panel_jugador1.ResumeLayout(false);
            this.panel_jugador1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_jugadores;
        private System.Windows.Forms.Panel panel_jugador2;
        private System.Windows.Forms.Label mov_j2;
        private System.Windows.Forms.Label puntos_j2;
        private System.Windows.Forms.Label jugador2;
        private System.Windows.Forms.Panel panel_jugador1;
        private System.Windows.Forms.Label mov_j1;
        private System.Windows.Forms.Label puntos_j1;
        private System.Windows.Forms.Label jugador1;
        private System.Windows.Forms.TableLayoutPanel gameboard;
    }
}