using System.Collections.Generic;
using UnityEngine;

namespace tzdevil.DevilUtils
{
    public static class VectorOp
    {
        #region Closest Vector
        /// <summary>
        /// Find the closest Vector from a list of vectors and a main Vector.
        /// </summary>
        /// <remarks>
        /// <code>thisVector.GetClosest(vectors);</code>
        /// </remarks>
        public static Vector3 GetClosest(this Vector3 thisVector, List<Vector3> vectors)
        {
            if (vectors == null || vectors.Count == 0)
            {
                Debug.LogError($"{vectors} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;
            var closestPoint = Vector3.zero;

            for (int i = 0; i < vectors.Count; i++)
            {
                var point = vectors[i];

                var distance = Vector3.Distance(thisVector, point);
                if (distance < closest)
                {
                    closestPoint = point;
                    closest = distance;
                }
            }

            return closestPoint;
        }

        /// <summary>
        /// Find the distance of the closest Vector from a list of vectors and a main Vector.
        /// </summary>
        /// <remarks>
        /// <code>thisVector.GetClosestDistance(vectors);</code>
        /// </remarks>
        public static float GetClosestDistance(this Vector3 thisVector, List<Vector3> vectors)
        {
            if (vectors == null || vectors.Count == 0)
            {
                Debug.LogError($"{vectors} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;

            for (int i = 0; i < vectors.Count; i++)
            {
                var point = vectors[i];

                var distance = Vector3.Distance(thisVector, point);
                if (distance < closest)
                    closest = distance;
            }

            return closest;
        }

        /// <summary>
        /// Find the closest Game Object from a list of game objects and a main Game Object.
        /// </summary>
        /// <remarks>
        /// <code>thisTransform.GetClosest(transforms);</code>
        /// </remarks>
        public static Vector3 GetClosest(this Transform thisTransform, List<Transform> transforms)
        {
            if (transforms == null || transforms.Count == 0)
            {
                Debug.LogError($"{transforms} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;
            var closestPoint = Vector3.zero;

            for (int i = 0; i < transforms.Count; i++)
            {
                var point = transforms[i];

                var distance = Vector3.Distance(thisTransform.position, point.position);
                if (distance < closest)
                {
                    closestPoint = point.position;
                    closest = distance;
                }
            }

            return closestPoint;
        }

        /// <summary>
        /// Find the distance of closest Game Object from a list of game objects and a main Game Object.
        /// </summary>
        /// <remarks
        /// <code>thisTransform.GetClosestDistance(transforms);</code>
        /// </remarks>
        public static float GetClosestDistance(this Transform thisTransform, List<Transform> transforms)
        {
            if (transforms == null || transforms.Count == 0)
            {
                Debug.LogError($"{transforms} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;

            for (int i = 0; i < transforms.Count; i++)
            {
                var point = transforms[i];

                var distance = Vector3.Distance(thisTransform.position, point.position);
                if (distance < closest)
                    closest = distance;
            }

            return closest;
        }

        /// <summary>
        /// Find the distance closest Game Object from a list of game objects and a main vector.
        /// </summary>
        /// <remarks
        /// <code>thisTransform.GetClosestDistance(transforms);</code>
        /// </remarks>
        public static float GetClosestDistance(this Vector3 thisVector, List<Transform> transforms)
        {
            if (transforms == null || transforms.Count == 0)
            {
                Debug.LogError($"{transforms} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;

            for (int i = 0; i < transforms.Count; i++)
            {
                var point = transforms[i];

                var distance = Vector3.Distance(thisVector, point.position);
                if (distance < closest)
                    closest = distance;
            }

            return closest;
        }

        /// <summary>
        /// Find the distance closest Vector from a list of vectors and a main Game Object.
        /// </summary>
        /// <remarks
        /// <code>thisTransform.GetClosestDistance(transforms);</code>
        /// </remarks>
        public static float GetClosestDistance(this Transform thisTransform, List<Vector3> vectors)
        {
            if (vectors == null || vectors.Count == 0)
            {
                Debug.LogError($"{vectors} list has no items");
                return default;
            }

            var closest = float.PositiveInfinity;

            for (int i = 0; i < vectors.Count; i++)
            {
                var point = vectors[i];

                var distance = Vector3.Distance(thisTransform.position, point);
                if (distance < closest)
                    closest = distance;
            }

            return closest;
        }
        #endregion
    }
}
