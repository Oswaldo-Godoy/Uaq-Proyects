namespace Proyecto.F
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Cambios = new System.Windows.Forms.Button();
            this.btn_Cred = new System.Windows.Forms.Button();
            this.btn_returnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡En hora buena!";
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(573, 163);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(171, 64);
            this.btn_Alta.TabIndex = 1;
            this.btn_Alta.Text = "Alta de Datos";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Cambios
            // 
            this.btn_Cambios.Location = new System.Drawing.Point(573, 339);
            this.btn_Cambios.Name = "btn_Cambios";
            this.btn_Cambios.Size = new System.Drawing.Size(171, 64);
            this.btn_Cambios.TabIndex = 2;
            this.btn_Cambios.Text = "Cambios y bajas";
            this.btn_Cambios.UseVisualStyleBackColor = true;
            this.btn_Cambios.Click += new System.EventHandler(this.btn_Cambios_Click);
            // 
            // btn_Cred
            // 
            this.btn_Cred.Location = new System.Drawing.Point(12, 533);
            this.btn_Cred.Name = "btn_Cred";
            this.btn_Cred.Size = new System.Drawing.Size(194, 34);
            this.btn_Cred.TabIndex = 3;
            this.btn_Cred.Text = "Creditos";
            this.btn_Cred.UseVisualStyleBackColor = true;
            this.btn_Cred.Click += new System.EventHandler(this.btn_Cred_Click);
            // 
            // btn_returnLogin
            // 
            this.btn_returnLogin.Location = new System.Drawing.Point(982, 526);
            this.btn_returnLogin.Name = "btn_returnLogin";
            this.btn_returnLogin.Size = new System.Drawing.Size(124, 41);
            this.btn_returnLogin.TabIndex = 4;
            this.btn_returnLogin.Text = "Salir";
            this.btn_returnLogin.UseVisualStyleBackColor = true;
            this.btn_returnLogin.Click += new System.EventHandler(this.btn_returnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bienvenido a Aperture Laboratories";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mi nombre es Glados, ¿qué deseas hacer?";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1118, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_returnLogin);
            this.Controls.Add(this.btn_Cred);
            this.Controls.Add(this.btn_Cambios);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Cambios;
        private System.Windows.Forms.Button btn_Cred;
        private System.Windows.Forms.Button btn_returnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}