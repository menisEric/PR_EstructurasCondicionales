namespace prBonificacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbbonificacion = new System.Windows.Forms.CheckBox();
            this.nphijos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphe = new System.Windows.Forms.TextBox();
            this.txtphn = new System.Windows.Forms.TextBox();
            this.txthet = new System.Windows.Forms.TextBox();
            this.txthnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtsb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnuevo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtphe);
            this.groupBox1.Controls.Add(this.txtphn);
            this.groupBox1.Controls.Add(this.txthet);
            this.groupBox1.Controls.Add(this.txthnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada Laboral";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(432, 328);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(107, 42);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncalcular.ForeColor = System.Drawing.Color.Black;
            this.btncalcular.Location = new System.Drawing.Point(250, 328);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(107, 42);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnuevo.Location = new System.Drawing.Point(54, 328);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(107, 42);
            this.btnuevo.TabIndex = 9;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = false;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbbonificacion);
            this.groupBox2.Controls.Add(this.nphijos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(54, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 99);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bonificacion";
            // 
            // ckbbonificacion
            // 
            this.ckbbonificacion.AutoSize = true;
            this.ckbbonificacion.Location = new System.Drawing.Point(285, 47);
            this.ckbbonificacion.Name = "ckbbonificacion";
            this.ckbbonificacion.Size = new System.Drawing.Size(174, 24);
            this.ckbbonificacion.TabIndex = 11;
            this.ckbbonificacion.Text = "Recibir Bonificacion";
            this.ckbbonificacion.UseVisualStyleBackColor = true;
            // 
            // nphijos
            // 
            this.nphijos.Location = new System.Drawing.Point(120, 47);
            this.nphijos.Name = "nphijos";
            this.nphijos.Size = new System.Drawing.Size(80, 26);
            this.nphijos.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hijos:";
            // 
            // txtphe
            // 
            this.txtphe.Location = new System.Drawing.Point(339, 156);
            this.txtphe.Name = "txtphe";
            this.txtphe.Size = new System.Drawing.Size(187, 26);
            this.txtphe.TabIndex = 7;
            // 
            // txtphn
            // 
            this.txtphn.Location = new System.Drawing.Point(339, 77);
            this.txtphn.Name = "txtphn";
            this.txtphn.Size = new System.Drawing.Size(187, 26);
            this.txtphn.TabIndex = 6;
            // 
            // txthet
            // 
            this.txthet.Location = new System.Drawing.Point(52, 156);
            this.txthet.Name = "txthet";
            this.txthet.Size = new System.Drawing.Size(187, 26);
            this.txthet.TabIndex = 5;
            // 
            // txthnt
            // 
            this.txthnt.Location = new System.Drawing.Point(54, 77);
            this.txthnt.Name = "txthnt";
            this.txthnt.Size = new System.Drawing.Size(187, 26);
            this.txthnt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pago por hora extra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago por hora normal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Extras Trabajadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas Normales Trabajadas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsn);
            this.groupBox3.Controls.Add(this.txtb);
            this.groupBox3.Controls.Add(this.txtsb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(33, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 181);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sueldo";
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(170, 135);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(187, 26);
            this.txtsn.TabIndex = 12;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(170, 87);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(187, 26);
            this.txtb.TabIndex = 15;
            // 
            // txtsb
            // 
            this.txtsb.Location = new System.Drawing.Point(170, 39);
            this.txtsb.Name = "txtsb";
            this.txtsb.Size = new System.Drawing.Size(187, 26);
            this.txtsb.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bonificacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sueldo Neto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sueldo Bruto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtphe;
        private System.Windows.Forms.TextBox txtphn;
        private System.Windows.Forms.TextBox txthet;
        private System.Windows.Forms.TextBox txthnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbbonificacion;
        private System.Windows.Forms.NumericUpDown nphijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtsb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

