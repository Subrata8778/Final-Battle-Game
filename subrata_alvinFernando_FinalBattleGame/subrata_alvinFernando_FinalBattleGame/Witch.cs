using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Witch : Enemy
    {
        #region FIELDS
        private int healthDamage;
        #endregion

        #region CONTRUCTORS
        public Witch(string name, int life, int health, Image image, Point position, Size size, int speed, int healthDamage) : base(name, life, health, image, position, size, speed)
        {
            this.HealthDamage = healthDamage;
        }
        #endregion

        #region PROPERTIES
        public int HealthDamage 
        { 
            get => healthDamage;
            set
            {
                if (value > 0 && value <= 100)
                {
                    healthDamage = value;
                }
                else
                {
                    throw new Exception("Health Damage must be 1-100%");
                }
            }
        }
        #endregion

        #region METHODS
        public override string DisplayDataEnemy()
        {
            string result = "";

            result = "WITCH \n" +
                     DisplayData() +
                     "\nHealth Damage : " + HealthDamage;

            return result;
        }
        #endregion
    }
}