namespace Market
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Bt_Agregar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            Bt_Cobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientInactiveCaption;
            textBox1.Location = new Point(216, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GradientInactiveCaption;
            textBox2.Location = new Point(216, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 2;
            label1.Text = "ID del Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de Productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 78);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 4;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 78);
            label4.Name = "label4";
            label4.Size = new Size(16, 25);
            label4.TabIndex = 5;
            label4.Text = ".";
            // 
            // Bt_Agregar
            // 
            Bt_Agregar.BackColor = SystemColors.InactiveBorder;
            Bt_Agregar.Location = new Point(85, 178);
            Bt_Agregar.Name = "Bt_Agregar";
            Bt_Agregar.Size = new Size(112, 34);
            Bt_Agregar.TabIndex = 6;
            Bt_Agregar.Text = "Agregra";
            Bt_Agregar.UseVisualStyleBackColor = false;
            Bt_Agregar.Click += Bt_Agregar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(535, 188);
            dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(837, 215);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 8;
            label5.Text = "Total: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(892, 215);
            label6.Name = "label6";
            label6.Size = new Size(19, 25);
            label6.TabIndex = 9;
            label6.Text = "_";
            // 
            // Bt_Cobrar
            // 
            Bt_Cobrar.BackColor = SystemColors.InactiveBorder;
            Bt_Cobrar.Location = new Point(216, 178);
            Bt_Cobrar.Name = "Bt_Cobrar";
            Bt_Cobrar.Size = new Size(112, 34);
            Bt_Cobrar.TabIndex = 10;
            Bt_Cobrar.Text = "Cobrar";
            Bt_Cobrar.UseVisualStyleBackColor = false;
            Bt_Cobrar.Click += Bt_Cobrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(987, 277);
            Controls.Add(Bt_Cobrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Bt_Agregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Bt_Agregar;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Button Bt_Cobrar;
    }
}
