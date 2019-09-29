using System;

struct Vec2f
{
    public float x;
    public float y;

    /// <summary>
    /// Enter in the numbers 0 or 1 to denote which coordinate you want to get or set
    /// </summary>
    /// <param name="i">0 or 1, used to determine which portion of the coordinate is being questioned</param>
    /// <returns></returns>
    public float this[int i]
    {
        get
        {
            if (i == 0) return x;
            if (i == 1) return y;
            throw new InvalidOperationException();
        }
        set
        {
            if (i == 0) x = value;
            else if (i == 1) y = value;
            else throw new InvalidOperationException();
        }
    }

    /// <summary>
    /// Takes the coordinates and divide them by the hypotenuse
    /// </summary>
    /// <returns></returns>
    public Vec2f Normalize()
    {
        return this / Norm();
    }

    /// <summary>
    /// Returns the hypotenuse length between the two coordinates
    /// </summary>
    /// <returns></returns>
    public float Norm()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }

    /// <summary>
    /// Overloading the division operator to change the scale of division
    /// </summary>
    /// <param name="v">The point in question</param>
    /// <param name="num">the number to be divided by</param>
    /// <returns></returns>
    public static Vec2f operator /(Vec2f v, float num)
    {
        v.x /= num;
        v.y /= num;

        return v;
    }

    /// <summary>
    /// Overloads the multiplication operator to change the scale of multiplying
    /// </summary>
    /// <param name="v">The point in questiom</param>
    /// <param name="num">the number to multiply by</param>
    /// <returns></returns>
    public static Vec2f operator *(Vec2f v, float num)
    {
        v.x *= num;
        v.y *= num;

        return v;
    }

    /// <summary>
    /// Takes in two vectors and returns the difference
    /// </summary>
    /// <param name="a">First point</param>
    /// <param name="b">Second point that gets subtracted</param>
    /// <returns></returns>
    public static Vec2f operator -(Vec2f a, Vec2f b)
    {
        return new Vec2f { x = a.x - b.x, y = a.y - b.y };
    }

    /// <summary>
    /// Adds two vectors together
    /// </summary>
    /// <param name="a">The first point</param>
    /// <param name="b">The second point to be added on</param>
    /// <returns></returns>
    public static Vec2f operator +(Vec2f a, Vec2f b)
    {
        return new Vec2f { x = a.x + b.x, y = a.y + b.y };
    }
}

public struct Vec3f
{
    public float x;
    public float y;
    public float z;

    /// <summary>
    /// Get or set the value of a dimension based on numbers 0-2 entered. If something else is entered, throw an exception
    /// </summary>
    /// <param name="i">Indicates which dimension is being modified</param>
    /// <returns></returns>
    public float this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return x;
                case 1: return y;
                case 2: return z;
                default: throw new InvalidOperationException();
            }
        }
        set
        {
            switch (i)
            {
                case 0: x = value; break;
                case 1: y = value; break;
                case 2: z = value; break;
                default: throw new InvalidOperationException();
            }
        }
    }

    /// <summary>
    /// Divide by the number gotten below, leaving the vector pointing in the same direction but with length 1
    /// </summary>
    /// <returns></returns>
    public Vec3f Normalize()
    {
        return this / Norm();
    }

    /// <summary>
    /// Calculates the number used to normalize with a square root function
    /// </summary>
    /// <returns></returns>
    public float Norm()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z);
    }

    /// <summary>
    /// Subtracts the dimensions between two 3D points
    /// </summary>
    /// <param name="a">The first point in question</param>
    /// <param name="b">The second point being subtracted off</param>
    /// <returns></returns>
    public static Vec3f operator -(Vec3f a, Vec3f b)
    {
        return new Vec3f { x = a.x - b.x, y = a.y - b.y, z = a.z - b.z };
    }

    /// <summary>
    /// Divides each dimension by the number specified
    /// </summary>
    /// <param name="v">The point to be modified</param>
    /// <param name="num">The number to divide by</param>
    /// <returns></returns>
    public static Vec3f operator /(Vec3f v, float num)
    {
        v.x /= num;
        v.y /= num;
        v.z /= num;

        return v;
    }

    /// <summary>
    /// Multiplies each dimension by the number entered in
    /// </summary>
    /// <param name="v">The point to be changed</param>
    /// <param name="num">The number to multiply by</param>
    /// <returns></returns>
    public static Vec3f operator *(Vec3f v, float num)
    {
        v.x *= num;
        v.y *= num;
        v.z *= num;

        return v;
    }
}

struct Vec4f
{
    public float x;
    public float y;
    public float z;
    public float h;

    /// <summary>
    /// Takes in numbers 0-3 to determine which element to get or set
    /// </summary>
    /// <param name="i">The number used to specify which element to get or set</param>
    /// <returns></returns>
    public float this[int i]
    {
        get
        {
            switch (i)
            {
                case 0: return x;
                case 1: return y;
                case 2: return z;
                case 3: return h;
                default: throw new InvalidOperationException();
            }
        }
        set
        {
            switch (i)
            {
                case 0: x = value; break;
                case 1: y = value; break;
                case 2: z = value; break;
                case 3: h = value; break;
                default: throw new InvalidOperationException();
            }
        }
    }

    /// <summary>
    /// Normalizes the vector by modifying its length to a constant value using the number found below
    /// </summary>
    /// <returns></returns>
    public Vec4f Normalize()
    {
        var len = Norm();
        return this / len;
    }

    /// <summary>
    /// Returns the normalization number to be used in further calculation
    /// </summary>
    /// <returns></returns>
    public float Norm()
    {
        return (float)Math.Sqrt(x * x + y * y + z * z + h * h);
    }

    /// <summary>
    /// Calculates the difference between all four elements of two vectors
    /// </summary>
    /// <param name="a">The number to be subtracted from</param>
    /// <param name="b">The point that is being subtracted</param>
    /// <returns></returns>
    public static Vec4f operator -(Vec4f a, Vec4f b)
    {
        return new Vec4f { x = a.x - b.x, y = a.y - b.y, z = a.z - b.z, h = a.h - b.h };
    }

    /// <summary>
    /// Divides the vector by the number entered in
    /// </summary>
    /// <param name="v">The point being divided</param>
    /// <param name="num">The number to divide by</param>
    /// <returns></returns>
    public static Vec4f operator /(Vec4f v, float num)
    {
        v.x /= num;
        v.y /= num;
        v.z /= num;
        v.h /= num;

        return v;
    }
}

struct Vec2i
{
    public int x;
    public int y;

    /// <summary>
    /// Subtracts the two dimensions of two vectors
    /// </summary>
    /// <param name="a">The point being subtracted from</param>
    /// <param name="b">The point being subtracted</param>
    /// <returns></returns>
    public static Vec2i operator -(Vec2i a, Vec2i b)
    {
        return new Vec2i { x = a.x - b.x, y = a.y - b.y };
    }
}

struct Vec3i
{
    public int x;
    public int y;
    public int z;

    /// <summary>
    /// Subtracts three dimensions between two points
    /// </summary>
    /// <param name="a">The point being subtracted from</param>
    /// <param name="b">The point being subtracted</param>
    /// <returns></returns>
    public static Vec3i operator -(Vec3i a, Vec3i b)
    {
        return new Vec3i { x = a.x - b.x, y = a.y - b.y, z = a.z - b.z };
    }
}

/// <summary>
/// Class used to establish and return geometric shapes
/// </summary>
static class Geometry
{
    /// <summary>
    /// I have no idea what this is supposed to be doing
    /// </summary>
    /// <param name="l">The first point taken in</param>
    /// <param name="r">The second point</param>
    /// <returns></returns>
    public static Vec3f Cross(Vec3f l, Vec3f r)
    {
        return new Vec3f
        {
            x = l.y * r.z - l.z * r.y,
            y = l.z * r.x - l.x * r.z,
            z = l.x * r.y - l.y * r.x
        };
    }

    /// <summary>
    /// Multiplies each dimension by each other to rescale the object, although probably not exact scaling
    /// </summary>
    /// <param name="l">The first point</param>
    /// <param name="r">The second point</param>
    /// <returns></returns>
    public static float Dot(Vec3f l, Vec3f r)
    {
        return l.x * r.x + l.y * r.y + l.z * r.z;
    }

    /// <summary>
    /// Returns a new vector with the same dimensions but indicates a filled alpha channel
    /// </summary>
    /// <param name="v">The initial vector being filled</param>
    /// <param name="fill">The number 1 to represent a shaded cell</param>
    /// <returns></returns>
    public static Vec4f Embed4D(Vec3f v, float fill = 1)
    {
        return new Vec4f { x = v.x, y = v.y, z = v.z, h = fill };
    }

    /// <summary>
    /// Takes in a 3D vector and converts it into a new 2D vector
    /// </summary>
    /// <param name="v">The 3D vector being taken in</param>
    /// <returns></returns>
    public static Vec2f Project2D(Vec3f v)
    {
        return new Vec2f { x = v.x, y = v.y };
    }

    /// <summary>
    /// Takes in a 4D vector and converts it into a new 2D vector
    /// </summary>
    /// <param name="v">The 4D vector being taken in</param>
    /// <returns></returns>
    public static Vec2f Project2D(Vec4f v)
    {
        return new Vec2f { x = v.x, y = v.y };
    }

    /// <summary>
    /// Takes in a 4D vector and converts it into a new 3D vector
    /// </summary>
    /// <param name="v">The 4D vector being taken in</param>
    /// <returns></returns>
    public static Vec3f Project3D(Vec4f v)
    {
        return new Vec3f { x = v.x, y = v.y, z = v.z };
    }
}
