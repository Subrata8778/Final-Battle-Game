using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Monster : Enemy
    {
        #region FIELDS
        private string hint;
        #endregion

        #region CONSTRUCTORS
        public Monster(string name, int life, int health, Image image, Point position, Size size, int speed, string hint) : base(name, life, health, image, position, size, speed)
        {
            this.Hint = hint;
        }
        #endregion

        #region PROPERTIES
        public string Hint { get => hint; set => hint = value; }
        #endregion

        #region METHODS
        public override string DisplayDataEnemy()
        {
            string result = "";

            result = "Monster: \n" +
                     DisplayData() +
                     "\nHint: " + Hint;

            return result;
        }
        #endregion
    }
}