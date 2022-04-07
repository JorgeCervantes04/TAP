
namespace TAPU2_Ejemplo1
{
    partial class Ejecucion
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
            this.btnCrearControl = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearControl
            // 
            this.btnCrearControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearControl.Location = new System.Drawing.Point(38, 41);
            this.btnCrearControl.Name = "btnCrearControl";
            this.btnCrearControl.Size = new System.Drawing.Size(123, 55);
            this.btnCrearControl.TabIndex = 0;
            this.btnCrearControl.Text = "Crear control";
            this.btnCrearControl.UseVisualStyleBackColor = true;
            this.btnCrearControl.Click += new System.EventHandler(this.btnCrearControl_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(334, 56);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "boton2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(65, 161);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.Text = "Hablar";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Ejecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnCrearControl);
            this.Name = "Ejecucion";
            this.Text = "Ejecucion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearControl;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnSpeak;
    }
}

