  public static class Vector3Extensions 
    {
        public static Vector3 WithX(this Vector3 vector, float x) => new Vector3(x, vector.y, vector.z);
        
        public static Vector3 WithY(this Vector3 vector, float y) => new Vector3(vector.x, y, vector.z);
        
        public static Vector3 WithZ(this Vector3 vector, float z) => new Vector3(vector.x, vector.y, z);

        public static float ReversedNormalizedDistance(this Vector3 currentPos, Vector3 target, float totalDistance)
        {
            float distance = Vector3.Distance(currentPos, target);
            return 1 - distance / totalDistance;
        }
        
        public static float NormalizedDistance(this Vector3 currentPos, Vector3 target, float totalDistance)
        {
            float distance = Vector3.Distance(currentPos, target);
            return distance / totalDistance;
        }

        /// <summary>
        /// Receives two vectors and adds them together
        /// </summary>
        /// <param name="vector">The vector the offset is applied to</param>
        /// <param name="offset"></param>
        /// <returns>A vector with an offset to the initial vector</returns>
        public static Vector3 Offset(this Vector3 vector, Vector3 offset) =>
            new Vector3(vector.x + offset.x, vector.y + offset.y, vector.z + offset.z);
    }
