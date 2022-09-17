using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tzdevil.DevilUtils
{
    public static class DebugOp
    {
        public static Color DefaultColor = Color.yellow;
        #region Draw a Debug Line between Vectors
        /// <summary>
        /// Dray a line between two vectors.
        /// </summary>
        /// <remarks>
        /// <code>DrawLine(vectorOne, vectorTwo, color);</code>
        /// </remarks>
        public static void DrawLine(Vector3 vectorOne, Vector3 vectorTwo, Color? color = null)
        {
            if (color == null)
                color = DefaultColor;

            Debug.DrawLine(vectorOne, vectorTwo, (Color)color, 100f);
        }

        /// <summary>
        /// Dray a line between a list of vectors.
        /// </summary>
        /// <remarks>
        /// <code>DrawLine(vectors, color);</code>
        /// </remarks>
        public static void DrawLine(List<Vector3> vectors, Color? color = null)
        {
            var count = vectors.Count;
            for (int i = 0; i < count; i++)
            {
                if (i == count)
                    break;

                DrawLine(vectors[i], vectors[i + 1], color);
            }
        }
        #endregion

        #region Draw Shapes
        /// <summary>
        /// Dray a square with a given starting point and the length.
        /// </summary>
        /// <remarks>
        /// <code>DrawSquare(startingPoint, length, color);</code>
        /// </remarks>
        public static void DrawSquare(Vector2 startingPoint, float length, Color? color = null)
        {
            var point2 = startingPoint + new Vector2(length, 0);
            var point3 = startingPoint + new Vector2(0, length);
            var point4 = startingPoint + new Vector2(length, length);

            DrawLine(startingPoint, point2, color);
            DrawLine(startingPoint, point3, color);
            DrawLine(point2, point4, color);
            DrawLine(point3, point4, color);
        }
        #endregion
    }
}