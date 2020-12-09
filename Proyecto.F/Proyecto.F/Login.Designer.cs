namespace Proyecto.F
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Sesion = new System.Windows.Forms.Button();
            this.btn_Resitro = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Usua = new System.Windows.Forms.TextBox();
            this.text_Passw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sesion
            // 
            this.btn_Sesion.Location = new System.Drawing.Point(291, 510);
            this.btn_Sesion.Name = "btn_Sesion";
            this.btn_Sesion.Size = new System.Drawing.Size(151, 47);
            this.btn_Sesion.TabIndex = 0;
            this.btn_Sesion.Text = "Iniciar Sesión";
            this.btn_Sesion.UseVisualStyleBackColor = true;
            this.btn_Sesion.Click += new System.EventHandler(this.btn_Sesion_Click);
            // 
            // btn_Resitro
            // 
            this.btn_Resitro.Location = new System.Drawing.Point(863, 510);
            this.btn_Resitro.Name = "btn_Resitro";
            this.btn_Resitro.Size = new System.Drawing.Size(144, 47);
            this.btn_Resitro.TabIndex = 1;
            this.btn_Resitro.Text = "Registrarse";
            this.btn_Resitro.UseVisualStyleBackColor = true;
            this.btn_Resitro.Click += new System.EventHandler(this.btn_Resitro_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1156, 570);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 46);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Salir";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // text_Usua
            // 
            this.text_Usua.Location = new System.Drawing.Point(204, 462);
            this.text_Usua.Name = "text_Usua";
            this.text_Usua.Size = new System.Drawing.Size(326, 22);
            this.text_Usua.TabIndex = 5;
            this.text_Usua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_Passw
            // 
            this.text_Passw.Location = new System.Drawing.Point(769, 462);
            this.text_Passw.Name = "text_Passw";
            this.text_Passw.PasswordChar = '*';
            this.text_Passw.Size = new System.Drawing.Size(312, 22);
            this.text_Passw.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "¡Bienvenido!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 628);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_Passw);
            this.Controls.Add(this.text_Usua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Resitro);
            this.Controls.Add(this.btn_Sesion);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sesion;
        private System.Windows.Forms.Button btn_Resitro;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Usua;
        private System.Windows.Forms.TextBox text_Passw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

