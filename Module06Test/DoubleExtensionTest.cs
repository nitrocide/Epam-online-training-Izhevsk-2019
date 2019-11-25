﻿using System;
using NUnit.Framework;
using Module06;

namespace Module06Test
{
    [TestFixture]
    public class DoubleExtensionsTest
    {
        [TestCase(0.314, ExpectedResult = "0011111111010100000110001001001101110100101111000110101001111111")]
        [TestCase(222222.22222, ExpectedResult = "0100000100001011001000000111000111000111000110110100011110000100")]
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(2.2250738585072009E-308, ExpectedResult = "0000000000001111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult =
            "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult =
            "0111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(-312.3125, ExpectedResult = "1100000001110011100001010000000000000000000000000000000000000000")]
        public string CheckDoubleToString(double number)
        {
            return number.ToBinaryString();
        }
    }
}
