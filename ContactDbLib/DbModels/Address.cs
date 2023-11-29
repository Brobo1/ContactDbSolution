namespace ContactDbLib.DbModels;

public class Address {
	public int    Id     { get; set; }
	public string Street { get; set; }
	public string City   { get; set; }
	public string Zip    { get; set; }

	public Address(string street, string city, string zip) {
		Street = street;
		City   = city;
		Zip    = zip;
	}
	public Address(string street, string city, string zip, int id)
	: this(street, city, zip) {
		Id = id;
	}
	public override string ToString() {
		return $"{City} {Zip} {Street}";
	}
}