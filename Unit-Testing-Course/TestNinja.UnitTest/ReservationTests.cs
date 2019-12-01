using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
				[TestFixture]
				public class ReservationTests
				{
								[Test]
								public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
								{
												// Arrange
												var reservation = new Reservation();

												// Act
												var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

												// Assert
												Assert.IsTrue(result);
								}

								[Test]
								public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
								{
												var user = new User();
												var reservation = new Reservation {MadeBy = user };

												var result = reservation.CanBeCancelledBy(user);

												Assert.That(result, Is.True);
								}

								[Test]
								public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnFalse()
								{
												var user = new User();
												var anotherUser = new User();
												var reservation = new Reservation { MadeBy = user };

												var result = reservation.CanBeCancelledBy(anotherUser);

												Assert.IsFalse(result);
								}
				}
}
