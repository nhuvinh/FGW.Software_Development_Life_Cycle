using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
				class DemeritPointsCalculatorTests
				{
								[Test]
								[TestCase(-1)]
								[TestCase(301)]
								public void CalculateDemeritPoints_InvalidSpeed_ThrowArgumentException(int speed)
								{
												var demeritPointsCalculator = new DemeritPointsCalculator();

												Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(speed), 
																Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
								}

								[Test]
								[TestCase(65)]
								[TestCase(64)]
								public void CalculateDemeritPoints_LessOrEqualSpeedLimit_Return0(int speed)
								{
												var calculator = new DemeritPointsCalculator();

												var result = calculator.CalculateDemeritPoints(speed);

												Assert.That(result, Is.EqualTo(0));
								}

								[Test]
								public void CalculateDemeritPoints_ValidSpeed_ReturnValideDemeritPoints()
								{
												var calculator = new DemeritPointsCalculator();

												var result = calculator.CalculateDemeritPoints(100);

												Assert.That(result, Is.EqualTo(7));
								}
				}
}
