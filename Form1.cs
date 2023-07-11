namespace Pedra_Papel_Tesoura_2
{
    public partial class Form1 : Form
    {

        private string escolhaUser, escolhaComput;
        int sorteio;
        private string[] opcoes =
          {
                "PEDRA","PAPEL","TESOURA"
          };

        public Form1()
        {
            InitializeComponent();

        }

        public void SalvarSelecao(string selacao)
        {
            //salvar seleçao do usuario



            //salvar selação da máquina


            //comprar as escolhas

            //exibir os vencedores


        }


        public void OpcoesdoUsuario(int escolha)
        {
            escolhaUser = opcoes[escolha];
            EscolhadaMaquina();
            Comparacao();

        }

        public void Comparacao()
        {
            if (escolhaUser == escolhaComput)
            {
                textBox2.Text = "Empate";
            }
            else if ((escolhaUser == "TESOURA" && escolhaComput == "PAPEL") || (escolhaUser == "PEDRA" && escolhaComput == "TESOURA") || (escolhaUser == "PAPEL" && escolhaComput == "PEDRA"))
            {
                textBox2.Text = " você ganhou ";

            }
            else
            {
                textBox2.Text = " Máquina ganhou perdeu";
            }

        }




        private void button3_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(2);
        }

        public void EscolhadaMaquina()
        {
            Random rand = new Random();
            sorteio = rand.Next(3);
            escolhaComput = opcoes[sorteio];
            textBox1.Text = escolhaComput;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EscolhadaMaquina();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(0);
        }
    }
}