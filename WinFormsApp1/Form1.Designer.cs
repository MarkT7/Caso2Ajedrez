namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearPiezas = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPiezas
            // 
            this.btnCrearPiezas.Location = new System.Drawing.Point(303, 115);
            this.btnCrearPiezas.Name = "btnCrearPiezas";
            this.btnCrearPiezas.Size = new System.Drawing.Size(126, 23);
            this.btnCrearPiezas.TabIndex = 0;
            this.btnCrearPiezas.Text = "Crear Piezas";
            this.btnCrearPiezas.UseVisualStyleBackColor = true;
            this.btnCrearPiezas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(124, 260);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(89, 23);
            this.btnMoverTorre.TabIndex = 1;
            this.btnMoverTorre.Text = "Mover Torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mover peon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(543, 264);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(94, 23);
            this.btnMoverCaballo.TabIndex = 3;
            this.btnMoverCaballo.Text = "Mover caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverCaballo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.btnCrearPiezas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCrearPiezas;
        private Button btnMoverTorre;
        private Button button3;
        private Button btnMoverCaballo;
    }
}