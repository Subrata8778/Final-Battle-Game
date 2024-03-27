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
    public partial class FormGame : Form
    {
        public Player player;
        private Enemy enemy;
        public Time time;
        bool enemyMoveUp;
        WMPLib.WindowsMediaPlayer wPlayer;
        WMPLib.WindowsMediaPlayer winSound;

        public int count = 0;
        public int countUltimateTime = 0;

        public FormGame()
        {
            InitializeComponent();
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelEnemy.Visible = false;
            panelPlayer.Visible = false;
            panelTime.Visible = false;
            timerWeapon.Enabled = false;
            timerTime.Enabled = false;
            timerTime.Interval = 1000;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPlayer formSelectPlayer = new FormSelectPlayer();
            formSelectPlayer.Owner = this;
            formSelectPlayer.ShowDialog();
        }
        private void continuePauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (continuePauseToolStripMenuItem.Text == "Pause")
            {
                timerTime.Stop();
                timerEnemy.Stop();
                timerWeapon.Stop();
                KeyPreview = false;
                continuePauseToolStripMenuItem.Text = "Continue";
                wPlayer.controls.stop();
            }
            else
            {
                timerTime.Start();
                timerEnemy.Start();
                timerWeapon.Start();
                KeyPreview = true;
                continuePauseToolStripMenuItem.Text = "Pause";
                wPlayer.controls.play();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void StartNewGame()
        {
            winSound = new WMPLib.WindowsMediaPlayer();
            winSound.URL = Application.StartupPath + "\\sound_winFirework.WAV";
            winSound.controls.stop();
            
            continuePauseToolStripMenuItem.Text = "Pause";
            wPlayer = new WMPLib.WindowsMediaPlayer();
            wPlayer.URL = Application.StartupPath + "\\sound_game.mp3";
            wPlayer.controls.stop();
            wPlayer.controls.play();

            panelData.Visible = true;
            panelPlayer.Visible = true;
            this.BackgroundImage = Properties.Resources.game_battleArena;

            player.SetWeapon("Rock", "It's a heavy giant rock", Properties.Resources.weapon_rock);

            labelPlayerInfo.Text = player.DisplayData();
            player.DisplayPicture(this);
            panelTime.Visible = true;
            time = new Time(0, 10, 0);
            timerTime.Start();

            pictureBoxFirework.Visible = false;
            pictureBoxFirework.SendToBack();
            if (pictureBoxFirework.Image != null)
            {
                pictureBoxFirework.Image.Dispose();
            }

            pictureBoxUltimate.Visible = false;
            if (pictureBoxUltimate.Image != null)
            {
                pictureBoxUltimate.Image.Dispose();
            }

            CreateEnemy();
        }
        public void CreateEnemy()
        {
            Random random = new Random();
            int enemyType = random.Next(2);
            Point startingPoint = new Point(500, 150);
            Size enemySize = new Size(100, 100);
            if (enemy != null)
            {
                enemy.Remove();
            }
            if (enemyType == 0)
            {
                int monsterType = random.Next(3);
                if (monsterType == 0)
                {
                    enemy = new Monster("Dragon", 3, 100, Properties.Resources.monster_dragon, startingPoint, enemySize, 100, "Only the heat can defeat me");
                    enemy.SetWeaponEnemy("Fire", Properties.Resources.weapon_Dragon);
                }
                else if (monsterType == 1)
                {
                    enemy = new Monster("Godzilla", 5, 100, Properties.Resources.monster_godzilla, startingPoint, enemySize, 30, "Really can't help the hard stuff upon me");
                    enemy.SetWeaponEnemy("BlueFire", Properties.Resources.weapon_Godzilla);
                }
                else
                {
                    enemy = new Monster("Red Monster", 7, 100, Properties.Resources.monster_red, startingPoint, enemySize, 150, "Ouch.. no sharp item please..");
                    enemy.SetWeaponEnemy("ComboFire", Properties.Resources.weapon_RedMonster);
                }
            }
            else
            {
                int witchType = random.Next(3);
                if (witchType == 0)
                {
                    enemy = new Witch("The Broom", 1, 100, Properties.Resources.witch_broom, startingPoint, enemySize, 100, 10);
                }
                else if (witchType == 1)
                {
                    enemy = new Witch("Dancing Witch", 2, 100, Properties.Resources.witch_dancing, startingPoint, enemySize, 150, 20);
                }
                else
                {
                    enemy = new Witch("Green Witch", 1, 100, Properties.Resources.witch_green, startingPoint, enemySize, 200, 50);
                }
                enemy.SetWeaponEnemy("MagicBall", Properties.Resources.weapon_Witch);
            }
            enemy.DisplayPicture(this);
            panelEnemy.Visible = true;
            labelEnemyInfo.Text = enemy.DisplayDataEnemy();
            timerEnemy.Interval = enemy.Speed;
            enemyMoveUp = true;
            timerEnemy.Start();
        }
        public void CreateBoss()
        {
            Random random = new Random();
            int bossType = random.Next(2); ;
            Point startingPoint = new Point(500, 150);
            Size enemySize = new Size(100, 100);
            if (enemy != null)
            {
                enemy.Remove();
            }
            if (bossType == 0)
            {
                enemy = new Boss("Devil Dust", 1, 100, Properties.Resources.boss_Devil, startingPoint, enemySize, 250, 10);
                enemy.SetWeaponEnemy("DevilRod", Properties.Resources.weapon_Devil);
            }
            else
            {
                enemy = new Boss("Vampire", 2, 100, Properties.Resources.boss_Vampire, startingPoint, enemySize, 300, 10);
                enemy.SetWeaponEnemy("Bat", Properties.Resources.weapon_Vampire);
            }
            enemy.DisplayPicture(this);
            panelEnemy.Visible = true;
            labelEnemyInfo.Text = enemy.DisplayDataEnemy();
            timerEnemy.Interval = enemy.Speed;
            enemyMoveUp = true;
            timerEnemy.Start();
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            try
            {
                labelTime.Text = time.DisplayData();
                if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
                {
                    timerTime.Stop();
                    MessageBox.Show("Time is up");
                }
                else
                {
                    time.AddSecond(-1);
                }
                if (time.timeStatus == true)
                {
                    timerWeaponEnemy.Start();
                    timerWeaponEnemy.Interval = 50;
                    System.Media.SoundPlayer weaponSound = new System.Media.SoundPlayer(Properties.Resources.sound_enemy);
                    enemy.SetWeaponEnemy(enemy.WeaponEnemy.Name, enemy.WeaponEnemy.Picture.Image);
                    weaponSound.Play();
                }
                if (pictureBoxUltimate.Visible == true)
                {
                    countUltimateTime += 1;
                    if (countUltimateTime == 7)
                    {
                        pictureBoxUltimate.Image.Dispose();
                        pictureBoxUltimate.Visible = false;
                        countUltimateTime = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timerWeapon_Tick(object sender, EventArgs e)
        {
            if (player.Weapon.Picture.Bounds.IntersectsWith(enemy.Picture.Bounds))
            {
                timerWeapon.Stop();
                player.RemoveWeapon();
                if (CheckWeapon() == true)
                {
                    if (player.Weapon.Name == "Ultimate")
                    {
                        System.Media.SoundPlayer ultimateSound = new System.Media.SoundPlayer(Properties.Resources.sound_ultimateThunderstrom);
                        ultimateSound.Play();
                        if (countUltimateTime == 0)
                        {
                            pictureBoxUltimate.Image = Properties.Resources.petir3;
                            pictureBoxUltimate.BringToFront();
                            pictureBoxUltimate.Visible = true;
                        }
                    }
                    else
                    {
                        System.Media.SoundPlayer hitSound = new System.Media.SoundPlayer(Properties.Resources.sound_hit);
                        hitSound.Play();
                    }
                    player.DefeatEnemy(enemy);

                    labelEnemyInfo.Text = enemy.DisplayDataEnemy();
                    labelPlayerInfo.Text = player.DisplayData();

                    if (enemy is Witch || enemy is Monster)
                    {
                        if (enemy.Life == 0 && enemy.Health <= 0)
                        {
                            enemy.Picture.Dispose();
                            if (enemy.WeaponEnemy.Picture.Location.X >= 0)
                            {
                                enemy.RemoveWeaponEnemy();
                            }
                            CreateBoss();
                        }
                    }
                    else if (enemy is Boss)
                    {
                        if (enemy.Life == 0 && enemy.Health <= 0)
                        {
                            enemy.Picture.Dispose();
                            if (enemy.WeaponEnemy.Picture.Location.X >= 0)
                            {
                                enemy.RemoveWeaponEnemy();
                            }
                            panelEnemy.Visible = false;
                            timerWeapon.Stop();
                            timerEnemy.Stop();
                            timerTime.Stop();
                            timerWeaponEnemy.Stop();
                            MessageBox.Show("You win!");

                            pictureBoxFirework.Visible = true;
                            pictureBoxFirework.Image = Properties.Resources.Firework;
                            pictureBoxFirework.BringToFront();

                            winSound.URL = Application.StartupPath + "\\sound_winFirework.WAV";
                            winSound.controls.play();
                            winSound.settings.volume = 100;
                        }
                    }
                }
            }
            else if (player.Weapon.Picture.Location.X >= this.Width)
            {
                player.RemoveWeapon();
                timerWeapon.Stop();
            }
            else
            {
                player.ReleaseWeapon();
                player.DisplayWeapon(this);
            }
            if (player.Weapon.Name == "Ultimate" && timerWeapon.Enabled == false)
            {
                if (timerTime.Enabled == true)
                {
                    FormSelectWeapon formSelectWeapon = new FormSelectWeapon();
                    formSelectWeapon.Owner = this;
                    formSelectWeapon.ShowDialog();
                }
            }
        }
        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            if(enemy.Picture.Location.Y <= panelData.Height + 50)
            {
                enemyMoveUp = false;
            }
            else if (enemy.Picture.Location.Y >= this.Height - enemy.Picture.Size.Height - 45)
            {
                enemyMoveUp = true;
            }
            if (enemyMoveUp == true)
            {
                enemy.MoveUp(20);
            }
            else
            {
                enemy.MoveDown(20);
            }
            enemy.DisplayPicture(this);
        }
        private void timerWeaponEnemy_Tick(object sender, EventArgs e)
        {
            if (enemy.WeaponEnemy.Picture.Location.X <= 0)
            {
                enemy.RemoveWeaponEnemy();
                timerWeaponEnemy.Stop();
            }
            else if (enemy.WeaponEnemy.Picture.Bounds.IntersectsWith(player.Picture.Bounds))
            {
                timerWeaponEnemy.Stop();
                enemy.RemoveWeaponEnemy();
                System.Media.SoundPlayer hitSoundPlayer = new System.Media.SoundPlayer(Properties.Resources.sound_hitPlayerEffect);
                hitSoundPlayer.Play();
                enemy.DefeatedPlayer(player);
                labelPlayerInfo.Text = player.DisplayData();
                labelEnemyInfo.Text = enemy.DisplayDataEnemy();
                
                if(enemy is Boss)
                {
                    enemy.HealthRecoveryBoss();
                }
                if (player.Life == 0 && player.Health <= 0)
                {
                    player.Picture.Dispose();
                    if (enemy.WeaponEnemy.Picture.Location.X >= 0)
                    {
                        player.RemoveWeapon();
                    }
                    panelPlayer.Visible = true;
                    timerEnemy.Stop();
                    timerTime.Stop();
                    timerWeapon.Stop();
                    timerWeaponEnemy.Stop();

                    MessageBox.Show("You Lose");
                }
            }
            else
            {
                enemy.ReleaseWeaponEnemy();
                enemy.DisplayWeaponEnemy(this);
            }
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if(player.Picture.Location.Y >= panelData.Height + 30)
                {
                    player.MoveUp(10);
                    player.DisplayPicture(this);
                }
            }
            else if (e.KeyCode == Keys.X)
            {
                if (player.Picture.Location.Y <= this.Height - player.Picture.Size.Height)
                {
                    player.MoveDown(10);
                    player.DisplayPicture(this);
                }
            }
            else if (timerWeapon.Enabled == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    System.Media.SoundPlayer weaponSound = new System.Media.SoundPlayer(Properties.Resources.sound_weapon);
                    weaponSound.Play();

                    player.SetWeapon(player.Weapon.Name, player.Weapon.Description, player.Weapon.Picture.Image);
                    count += 1;

                    player.DisplayWeapon(this);
                    timerWeapon.Interval = 50;
                    timerWeapon.Start();

                    if (count >= 5)
                    {
                        if (count % 5 == 0)
                        {
                            MessageBox.Show("Your Ultimate is Ready, Use it and Destroy Your Enemy Very Soon!");
                            FormSelectWeapon formSelectWeapon = new FormSelectWeapon();
                            formSelectWeapon.Owner = this;
                            formSelectWeapon.ShowDialog();
                        }
                        if (player.Weapon.Name == "Ultimate")
                        {
                            count = 0;
                        }
                    }
                }
            }
        }
        private bool CheckWeapon()
        {
            bool result = false;
            if (enemy is Monster)
            {
                if (enemy.Name == "Dragon" && (player.Weapon.Name == "FireBall" || player.Weapon.Name == "Ultimate"))
                {
                    result = true;
                }
                else if (enemy.Name == "Godzilla" && (player.Weapon.Name == "Rock" || player.Weapon.Name == "Ultimate"))
                {
                    result = true;
                }
                else if (enemy.Name == "Red Monster" && (player.Weapon.Name == "Knive" || player.Weapon.Name == "Ultimate"))
                {
                    result = true;
                }
            }
            else if (enemy is Witch)
            {
                if (player.Weapon.Name == "Knive" || player.Weapon.Name == "Ultimate")
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }

            return result;
        }
        private void linkLabelSelectWeapon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectWeapon formSelectWeapon = new FormSelectWeapon();
            formSelectWeapon.Owner = this;
            formSelectWeapon.ShowDialog();
        }

        private void linkLabelSelectArena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSelectArena formSelectArena = new FormSelectArena();
            formSelectArena.Owner = this;
            formSelectArena.ShowDialog();
        }
    }
}
