using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    /// <summary>
    /// main class
    /// Contains all methods for performing basic math functions.
    /// </summary>
    /// <remarks>class math dapat membuat operasi tambah (add), pengurangan (subtract)</remarks>
    public class Math
    {
        /// <summary>
        /// Operasi pertambahan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pertambahan</param>
        /// <param name="b">angka kedua yang akan ditambah dengan angka pertama</param>
        /// <returns>hasil dari penjumlahan angka pertama dan angka kedua</returns>
        public static int Add(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        /// <summary>
        /// Adds two doubles and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two doubles.
        /// </returns>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max
        /// and the other is greater than zero.</exception>
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        /// <summary>
        /// Multiplies two integers <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The product of two integers.
        /// </returns>
        /// <example>
        /// <code>
        /// int c = Math.Multiply(4, 5);
        /// if (c > 100)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// See <see cref="Math.Multiply(double, double)"/> to multiply doubles.
        /// <seealso cref="Math.Add(int, int)"/>
        /// <seealso cref="Math.Subtract(int, int)"/>
        /// <seealso cref="Math.Divide(int, int)"/>
        /// <param name="a">An integer.</param>
        /// <param name="b">An integer.</param>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Multiplies two doubles <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The product of two doubles.
        /// </returns>
        /// <example>
        /// <code>
        /// double c = Math.Multiply(4.5, 5.4);
        /// if (c > 100.0)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// See <see cref="Math.Multiply(int, int)"/> to multiply integers.
        /// <seealso cref="Math.Add(double, double)"/>
        /// <seealso cref="Math.Subtract(double, double)"/>
        /// <seealso cref="Math.Divide(double, double)"/>
        /// <param name="a">A double precision number.</param>
        /// <param name="b">A double precision number.</param>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

    }
}