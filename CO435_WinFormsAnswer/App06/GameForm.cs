using CO435_WinFormsAnswer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CO435_WinFormsAnswer
{
    public partial class GameForm : Form
    {
        private Bitmap rockBitmap = new Bitmap(Resources.Rock);
        private Bitmap paperBitmap = new Bitmap(Resources.Paper);
        private Bitmap scissorsBitmap = new Bitmap(Resources.Scissors);

        private Game game = new Game("Player");
        
        public GameForm()
        {
            InitializeComponent();

            paperRadioButton.Checked = true;
            game.Start();
        }

        private void DisplayImage(PictureBox pictureBox, Bitmap bitmap)
        {
            pictureBox.Image = bitmap;
        }

        private void DisplayRock(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, rockBitmap);
            game.PlayerChoice = GameChoice.Rock;
        }

        private void DisplayPaper(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, paperBitmap);
            game.PlayerChoice = GameChoice.Paper;

        }

        private void DisplayScissors(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, scissorsBitmap);
            game.PlayerChoice = GameChoice.Scissors;
        }

        private void GetComputerChoice(object sender, EventArgs e)
        {
            game.GetComputerChoice();

            if (game.ComputerChoice == GameChoice.Rock)
            {
                DisplayImage(computerPictureBox, rockBitmap);
            }
            else if (game.ComputerChoice == GameChoice.Paper)
            {
                DisplayImage(computerPictureBox, paperBitmap);
            }
            else if (game.ComputerChoice == GameChoice.Scissors)
            {
                DisplayImage(computerPictureBox, scissorsBitmap);
            }

            DisplayWinner();
        }

        private void DisplayWinner()
        {
            game.ScoreRound();

            string message = "You chose " + game.PlayerChoice;
            message = message + "\nComputer Chose " + game.ComputerChoice;

            message = message + "\n\n The Winner is " + game.WinnerName;

            scoreRichTextBox.AppendText(message);
        }

        private void QuitForm(object sender, EventArgs e)
        {
            Close();
        }

    }
}
