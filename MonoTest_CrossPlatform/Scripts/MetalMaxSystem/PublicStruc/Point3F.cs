﻿using Mathf = System.MathF;

namespace MetalMaxSystem
{
    //结构是值类型

    /// <summary>
    /// 三维点结构体
    /// </summary>
    public struct Point3F
    {
        public float x;
        public float y;
        public float z;

        public Point3F(float newX, float newY, float newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }

        public void Move(float dx, float dy, float dz)
        {
            x += dx;
            y += dy;
            z += dz;
        }

        public float DistanceTo(Point3F otherPoint)
        {
            float dx = otherPoint.x - x;
            float dy = otherPoint.y - y;
            float dz = otherPoint.z - z;
            return Mathf.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public static Point3F operator +(Point3F point1, Point3F point2)
        {
            return new Point3F(point1.x + point2.x, point1.y + point2.y, point1.z + point2.z);
        }

        public static Point3F operator -(Point3F point1, Point3F point2)
        {
            return new Point3F(point1.x - point2.x, point1.y - point2.y, point1.z - point2.z);
        }
    }
}
