using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_game
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentege;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();

            AskQuestion(questionNumber);

            totalQuestions = 10;

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentege = (int)Math.Round((double)(score*100)/totalQuestions);

                MessageBox.Show(
                    
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine + 
                    "Your total percentage is: " + percentege + "%" + Environment.NewLine +
                    "Click OK to play again."
                    );
                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }

            questionNumber++;

            AskQuestion(questionNumber);

        }

        private void AskQuestion(int qNumb)
        {
            switch (qNumb)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Question_image;

                    labQuestion.Text = "¿Cual es el color del cielo?";

                    button1.Text = "Rojo";
                    button2.Text = "Verde";
                    button3.Text = "Azul";
                    button4.Text = "Amarillo";

                    correctAnswer = 3;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Minecraft;

                    labQuestion.Text = "¿Como se llama el video juego de la imagén?";

                    button1.Text = "Starcraft";
                    button2.Text = "Minecraft";
                    button3.Text = "Standmain";
                    button4.Text = "Blockscraft";

                    correctAnswer = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Question_image;

                    labQuestion.Text = "¿Como se escribe verde en ingles?";

                    button1.Text = "Red";
                    button2.Text = "Green";
                    button3.Text = "Yellow";
                    button4.Text = "Blue";

                    correctAnswer = 2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Esferas;

                    labQuestion.Text = "¿Cuantas son las esferas del dragón?";

                    button1.Text = "6";
                    button2.Text = "3";
                    button3.Text = "2";
                    button4.Text = "7";

                    correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Question_image;

                    labQuestion.Text = "¿De que color era la capa blanca de Simon Bolivar?";

                    button1.Text = "Amarilla";
                    button2.Text = "Gris";
                    button3.Text = "Blanca";
                    button4.Text = "Verde";

                    correctAnswer = 3;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Dragon_ball;

                    labQuestion.Text = "¿Como se llama el primer hijo de Goku?";

                    button1.Text = "Krilin";
                    button2.Text = "Patricio";
                    button3.Text = "Gohan";
                    button4.Text = "Goten";

                    correctAnswer = 3;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Question_image;

                    labQuestion.Text = "¿Cuántos pares de cada animal subió Moisés a su arca?";

                    button1.Text = "1000";
                    button2.Text = "3";
                    button3.Text = "1";
                    button4.Text = "Ninguno";

                    correctAnswer = 4;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Sonic;

                    labQuestion.Text = "¿Que tipo de animal es Sonic?";

                    button1.Text = "Perro";
                    button2.Text = "Erizo";
                    button3.Text = "Gato";
                    button4.Text = "Mapache";

                    correctAnswer = 2;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.Question_image;

                    labQuestion.Text = "¿Cuanto es 12 mas 15?";

                    button1.Text = "21";
                    button2.Text = "30";
                    button3.Text = "27";
                    button4.Text = "42";

                    correctAnswer = 3;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.Miles_Morales;

                    labQuestion.Text = "¿Cual es uno de los poderes de Miles?";

                    button1.Text = "Super velocidad";
                    button2.Text = "Hacerce invisible";
                    button3.Text = "Visión laser";
                    button4.Text = "Volar";

                    correctAnswer = 2;
                    break;

            }
        }
    }
}
