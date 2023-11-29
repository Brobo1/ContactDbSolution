namespace ContactDbLib.DbModels {
	public class Contact {
		public int    Id        { get; set; }
		public string SSN       { get; set; }
		public string FirstName { get; set; }
		public string LastName  { get; set; }

		public Contact(string ssn, string firstName, string lastName) {
			SSN       = ssn;
			FirstName = firstName;
			LastName  = lastName;
		}
		public Contact(string ssn, string firstName, string lastName, int id) 
			: this(ssn, firstName, lastName) {
			Id = id;
		}
		public override string ToString() {
			return $"{SSN} {FirstName} {LastName}";
		}
	}
}