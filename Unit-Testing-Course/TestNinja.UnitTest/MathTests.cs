using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest
{
				[TestFixture]
				public class MathTests
				{
								private Math _math;
								// Setup

								[SetUp]
								public void SetUp()
								{
												_math = new Math();
								}

								// Teardown

								[Test]
								[Ignore("Because I wanted to")]
								public void Add_WhenCalled_ReturnTheSumOfArguments()
								{

												var result = _math.Add(1, 2);

												Assert.That(result, Is.EqualTo(3));
								}

								[Test]
								[TestCase(2, 1, 2)]
								[TestCase(1, 2, 2)]
								[TestCase(1, 1, 1)]
								public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
								{

												var result = _math.Max(a, b);

												Assert.That(result, Is.EqualTo(expectedResult));
								}

								//[Test]
								//public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
								//{

								//				var result = _math.Max(1, 2);

								//				Assert.That(result, Is.EqualTo(2));
								//}

								//[Test]
								//public void Max_ArgumentsAreEqaul_ReturnTheSameArgument()
								//{

								//				var result = _math.Max(1, 1);

								//				Assert.That(result, Is.EqualTo(1));

								//}

								[Test]
								public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUpToLimit()
								{
												var result = _math.GetOddNumbers(5);

												//Assert.That(result, Is.Not.Empty);
												//Assert.That(result.Count, Is.EqualTo(5));
												//Assert.That(result, Does.Contain(1));
												//Assert.That(result, Does.Contain(3));
												//Assert.That(result, Does.Contain(5));

												Assert.That(result, Is.EquivalentTo(new[] {1, 3, 5}));


								}
				}
}
