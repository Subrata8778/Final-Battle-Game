using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public abstract class Enemy : GameActor
    {
        #region FIELDS
        private int speed;
        private WeaponEnemy weaponEnemy;
        #endregion

        #region CONSTRUCTORS
        public Enemy(string name, int life, int health, Image image, Point position, Size size, int speed) : base(name, life, health, image, position, size)
        {
            this.Speed = speed;
        }
        #endregion

        #region PROPERTIES
        public int Speed 
        { 
            get => speed;
            set
            {
                if(value >= 10)
                {
                    speed = value;
                }
                else
                {
                    throw new Exception("Speed must be greater than 10");
                }
            } 
        }
        public WeaponEnemy WeaponEnemy
        {
            get => weaponEnemy;
            set => weaponEnemy = value;
        }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            string result = "";

            result = base.DisplayDataActor() +
                    "\nSpeed: " + Speed;

            return result;
        }
        public abstract string DisplayDataEnemy();
        public virtual void SetWeaponEnemy(string name, Image image)
        {
            Point position = new Point(Picture.Location.X - 80, Picture.Location.Y + 80);
            Size size = new Size(30, 30);
            WeaponEnemy = new WeaponEnemy(name, image, position, size);
        }
        public virtual void DisplayWeaponEnemy(Control displayContainer)
        {
            WeaponEnemy.Picture.Parent = displayContainer;
            WeaponEnemy.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            WeaponEnemy.Picture.BackColor = Color.Transparent;
            WeaponEnemy.Picture.BringToFront();
        }
        public virtual void ReleaseWeaponEnemy()
        {
            WeaponEnemy.Picture.Location = new Point(WeaponEnemy.Picture.Location.X - 30, WeaponEnemy.Picture.Location.Y);
        }
        public virtual void RemoveWeaponEnemy()
        {
            WeaponEnemy.Picture.Dispose();
        }
        public virtual void DefeatedPlayer(Player player)
        {
            if (Name == "Devil Dust" || Name == "Vampire")
            {
                player.Health -= 40;
            }
            else
            {
                player.Health -= 20;
            }
            if (player.Health <= 0)
            {
                player.Life -= 1;
                player.Health = 100;
            }
        }
        public virtual int HealthRecoveryBoss()
        {
            return 0;
        }
        #endregion
    }
}