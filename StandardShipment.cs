using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_3_Assignment;

internal class StandardShipment : Shipment
{
    public StandardShipment(string trackingCode): base(trackingCode)
    {
    }
    public StandardShipment(string trackingCode, string description, double weight,
                            decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description,weight,deliveryFee,destination)
    {
        
    }
}
