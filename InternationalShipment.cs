namespace OOP_session_3_Assignment;

internal class InternationalShipment : Shipment
{
    private decimal customsFee;
    private string destinationCountry;
    public string DestinationCountry
    {
        get => destinationCountry;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("invalid country name");
                return;
            }
            destinationCountry = value;
        }
    }
    public decimal CustomsFee
    {
        get => customsFee;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Customs Fee cannot be negative");
                return;
            }
            customsFee = value;
        }
    }
    public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;

    public InternationalShipment(string trackingCode, string description, double weight,
                            decimal deliveryFee,decimal customsFee, string destinationCountry, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        CustomsFee = customsFee;
        DestinationCountry = destinationCountry;
    }
}
