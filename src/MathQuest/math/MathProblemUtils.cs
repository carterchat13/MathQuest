using System;
using MathQuest.enemies;

namespace MathQuest.math
{
    public class MathProblemUtils
    {
        public static void GetLeftRight(DifficultyLevel difficultyLevel, out int left, out int right)
        {
            int rangeLeft;
            int rangeRight;
            if (difficultyLevel == DifficultyLevel.Easy)
            {
                rangeLeft = 10;
                rangeRight = 10;
            }
            else if (difficultyLevel == DifficultyLevel.Medium)
            {
                rangeLeft = 50;
                rangeRight = 50;
            }
            else
            {
                //Hard Difficulty
                rangeLeft = 100;
                rangeRight = 100;
            }


            var rnd = new Random();
            left = rnd.Next(0, rangeLeft);
            right = rnd.Next(0, rangeRight);
        }
    }
}