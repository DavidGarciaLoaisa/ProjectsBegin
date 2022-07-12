using Quiz_game.Properties;
using System;
using System.Windows.Forms;

namespace Quiz_game
{
    public partial class Form1 : Form
    {
        private int _correctAnswer;
        private int _questionNumber = 1;
        private int _score;
        private int _percentage;
        private readonly int _totalQuestions;

        public Form1()
        {
            InitializeComponent();

            AskQuestion(_questionNumber);

            _totalQuestions = 10;
        }

        //Use meaningful variable names, is doesn't matter if they get a bit long
        private void AskQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    pictureBox1.Image = Resources.Question_image;

                    labQuestion.Text = "¿Cual es el color del cielo?";

                    button1.Text = "Rojo";
                    button2.Text = "Verde";
                    button3.Text = "Azul";
                    button4.Text = "Amarillo";

                    _correctAnswer = 3;
                    break;

                case 2:
                    pictureBox1.Image = Resources.Minecraft;

                    labQuestion.Text = "¿Como se llama el video juego de la imagén?";

                    button1.Text = "Starcraft";
                    button2.Text = "Minecraft";
                    button3.Text = "Standmain";
                    button4.Text = "Blockscraft";

                    _correctAnswer = 2;
                    break;

                case 3:
                    pictureBox1.Image = Resources.Question_image;

                    labQuestion.Text = "¿Como se escribe verde en ingles?";

                    button1.Text = "Red";
                    button2.Text = "Green";
                    button3.Text = "Yellow";
                    button4.Text = "Blue";

                    _correctAnswer = 2;
                    break;

                case 4:
                    pictureBox1.Image = Resources.Esferas;

                    labQuestion.Text = "¿Cuantas son las esferas del dragón?";

                    button1.Text = "6";
                    button2.Text = "3";
                    button3.Text = "2";
                    button4.Text = "7";

                    _correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Resources.Question_image;

                    labQuestion.Text = "¿De que color era la capa blanca de Simon Bolivar?";

                    button1.Text = "Amarilla";
                    button2.Text = "Gris";
                    button3.Text = "Blanca";
                    button4.Text = "Verde";

                    _correctAnswer = 3;
                    break;

                case 6:
                    pictureBox1.Image = Resources.Dragon_ball;

                    labQuestion.Text = "¿Como se llama el primer hijo de Goku?";

                    button1.Text = "Krilin";
                    button2.Text = "Patricio";
                    button3.Text = "Gohan";
                    button4.Text = "Goten";

                    _correctAnswer = 3;
                    break;

                case 7:
                    pictureBox1.Image = Resources.Question_image;

                    labQuestion.Text = "¿Cuántos pares de cada animal subió Moisés a su arca?";

                    button1.Text = "1000";
                    button2.Text = "3";
                    button3.Text = "1";
                    button4.Text = "Ninguno";

                    _correctAnswer = 4;
                    break;

                case 8:
                    pictureBox1.Image = Resources.Sonic;

                    labQuestion.Text = "¿Que tipo de animal es Sonic?";

                    button1.Text = "Perro";
                    button2.Text = "Erizo";
                    button3.Text = "Gato";
                    button4.Text = "Mapache";

                    _correctAnswer = 2;
                    break;

                case 9:
                    pictureBox1.Image = Resources.Question_image;

                    labQuestion.Text = "¿Cuanto es 12 mas 15?";

                    button1.Text = "21";
                    button2.Text = "30";
                    button3.Text = "27";
                    button4.Text = "42";

                    _correctAnswer = 3;
                    break;

                case 10:
                    pictureBox1.Image = Resources.Miles_Morales;

                    labQuestion.Text = "¿Cual es uno de los poderes de Miles?";

                    button1.Text = "Super velocidad";
                    button2.Text = "Hacerce invisible";
                    button3.Text = "Visión laser";
                    button4.Text = "Volar";

                    _correctAnswer = 2;
                    break;
            }
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button) sender;

            //what is this button Tag ??? I believe is the answer from the question ??
            //a good variable name will avoid these type of questions, remember that you will be never working alone
            //so you need to write code that all your colleagues can pick up quickly 
            var buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == _correctAnswer)
            {
                _score++;
            }

            if (_questionNumber == _totalQuestions)
            {
                //Is it really necessary to cast it to a int ??
                _percentage = (int) Math.Round((double) (_score * 100) / _totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + _score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is: " + _percentage + "%" + Environment.NewLine +
                    "Click OK to play again."
                );

                _score = 0;
                _questionNumber = 0;

                AskQuestion(_questionNumber);
            }

            _questionNumber++;

            AskQuestion(_questionNumber);
        }
    }
}