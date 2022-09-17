using UnityEngine;

namespace tzdevil.DevilUtils
{
    public static class TransformOp
    {
        #region Transform
        /// <summary>
        /// Use this method to set any value to a transform's position.
        /// </summary>
        /// <remarks>
        /// <code>transform.SetPosition(x, y, z);</code>
        /// <code>transform.SetPosition(x: number);</code>
        /// <code>transform.SetPosition(x: number, z: number);</code>
        /// <code>transform.SetPosition(y: number, z: number);</code>
        /// </remarks>
        public static void SetPosition(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var position = transform.position;
            transform.position = new Vector3(x == null ? position.x : x.Value,
                                             y == null ? position.y : y.Value,
                                             z == null ? position.z : z.Value);
        }
        /// <summary>
        /// Use this method to set any value to a transform's local position.
        /// </summary>
        /// <remarks>
        /// <code>transform.SetLocalPosition(x, y, z);</code>
        /// <code>transform.SetLocalPosition(x: number);</code>
        /// <code>transform.SetLocalPosition(x: number, z: number);</code>
        /// <code>transform.SetLocalPosition(y: number, z: number);</code>
        /// </remarks>
        public static void SetLocalPosition(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var localPosition = transform.localPosition;
            transform.localPosition = new Vector3(x == null ? localPosition.x : x.Value,
                                             y == null ? localPosition.y : y.Value,
                                             z == null ? localPosition.z : z.Value);
        }

        /// <summary>
        /// Use this method to set any value to a transform's rotation.
        /// </summary>
        /// <remarks>
        /// <code>transform.SetRotation(x, y, z);</code>
        /// <code>transform.SetRotation(x: number);</code>
        /// <code>transform.SetRotation(x: number, z: number);</code>
        /// <code>transform.SetRotation(y: number, z: number);</code>
        /// </remarks>
        public static void SetRotation(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var rotation = transform.rotation;
            transform.rotation = Quaternion.Euler(x == null ? rotation.x : x.Value,
                                             y == null ? rotation.y : y.Value,
                                             z == null ? rotation.z : z.Value);
        }

        /// <summary>
        /// Use this method to set any value to a transform's scale.
        /// </summary>
        /// <remarks>
        /// <code>transform.SetScale(x, y, z);</code>
        /// <code>transform.SetScale(x: number);</code>
        /// <code>transform.SetScale(x: number, z: number);</code>
        /// <code>transform.SetScale(y: number, z: number);</code>
        /// </remarks>
        public static void SetScale(this Transform transform, float? x = null, float? y = null, float? z = null)
        {
            var scale = transform.localScale;
            transform.localScale = new Vector3(x == null ? scale.x : x.Value,
                                             y == null ? scale.y : y.Value,
                                             z == null ? scale.z : z.Value);
        }
        #endregion
    }
}