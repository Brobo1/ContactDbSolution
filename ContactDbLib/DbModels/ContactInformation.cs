namespace ContactDbLib.DbModels;

public class ContactInformation {
	public int    Id              { get; set; }
	public string Info            { get; set; }
	public string AddsReservation { get; set; }
	public int?   ContactFk       { get; set; }

	public ContactInformation(string info, string addsReservation, int? contactFk = null) {
		Info            = info;
		AddsReservation = addsReservation;
		ContactFk       = contactFk;
	}

	public ContactInformation(int id, string info, string addsReservation, int contactFk)
		: this(info, addsReservation, contactFk) {
		Id = id;
	}

	public override string ToString() {
		return $"{Info} {AddsReservation}";
	}
}