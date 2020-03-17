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
				public class BookingHelperTests
				{
								[Test]
								public void OverlappingBookingsExist_BookingStartsAndFinishsBeforeAnExistingBooking_ReturnEmptyString()
								{
												var mock = new Mock<IBookingRepository>();
												mock.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking> {
																new Booking
																{
																				Id = 2,
																				ArrivalDate = ArriveOn(2019, 1, 15),
																				DepartureDate = DepartureOn(2019, 1, 20),
																				Reference = "a",
																}
												}.AsQueryable());

												var result = BookingHelper.OverlappingBookingsExist(new Booking
												{
																Id = 1,
																ArrivalDate = ArriveOn(2019, 12, 10),
																DepartureDate = DepartureOn(2019, 12, 14)
												}, mock.Object);

												Assert.That(result, Is.Empty);
								}

								private DateTime ArriveOn(int year, int month, int day)
								{
												return new DateTime(year, month, day, 14, 0, 0);
												
								}

								private DateTime DepartureOn(int year, int month, int day)
								{
												return new DateTime(year, month, day, 10, 0, 0);
								}
				}
}
