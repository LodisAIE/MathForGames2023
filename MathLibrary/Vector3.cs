using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public struct Vector3
    {
        public float X;
        public float Y;
        public float Z;

        /// <summary>
        /// Gets the length of the vector
        /// </summary>
        public float Magnitude
        {
            get { return 0; }
        }

        /// <summary>
        /// Gets the normalized version of this vector without changing it
        /// </summary>
        public Vector3 Normalized
        {
            get { return new Vector3(); }
        }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Changes the length of this vector to have a magnitude that is less than or eqaul to one
        /// </summary>
        /// <returns>The result of the normalization</returns>
        public Vector3 Normalize()
        {
            return new Vector3();
        }

        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>The dot product of the two vectors given</returns>
        public static float DotProduct(Vector3 lhs, Vector3 rhs)
        {
            return 0;
        }

        public static float Distance(Vector3 lhs, Vector3 rhs)
        {
            return 0;
        }

        /// <summary>
        /// Adds the x value of the second vector to the first, and adds the y value
        /// of the second vector to the first
        /// </summary>
        /// <param name="lhs">The vector that is increasing</param>
        /// <param name="rhs">The vector used to increase the 1st vector</param>
        /// <returns>The result of the vector addition</returns>
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3();
        }

        /// <summary>
        /// Subtracts the x value of the second vector from the first, and subtracts the y value
        /// of the second vector from the first
        /// </summary>
        /// <param name="lhs">The vector that is being subtracted from</param>
        /// <param name="rhs">The vector used to subtract from the first vector</param>
        /// <returns>The result of the vector subtraction</returns>
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3();
        }

        /// <summary>
        /// Multiplies the vector's x and y values by the scalar given
        /// </summary>
        /// <param name="lhs">The vector that is being scaled</param>
        /// <param name="rhs">The value to scale the vector by</param>
        /// <returns>The result of the vector scaling</returns>
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3();
        }

        /// <summary>
        /// Multiplies the vector's x and y values by the scalar given
        /// </summary>
        /// <param name="rhs">The vector that is being scaled</param>
        /// <param name="lhs">The value to scale the vector by</param>
        /// <returns>The result of the vector scaling</returns>
        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            return new Vector3();
        }

        /// <summary>
        /// Divides the vector's x and y values by the scalar given
        /// </summary>
        /// <param name="lhs">The vector that is being divided</param>
        /// <param name="rhs">The value to divide the vector by</param>
        /// <returns>The result of the vector division</returns>
        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3();
        }

        /// <summary>
        /// Compares the x and y values of two vectors
        /// </summary>
        /// <param name="lhs">The left side of the comparison</param>
        /// <param name="rhs">The right side of the comparison</param>
        /// <returns>True if the x values of both vectors match and the y values match</returns>
        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return false;
        }

        /// <summary>
        /// Compares the x and y values of two vectors
        /// </summary>
        /// <param name="lhs">The left side of the comparison</param>
        /// <param name="rhs">The right side of the comparison</param>
        /// <returns>True if the x values of both vectors don't match and the y values don't match</returns>
        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return false;
        }
    }
}
