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
    public partial class FormSelectArena : Form
    {
        FormGame formGame;
        public FormSelectArena()
        {
            InitializeComponent();
        }

        private void FormSelectArena_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;

            radioButtonArena1.Text = "Colosseum";
            pictureBoxArena1.BackgroundImage = Properties.Resources.game_battleArena;
            radioButtonArena2.Text = "Forest";
            pictureBoxArena2.BackgroundImage = Properties.Resources.background_Forest;
            radioButtonArena3.Text = "Volcanic";
            pictureBoxArena3.BackgroundImage = Properties.Resources.background_Volcanic;
        }

        private void radioButtonArena1_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "Let's fight now !";
        }

        private void radioButtonArena2_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "Very nice arena..";
        }

        private void radioButtonArena3_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's so hot in here...";
        }

        private void buttonSelectArena_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonArena1.Checked)
                {
                    formGame.BackgroundImage = Properties.Resources.game_battleArena;
                }
                else if (radioButtonArena2.Checked)
                {
                    formGame.BackgroundImage = Properties.Resources.background_Forest;
                }
                else
                {
                    formGame.BackgroundImage = Properties.Resources.background_Volcanic;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
