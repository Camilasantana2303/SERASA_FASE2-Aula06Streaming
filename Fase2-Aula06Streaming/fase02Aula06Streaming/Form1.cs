using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Aula06Streaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string titulo = "Ibiza";
            string descricao = "Três amigas inseparáveis transformam uma viagem de negócios a Barcelona em uma louca aventura em Ibiza em busca de um DJ famoso.";
            string caminho_imagem = "C:/Users/camila.scarneiro1/source/repos/Fase2-Aula06Streaming/Fase2-Aula06Streaming/imagens/IbizaTudoPeloDJ.jpg";
            string link_video = "https://www.youtube.com/embed/cNZfGaxSx6k";
            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            
            telaInfo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
