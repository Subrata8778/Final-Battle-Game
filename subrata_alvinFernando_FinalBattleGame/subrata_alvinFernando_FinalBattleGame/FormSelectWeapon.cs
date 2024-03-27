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
    public partial class FormSelectWeapon : Form
    {
        FormGame formGame;
        public FormSelectWeapon()
        {
            InitializeComponent();
        }

        private void FormSelectWeapon_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;

            radioButtonWeapon1.Text = "Rock";
            pictureBoxWeapon1.Image = Properties.Resources.weapon_rock;
            radioButtonWeapon2.Text = "Knive";
            pictureBoxWeapon2.Image = Properties.Resources.weapon_knive;
            radioButtonWeapon3.Text = "FireBall";
            pictureBoxWeapon3.Image = Properties.Resources.weapon_fireball;
            pictureBoxUltimate.Image = Properties.Resources.weapon_Ultimate;
            radioButtonUltimate.Visible = false;
            pictureBoxUltimate.Visible = false;

            if (formGame.count < 5)
            {
                radioButtonUltimate.Visible = false;
                pictureBoxUltimate.Visible = false;
            }
            else
            {
                radioButtonUltimate.Visible = true;
                pictureBoxUltimate.Visible = true;
            }
        }

        private void radioButtonWeapon1_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a heavy giant rock";
        }

        private void radioButtonWeapon2_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a sharp rusty knives";
        }

        private void radioButtonWeapon3_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a hot bluish flame";
        }

        private void radioButtonUltimate_CheckedChanged(object sender, EventArgs e)
        {
            labelDescription.Text = "It's a powerful weapon that could be destroy any enemy";
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonWeapon1.Checked)
                {
                    formGame.player.SetWeapon(radioButtonWeapon1.Text, labelDescription.Text, pictureBoxWeapon1.Image);
                }
                else if (radioButtonWeapon2.Checked)
                {
                    formGame.player.SetWeapon(radioButtonWeapon2.Text, labelDescription.Text, pictureBoxWeapon2.Image);
                }
                else if (radioButtonWeapon3.Checked)
                {
                    formGame.player.SetWeapon(radioButtonWeapon3.Text, labelDescription.Text, pictureBoxWeapon3.Image);
                }
                else
                {
                    formGame.player.SetWeapon(radioButtonUltimate.Text, labelDescription.Text, pictureBoxUltimate.Image);
                }
                formGame.labelPlayerInfo.Text = formGame.player.DisplayData();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
