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
				class ErrorLoggerTests
				{
								[Test]
								public void Log_WhenCalled_SetTheLastErrorProperly()
								{
												var logger = new ErrorLogger();

												logger.Log("a");

												Assert.That(logger.LastError, Is.EqualTo("a"));
								}
				}
}
