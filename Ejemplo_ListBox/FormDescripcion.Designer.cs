namespace Ejemplo_ListBox
{
    partial class FormDescripcion
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
            label1 = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 121);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(264, 118);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(333, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 44);
            label2.Name = "label2";
            label2.Size = new Size(240, 26);
            label2.TabIndex = 3;
            label2.Text = "Agregar Descripcion ";
            // 
            // FormDescripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Name = "FormDescripcion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDescripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Label label2;
    }
}