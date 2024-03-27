using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Player : GameActor
    {
        #region FIELDS
        private string description;
        private int score;
        private Weapon weapon;
        #endregion

        #region CONSTRUCTORS
        public Player(string name, int life, int health, Image image, Point position, Size size, string description, int score) : base(name, life, health, image, position, size)
        {
            this.Description = description;
            this.Score = score;
            this.Weapon = null;
        }
        #endregion

        #region PROPERTIES
        public string Description
        {
            get => description;
            set => description = value;
        }
        public int Score
        {
            get => score;
            set
            {
                if (value >= 0)
                {
                    score = value;
                }
                else
                {
                    throw new Exception("Score minimum is 0");
                }
            }
        }
        public Weapon Weapon
        {
            get => weapon;
            private set => weapon = value;
        }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            string result = "";

            result = DisplayDataActor() +
                "\nScore: " + Score +
                "\nWeapon Name: " + Weapon.Name;

            return result;
        }
        public void SetWeapon(string name, string description, Image image)
        {
            Point position = new Point(Picture.Location.X + 80, Picture.Location.Y + 80);
            Size size = new Size(30, 30);
            Weapon = new Weapon(name, description, image, position, size);
        }
        public void DisplayWeapon(Control displayContainer)
        {
            Weapon.Picture.Parent = displayContainer;
            Weapon.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Weapon.Picture.BackColor = Color.Transparent;
            Weapon.Picture.BringToFront();
        }
        public void DisplayWeapon()
        {
            Weapon.Picture.Location = new Point(Weapon.Picture.Location.X + 30, Weapon.Picture.Location.Y);
        }
        public void ReleaseWeapon()
        {
            int distance = 30;
            this.Weapon.Picture.Location = new Point(this.Weapon.Picture.Location.X + distance, this.Weapon.Picture.Location.Y);
        }
        public void RemoveWeapon()
        {
            Weapon.Picture.Dispose();
        }
        public void DefeatEnemy(Enemy enemy)
        {
            if (Weapon.Name == "Ultimate")
            {
                if (enemy is Monster)
                {
                    enemy.Health -= 75;
                    Score += 200;
                }
                else if (enemy is Witch)
                {
                    int healthDamage = ((Witch)enemy).HealthDamage + 50;
                    enemy.Health -= healthDamage;
                    Score += 80 * healthDamage;
                }
                else if (enemy is Boss)
                {
                    int healthRecovery = ((Boss)enemy).HealthRecovery;
                    enemy.Health -= 75;
                    Score += 1000;
                }
            }
            else
            {
                if (enemy is Monster)
                {
                    enemy.Health -= 50;
                    Score += 100;
                }
                else if (enemy is Witch)
                {
                    int healthDamage = ((Witch)enemy).HealthDamage;
                    enemy.Health -= healthDamage;
                    Score += 50 * healthDamage;
                }
                else if (enemy is Boss)
                {
                    int healthRecovery = ((Boss)enemy).HealthRecovery;
                    enemy.Health -= 1;
                    Score += 200;
                }
            }

            if (enemy.Health <= 0 && enemy.Life > 0)
            {
                enemy.Life--;
                enemy.Health = 100;
            }
        }
        #endregion
    }
}