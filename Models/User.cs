using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeekARide.Models {
	public class User {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string CellPhone { get; set; }

		public virtual ICollection<TripInformation> TripInformations { get; set; } 
	}
}