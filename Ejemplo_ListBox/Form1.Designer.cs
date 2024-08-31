namespace Ejemplo_ListBox
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
            ItemsListBox = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(337, 83);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(150, 224);
            ItemsListBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(337, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar Items";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(337, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar Items";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 24);
            label1.Name = "label1";
            label1.Size = new Size(447, 35);
            label1.TabIndex = 3;
            label1.Text = "Ejemplo del uso de ListBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(ItemsListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsListBox;
        private Button btnAdd;
        private Button btnDelete;
        private Label label1;
    }
}
