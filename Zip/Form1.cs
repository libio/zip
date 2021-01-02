using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Zip
{
    public partial class Form1 : Form
    {
        string Dir_Ubicacion, Dir_Destino;
        string Name_Archivo;
        string Formato;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btn_no_Click(object sender, EventArgs e)
        {
            Comprimir_Archivos();
            reset();
        }

        private void ptb_Ubicacion_Click(object sender, EventArgs e)
        {
            if (fbdUbicacion.ShowDialog() == DialogResult.OK)
            {
                Dir_Ubicacion = fbdUbicacion.SelectedPath;
                tb_Ubicacion.Text = Dir_Ubicacion;

            }
        }

        private void ptb_Destino_Click(object sender, EventArgs e)
        {
            if (fbdDestino.ShowDialog() == DialogResult.OK)
            {
                Dir_Destino = fbdDestino.SelectedPath;
                tb_Destino.Text = Dir_Destino;
            }
        }
        public void reset()
        {
            tb_Ubicacion.Text = "";
            tb_Destino.Text = "";
            tb_NameArch.Text = "";
            tb_NameArch.Focus();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Utilarios util = new Utilarios();
            util.Mover_formulario(this);
        }

        public void Comprimir_Archivos()
        {
            Name_Archivo = tb_NameArch.Text.Trim();
            Formato = cb_Formato.Text;

            ZipFile.CreateFromDirectory(Dir_Ubicacion, Dir_Destino + @"\" + Name_Archivo + "" + Formato);

        }
    }
}
