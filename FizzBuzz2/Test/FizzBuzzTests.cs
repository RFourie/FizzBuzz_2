using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz2.Test
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void ShouldReturnNumberIfNotDivisibleByThreeOrFive()
        {
            var fb = new FizzBuzz();

            Assert.AreEqual("1", fb.ReturnFizzOrBuzz(1));
        }

        [Test]
        public void ShouldReturnFizzIfDivisibleByThree()
        {
            var fb = new FizzBuzz();

            Assert.AreEqual("Fizz", fb.ReturnFizzOrBuzz(3));
        }

        [Test]
        public void ShouldReturnFizzIfDivisibleByFive()
        {
            var fb = new FizzBuzz();

            Assert.AreEqual("Buzz", fb.ReturnFizzOrBuzz(5));
        }

        [Test]
        public void ShouldReturnFizzIfDivisibleByThreeAndFive()
        {
            var fb = new FizzBuzz();

            Assert.AreEqual("FizzBuzz", fb.ReturnFizzOrBuzz(15));
        }
    }
}
