using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Weapon
    {
        #region FIELDS
        private string name;
        private string description;
        private PictureBox picture = new PictureBox();
        #endregion

        #region CONSTRUCTORS
        public Weapon(string name, string description, Image image, Point position, Size size)
        {
            this.Name = name;
            this.Description = description;
            this.Picture.Image = image;
            this.Picture.Location = position;
            this.Picture.Size = size;
        }
        #endregion

        #region PROPERTIES
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public PictureBox Picture { get => picture; set => picture = value; }
        #endregion

        #region METHODS
        public string DisplayData()
        {
            string result = "";

            result = "Weapon Name: " + Name +
                     "\nDescription: " + Description;

            return result;
        }
        #endregion
    }
}