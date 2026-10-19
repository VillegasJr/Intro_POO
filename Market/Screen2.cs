using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Market
{
    public partial class Screen2 : Form
    {
        public Screen2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            File.AppendAllText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}.txt", 
                $"Botón presionado{DateTime.Now.ToString("HH:mm:ss")} Mensaje de Error" + 
                Environment.NewLine);
        }
    }
}
