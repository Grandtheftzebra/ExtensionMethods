using UnityEngine;

namespace SpaghettiStudios.ExtensionMethods
{
    public static class Vector3Offset
    {
        /// <summary>
        /// Receives two vectors and adds them together
        /// </summary>
        /// <param name="vector">The vector the offset is applied to</param>
        /// <param name="offset"></param>
        /// <returns>A vector with an offset to the initial vector</returns>
        public static Vector3 Offset(this Vector3 vector, Vector3 offset) =>
            new Vector3(vector.x + offset.x, vector.y + offset.y, vector.z + offset.z);
    }
}
