using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTest.Mocking
{
				[TestFixture]
				class VideoServiceTests
				{
								[Test]
								public void ReadVideoTitle_EmptyFile_ReturnError()
								{
												var fileReader = new Mock<IFileReader>();
												fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

												var service = new VideoService(fileReader.Object);

												var result = service.ReadVideoTitle();

												Assert.That(result, Does.Contain("error").IgnoreCase);
												
								}
				}
}
