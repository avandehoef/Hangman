using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanClass : Form
    {

        Player player;
        HMClass game;
        
        public HangmanClass()
        {
            InitializeComponent();
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            pictureBoxGalg.Image = Properties.Resources.hngmnStart;
            pictureBoxSmallImage.Image = Properties.Resources.hmBGsmall;
            BackgroundImage = Properties.Resources.rsz_1hmbg;
            textBoxRaadDitWoord.Font = new Font (textBoxRaadDitWoord.Font.FontFamily, 24);
            textBoxRaadDitWoord.Text = ".   .   .   .   .   .   .   .   .   .   .   .";
            btnRadenOke.Visible = false;
            btnOpnieuw.Visible = false;
            textBoxHighScoreInput.Text = "NAAM         " + "SCORE         " + "AANTAL WOORDEN ";
            textBoxName.Visible = false;
            btnNewPlayer.Visible = false;
            btnStart.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntNewPlayer_Click(object sender, EventArgs e)
        {
            textBoxName.Visible = false;
            if (textBoxName.Text != "Type hier je naam")
            {
                player.Name = textBoxName.Text;
            }            
            textBoxHighScoreInput.Text = "NAAM         " + "SCORE         " + "AANTAL WOORDEN ";
            textBoxHighScoreInput.AppendText(Environment.NewLine);
            textBoxHighScoreInput.AppendText(player.Name);
            btnNewPlayer.Visible = false;
            btnStart.Visible = true;
            btnStartGame.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            player = new Player();
            game = new HMClass(player);
            textBoxName.Visible = true;
            game.Guess('a');
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            btnNewPlayer.Visible = true;
        }
    }
}
