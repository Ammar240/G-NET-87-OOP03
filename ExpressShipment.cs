using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_3_Assignment;

internal class ExpressShipment : Shipment
{
    private decimal extraFee;
    public decimal ExtraFee
    {
        get => extraFee;

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Extra Fee Cannot be negative");
                return;
            }
            extraFee = value;
        }
    }
    public override decimal EstimatedCost => base.EstimatedCost + ExtraFee;
    public ExpressShipment(string trackingCode, string description, double weight,
                            decimal deliveryFee, decimal extraFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }


}
