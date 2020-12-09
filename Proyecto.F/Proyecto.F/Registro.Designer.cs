namespace Proyecto.F
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RegisGuardar = new System.Windows.Forms.Button();
            this.btn_RegresarL = new System.Windows.Forms.Button();
            this.tB_Usua = new System.Windows.Forms.TextBox();
            this.textB_Contra = new System.Windows.Forms.TextBox();
            this.Estado_U = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa las datos para el registro de tu cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // btn_RegisGuardar
            // 
            this.btn_RegisGuardar.Location = new System.Drawing.Point(351, 361);
            this.btn_RegisGuardar.Name = "btn_RegisGuardar";
            this.btn_RegisGuardar.Size = new System.Drawing.Size(153, 45);
            this.btn_RegisGuardar.TabIndex = 4;
            this.btn_RegisGuardar.Text = "Registrar";
            this.btn_RegisGuardar.UseVisualStyleBackColor = true;
            this.btn_RegisGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RegresarL
            // 
            this.btn_RegresarL.Location = new System.Drawing.Point(681, 412);
            this.btn_RegresarL.Name = "btn_RegresarL";
            this.btn_RegresarL.Size = new System.Drawing.Size(169, 45);
            this.btn_RegresarL.TabIndex = 5;
            this.btn_RegresarL.Text = "Regresar a Login";
            this.btn_RegresarL.UseVisualStyleBackColor = true;
            this.btn_RegresarL.Click += new System.EventHandler(this.btn_RegresarL_Click);
            // 
            // tB_Usua
            // 
            this.tB_Usua.Location = new System.Drawing.Point(239, 174);
            this.tB_Usua.Name = "tB_Usua";
            this.tB_Usua.Size = new System.Drawing.Size(368, 22);
            this.tB_Usua.TabIndex = 6;
            // 
            // textB_Contra
            // 
            this.textB_Contra.Location = new System.Drawing.Point(239, 273);
            this.textB_Contra.Name = "textB_Contra";
            this.textB_Contra.PasswordChar = '*';
            this.textB_Contra.Size = new System.Drawing.Size(368, 22);
            this.textB_Contra.TabIndex = 7;
            // 
            // Estado_U
            // 
            this.Estado_U.AutoSize = true;
            this.Estado_U.Location = new System.Drawing.Point(693, 218);
            this.Estado_U.Name = "Estado_U";
            this.Estado_U.Size = new System.Drawing.Size(46, 17);
            this.Estado_U.TabIndex = 9;
            this.Estado_U.Text = "label5";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 469);
            this.Controls.Add(this.Estado_U);
            this.Controls.Add(this.textB_Contra);
            this.Controls.Add(this.tB_Usua);
            this.Controls.Add(this.btn_RegresarL);
            this.Controls.Add(this.btn_RegisGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_RegisGuardar;
        private System.Windows.Forms.Button btn_RegresarL;
        private System.Windows.Forms.TextBox tB_Usua;
        private System.Windows.Forms.TextBox textB_Contra;
        private System.Windows.Forms.Label Estado_U;
    }
}