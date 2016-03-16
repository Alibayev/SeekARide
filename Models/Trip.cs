using System;

namespace SeekARide.Models {
	public class Trip {
		public DateTime TravelDateTime { get; set; }
		public virtual Location From { get; set; }
		public virtual Location To { get; set; }
		public TripType Type { get; set; }

	}
}