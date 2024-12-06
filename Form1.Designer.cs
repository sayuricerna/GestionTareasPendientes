namespace GestionTareasPendientes
{
    partial class Form1
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.label_Tarea = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.Location = new System.Drawing.Point(0, 60);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(600, 32);
            this.txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(174)))));
            this.btnAgregarTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.btnAgregarTarea.Location = new System.Drawing.Point(0, 92);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(600, 56);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTareas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 24;
            this.lstTareas.Location = new System.Drawing.Point(0, 148);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(600, 412);
            this.lstTareas.TabIndex = 2;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnLimpiarLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiarLista.Location = new System.Drawing.Point(0, 616);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(600, 56);
            this.btnLimpiarLista.TabIndex = 3;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.btnEliminarTarea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminarTarea.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarTarea.Location = new System.Drawing.Point(0, 560);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(600, 56);
            this.btnEliminarTarea.TabIndex = 4;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // label_Tarea
            // 
            this.label_Tarea.AutoSize = true;
            this.label_Tarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Tarea.Location = new System.Drawing.Point(0, 34);
            this.label_Tarea.Name = "label_Tarea";
            this.label_Tarea.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.label_Tarea.Size = new System.Drawing.Size(241, 26);
            this.label_Tarea.TabIndex = 5;
            this.label_Tarea.Text = "Escriba la Tarea que desea Agregar";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Titulo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(0, 0);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(432, 34);
            this.label_Titulo.TabIndex = 6;
            this.label_Titulo.Text = "Gestión de Tareas Pendientes";
            this.label_Titulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 672);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 672);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstTareas);
            this.panel3.Controls.Add(this.btnAgregarTarea);
            this.panel3.Controls.Add(this.txtTarea);
            this.panel3.Controls.Add(this.label_Tarea);
            this.panel3.Controls.Add(this.label_Titulo);
            this.panel3.Controls.Add(this.btnEliminarTarea);
            this.panel3.Controls.Add(this.btnLimpiarLista);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 672);
            this.panel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Label label_Tarea;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

