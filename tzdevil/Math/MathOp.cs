using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tzdevil.DevilUtils
{
    public static class MathOp
    {
        #region Square/Square Root
        /// <summary>
        /// Use this method to get the square of a number.
        /// </summary>
        /// <remarks>
        /// <code>number.Sq();</code>
        /// </remarks>
        public static int Sq(this int number) => number * number;
        /// <summary>
        /// Use this method to get the square of a number.
        /// </summary>
        /// <remarks>
        /// <code>number.Sq();</code>
        /// </remarks>
        public static float Sq(this float number) => number * number;

        /// <summary>
        /// Use this method to get the square root of a number.
        /// </summary>
        /// <remarks>
        /// <code>number.Sqrt();</code>
        /// </remarks>
        public static float Sqrt(this int number) => Mathf.Sqrt(number);
        /// <summary>
        /// Use this method to get the square root of a number.
        /// </summary>
        /// <remarks>
        /// <code>number.Sqrt();</code>
        /// </remarks>
        public static float Sqrt(this float number) => Mathf.Sqrt(number);
        #endregion

        #region Find Angle between two objects
        /// <summary>
        /// Use this method to find the angle between two vectors.
        /// </summary>
        /// <remarks>
        /// <code>vectorOne.FindAngleBetweenVectors(vectorTwo);</code>
        /// </remarks>
        public static float FindAngle(this Vector3 vectorOne, Vector3 vectorTwo)
        {
            var xDiff = vectorOne.x - vectorTwo.x;
            var yDiff = vectorOne.y - vectorTwo.y;

            // Get the angle between player and target.
            float angle = Mathf.Atan2(yDiff, xDiff) * Mathf.Rad2Deg;

            return angle;
        }
        /// <summary>
        /// Use this method to find the angle between two game objects.
        /// </summary>
        /// <remarks>
        /// <code>transformOne.FindAngleBetweenObjects(transformTwo);</code>
        /// </remarks>
        public static float FindAngle(this Transform transformOne, Transform transformTwo)
        {
            var xDiff = transformOne.position.x - transformTwo.position.x;
            var yDiff = transformOne.position.y - transformTwo.position.y;

            // Get the angle between player and target.
            float angle = Mathf.Atan2(yDiff, xDiff) * Mathf.Rad2Deg;

            return angle;
        }
        #endregion

        #region Check if a number is a divisor of another.
        /// <summary>
        /// Use this method to check if a number is a divisor of another.
        /// </summary>
        /// <remarks>
        /// <code>number.IsDivisor(number2);</code>
        /// </remarks>
        public static bool IsDivisor(this int number, int dividedBy) => number % dividedBy == 0;
        #endregion
    }
}