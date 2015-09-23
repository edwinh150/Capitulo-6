namespace tarea1Cap6
{
    partial class Cap6e1Form
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
            this.SalonestextBox = new System.Windows.Forms.TextBox();
            this.AlumnostextBox = new System.Windows.Forms.TextBox();
            this.CaltextBox = new System.Windows.Forms.TextBox();
            this.Saloneslabel = new System.Windows.Forms.Label();
            this.Alumnoslabel = new System.Windows.Forms.Label();
            this.Calilabel = new System.Windows.Forms.Label();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.CrearMbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalonestextBox
            // 
            this.SalonestextBox.Location = new System.Drawing.Point(92, 60);
            this.SalonestextBox.Name = "SalonestextBox";
            this.SalonestextBox.Size = new System.Drawing.Size(177, 20);
            this.SalonestextBox.TabIndex = 1;
            // 
            // AlumnostextBox
            // 
            this.AlumnostextBox.Location = new System.Drawing.Point(92, 97);
            this.AlumnostextBox.Name = "AlumnostextBox";
            this.AlumnostextBox.Size = new System.Drawing.Size(177, 20);
            this.AlumnostextBox.TabIndex = 1;
            // 
            // CaltextBox
            // 
            this.CaltextBox.Location = new System.Drawing.Point(92, 133);
            this.CaltextBox.Name = "CaltextBox";
            this.CaltextBox.Size = new System.Drawing.Size(177, 20);
            this.CaltextBox.TabIndex = 1;
            // 
            // Saloneslabel
            // 
            this.Saloneslabel.AutoSize = true;
            this.Saloneslabel.Location = new System.Drawing.Point(13, 66);
            this.Saloneslabel.Name = "Saloneslabel";
            this.Saloneslabel.Size = new System.Drawing.Size(45, 13);
            this.Saloneslabel.TabIndex = 2;
            this.Saloneslabel.Text = "Salones";
            // 
            // Alumnoslabel
            // 
            this.Alumnoslabel.AutoSize = true;
            this.Alumnoslabel.Location = new System.Drawing.Point(13, 100);
            this.Alumnoslabel.Name = "Alumnoslabel";
            this.Alumnoslabel.Size = new System.Drawing.Size(47, 13);
            this.Alumnoslabel.TabIndex = 2;
            this.Alumnoslabel.Text = "Alumnos";
            // 
            // Calilabel
            // 
            this.Calilabel.AutoSize = true;
            this.Calilabel.Location = new System.Drawing.Point(13, 136);
            this.Calilabel.Name = "Calilabel";
            this.Calilabel.Size = new System.Drawing.Size(72, 13);
            this.Calilabel.TabIndex = 2;
            this.Calilabel.Text = "Calificaciones";
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(92, 217);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(177, 147);
            this.ResultadolistBox.TabIndex = 3;
            // 
            // CrearMbutton
            // 
            this.CrearMbutton.Location = new System.Drawing.Point(61, 177);
            this.CrearMbutton.Name = "CrearMbutton";
            this.CrearMbutton.Size = new System.Drawing.Size(99, 23);
            this.CrearMbutton.TabIndex = 4;
            this.CrearMbutton.Text = "Crear Arreglo";
            this.CrearMbutton.UseVisualStyleBackColor = true;
            this.CrearMbutton.Click += new System.EventHandler(this.CrearMbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(192, 177);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(101, 23);
            this.Guardarbutton.TabIndex = 5;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cap6e1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 384);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.CrearMbutton);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.Calilabel);
            this.Controls.Add(this.Alumnoslabel);
            this.Controls.Add(this.Saloneslabel);
            this.Controls.Add(this.CaltextBox);
            this.Controls.Add(this.AlumnostextBox);
            this.Controls.Add(this.SalonestextBox);
            this.Name = "Cap6e1Form";
            this.Text = "Cap6e1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SalonestextBox;
        private System.Windows.Forms.TextBox AlumnostextBox;
        private System.Windows.Forms.TextBox CaltextBox;
        private System.Windows.Forms.Label Saloneslabel;
        private System.Windows.Forms.Label Alumnoslabel;
        private System.Windows.Forms.Label Calilabel;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Button CrearMbutton;
        private System.Windows.Forms.Button Guardarbutton;
    }
}