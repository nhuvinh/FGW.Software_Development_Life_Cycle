using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
				[TestFixture]
				class FizzBuzzTests
				{
								[Test]
								[TestCase(15, "FizzBuzz")]
								[TestCase(3, "Fizz")]
								[TestCase(5, "Buzz")]
								[TestCase(1, "1")]

								public void GetOutput_WhenCalled_ReturnCorrectString(int input, string expectedResult)
								{
												var result = FizzBuzz.GetOutput(input);

												Assert.That(result, Is.EqualTo(expectedResult));
								}
				}
}
