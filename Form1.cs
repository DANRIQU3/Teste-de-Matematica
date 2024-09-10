using static System.Net.Mime.MediaTypeNames;

namespace Teste_de_Matemática
{
    public partial class Form1 : Form
    {
        // Cria um objeto aleatório chamado randomizer 
        // para gerar números aleatórios.
        Random randomizer = new Random();

        // Essas variáveis ​​inteiras armazenam os números 
        // para o problema de adição.
        int addend1;
        int addend2;

        // Essas variáveis ​​inteiras armazenam os números 
        // para o problema de subtração.
        int minuend;
        int subtrahend;

        //Essas variáveis ​​inteiras armazenam os números 
        // para o problema de multiplicação.
        int multiplicand;
        int multiplier;

        //Essas variáveis ​​inteiras armazenam os números 
        // para o problema de divisão.
        int dividend;
        int divisor;

        // Esta variável inteira mantém o controle do 
        //tempo restante.
        int timeLeft;

        int numero = 5;


        // Comece o teste preenchendo todos os problemas
        // e iniciando o cronômetro.
        public void StartTheQuiz()
        {
            // Preencha o problema de adição.
            // Gere dois números aleatórios para adicionar.
            // Armazena os valores nas variáveis ​​'addend1' e 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Converte os dois números gerados aleatoriamente
            // em strings para que possam ser exibidas
            // nos controles do rótulo.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'soma' é o nome do controle NumericUpDown.
            // Esta etapa garante que seu valor seja zero antes
            // adicionando quaisquer valores a ele.
            soma.Value = 0;

            // Preencha o problema de subtração.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            diferença.Value = 0;

            // Preencha o problema de subtração.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            produto.Value = 0;

            // Preencha o problema de subtração.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quociente.Value = 0;

            // iniciar o temporizador.
            timeLeft = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }


        /// Verifique as respostas para ver se o usuário acertou.
        /// <returns>Verdadeiro se a resposta estiver correta, falso caso contrário.</returns>
        public bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == soma.Value)
        && (minuend - subtrahend == diferença.Value)
        && (multiplicand * multiplier == produto.Value)
        && (dividend / divisor == quociente.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Se CheckTheAnswer() retornar verdadeiro, então o usuário 
                // acertou a resposta. Pare o cronômetro  
                // e mostra uma MessageBox.
                timer1.Stop();
                MessageBox.Show("Você acertou todas as respostas!",
                        "Parabéns!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {

                // Se CheckTheAnswer() retornar falso, continue contando
                // abaixo. Diminua o tempo restante em um segundo e 
                // exibe o novo tempo restante atualizando o 
                // Rótulo de tempo restante.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " segundos";
            }
            else
            {
                // Se o tempo do usuário acabar, pare o cronômetro, mostre
                // uma MessageBox e preencha as respostas.
                timer1.Stop();
                timeLabel.Text = "Acabou o tempo!";
                MessageBox.Show("Você não terminou a tempo.", "Desculpe!");
                soma.Value = addend1 + addend2;
                diferença.Value = minuend - subtrahend;
                produto.Value = multiplicand * multiplier;
                quociente.Value = dividend / divisor;
                startButton.Enabled = true;
              
            }
        }

        
        private void answer_Enter(object sender, EventArgs e)
        {
            // Selecione a resposta completa no controle NumericUpDown.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}

    