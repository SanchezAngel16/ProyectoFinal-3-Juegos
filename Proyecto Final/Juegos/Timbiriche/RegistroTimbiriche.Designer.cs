namespace Proyecto_Final
{
    partial class RegistroTimbiriche
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
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.txtJugador2 = new System.Windows.Forms.TextBox();
            this.btn_EmpezarPartida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJugador1
            // 
            this.txtJugador1.Location = new System.Drawing.Point(13, 19);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(100, 20);
            this.txtJugador1.TabIndex = 0;
            this.txtJugador1.Text = "Nombre";
            // 
            // txtJugador2
            // 
            this.txtJugador2.Location = new System.Drawing.Point(181, 19);
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(100, 20);
            this.txtJugador2.TabIndex = 1;
            this.txtJugador2.Text = "Nombre";
            // 
            // btn_EmpezarPartida
            // 
            this.btn_EmpezarPartida.Location = new System.Drawing.Point(102, 127);
            this.btn_EmpezarPartida.Name = "btn_EmpezarPartida";
            this.btn_EmpezarPartida.Size = new System.Drawing.Size(100, 29);
            this.btn_EmpezarPartida.TabIndex = 2;
            this.btn_EmpezarPartida.Text = "Empezar Partida";
            this.btn_EmpezarPartida.UseVisualStyleBackColor = true;
            this.btn_EmpezarPartida.Click += new System.EventHandler(this.btn_EmpezarPartida_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtJugador1);
            this.panel1.Controls.Add(this.btn_EmpezarPartida);
            this.panel1.Controls.Add(this.txtJugador2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 159);
            this.panel1.TabIndex = 3;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(214, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(43, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "6x6";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(43, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "4x4";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "5x5";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jugador 2";
            // 
            // RegistroTimbiriche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(332, 183);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroTimbiriche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroTimbiriche";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.TextBox txtJugador2;
        private System.Windows.Forms.Button btn_EmpezarPartida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}