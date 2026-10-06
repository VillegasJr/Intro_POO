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
            Bt_Cobrar = new Button();
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
            // Bt_Cobrar
            // 
            Bt_Cobrar.BackColor = SystemColors.InactiveBorder;
            Bt_Cobrar.Location = new Point(153, 171);
            Bt_Cobrar.Name = "Bt_Cobrar";
            Bt_Cobrar.Size = new Size(112, 34);
            Bt_Cobrar.TabIndex = 6;
            Bt_Cobrar.Text = "Cobrar";
            Bt_Cobrar.UseVisualStyleBackColor = false;
            Bt_Cobrar.Click += Bt_Cobrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 241);
            Controls.Add(Bt_Cobrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
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
        private Button Bt_Cobrar;
    }
}
