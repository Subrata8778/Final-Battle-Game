using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public partial class FormSelectPlayer : Form
    {
        FormGame formGame;
        public FormSelectPlayer()
        {
            InitializeComponent();
        }

        private void FormSelectPlayer_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;
            radioButtonPlayer1.Checked = true;
            radioButtonPlayer1.Text = "INCREDIBLE BOY";
            pictureBoxPlayer1.Image = Properties.Resources.player_incredibleBoy;
            radioButtonPlayer2.Text = "PERFECTA GIRL";
            pictureBoxPlayer2.Image = Properties.Resources.player_perfectaGirl;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Point startingPosition = new Point(0, 150);
                Size playerSize = new Size(150, 150);
                if (formGame.player != null)
                {
                    formGame.player.Remove();
                }
                if (radioButtonPlayer1.Checked)
                {
                    formGame.player = new Player(radioButtonPlayer1.Text, 10, 100, pictureBoxPlayer1.Image, startingPosition, playerSize, "I'm the superhero with incredible strength and honor", 0);

                }
                else
                {
                    formGame.player = new Player(radioButtonPlayer2.Text, 10, 100, pictureBoxPlayer2.Image, startingPosition, playerSize, "I'm the superhero with calm and perfect play", 0);
                }
                formGame.StartNewGame();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayer1.Checked)
            {
                labelDescription.Text = "I'm the superhero with incredible strength and honor";
            }
            else
            {
                labelDescription.Text = "I'm the superhero with calm and perfect play";
            }
        }
    }
}
