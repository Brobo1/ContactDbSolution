namespace ContactDbLib.DbModels;

public class ContactInformation {
	public int    Id              { get; set; }
	public string Info            { get; set; }
	public string AddsReservation { get; set; }
	public int    ContactFk       { get; set; }

	public ContactInformation(string info, string addsReservation) {
		Info            = info;
		AddsReservation = addsReservation;
	}

	public override string ToString() {
		return $"{Info} {AddsReservation}";
	}
}