using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
				public interface IBookingRepository
				{
								IQueryable<Booking> GetActiveBookings(int? excludeBookingId = null);
				}

				public class BookingRepository : IBookingRepository
				{
								public IQueryable<Booking> GetActiveBookings(int? excludeBookingId = null)
								{
												var unitOfWork = new UnitOfWork();
												var bookings =
																unitOfWork.Query<Booking>()
																				.Where(
																								b => b.Status != "Cancelled");
												if (excludeBookingId.HasValue)
																bookings = bookings.Where(b => b.Id != excludeBookingId.Value);
												return bookings;
								}
				}
}
