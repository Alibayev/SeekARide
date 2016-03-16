using System.Collections.Generic;

namespace SeekARide.Models {
	public class TripInformation {
		public virtual ICollection<User> Users {get; set; }
		public virtual Trip Trip { get; set; }
	}
}