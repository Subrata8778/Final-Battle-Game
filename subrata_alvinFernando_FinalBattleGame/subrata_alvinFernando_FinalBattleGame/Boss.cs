using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Boss : Enemy
    {
        #region FIELDS
        private int healthRecovery;
        #endregion

        #region CONSTRUCTORS
        public Boss(string name, int life, int health, Image image, Point position, Size size, int speed, int healthRecovery) : base(name, life, health, image, position, size, speed)
        {
            this.HealthRecovery = healthRecovery;
        }
        #endregion

        #region PROPERTIES
        public int HealthRecovery 
        { 
            get => healthRecovery;
            set
            {
                if (value > 0 && value <= 100)
                {
                    healthRecovery = value;
                }
                else
                {
                    throw new Exception("Health Recovery must be 1-100");
                }
            } 
        }
        #endregion

        #region METHODS
        public override string DisplayDataEnemy()
        {
            string result = "";

            result = "BOSS \n" +
                     DisplayData() +
                     "\nHealth Recovery : " + HealthRecovery;

            return result;
        }
        public override int HealthRecoveryBoss()
        {
            int healthRecov = HealthRecovery;
            Health += healthRecov;

            return Health;
        }
        #endregion
    }
}