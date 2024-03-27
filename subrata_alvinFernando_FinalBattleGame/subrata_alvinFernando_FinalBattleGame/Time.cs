using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace subrata_alvinFernando_FinalBattleGame
{
    public class Time
    {
        public bool timeStatus = false;

        #region FIELDS
        private int hour;
        private int minute;
        private int second;
        #endregion

        #region CONSTRUCTORS
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        #endregion

        #region PROPERTIES
        public int Hour 
        { 
            get => hour;
            set
            {
                if(value >=0 && value <= 23)
                {
                    hour = value;
                }
                else
                {
                    throw new Exception("Hour must be between 0 and 23");
                }
            }
        }
        public int Minute 
        { 
            get => minute;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minute = value;
                }
                else
                {
                    throw new Exception("Minute must be between 0 and 59");
                }
            }
        }
        public int Second 
        { 
            get => second; 
            set
            {
                if (value >= 0 && value <= 59)
                {
                    second = value;
                }
                else
                {
                    throw new Exception("Second must be between 0 and 59");
                }
            }
        }
        #endregion

        #region METHODS
        public int ConvertToSecond()
        {
            int result = 0;

            result = Hour * 3600 + Minute * 60 + Second;

            return result;
        }
        public void AddSecond(int addedSecond)
        {
            int totalSecond = ConvertToSecond() + addedSecond;

            if (totalSecond % 5 == 0)
            {
                timeStatus = true;
            }
            else
            {
                timeStatus = false;
            }

            Hour = totalSecond / 3600;
            Minute = (totalSecond % 3600) / 60;
            Second = (totalSecond % 3600) % 60;
        }
        public string DisplayData()
        {
            string result = "";

            result = Hour.ToString().PadLeft(2, '0') + ":" + Minute.ToString().PadLeft(2, '0') + ":" + Second.ToString().PadLeft(2, '0');

            return result;
        }
        #endregion
    }
}