using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_3_Assignment;

internal struct DeliveryAddress
{
    public string Street { get; set; }
    public string City { get; set; }
    public int BuildingNumber { get; set; }
    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        this.City = city;
        this.Street = street;
        this.BuildingNumber = buildingNumber;
    }

    public void GetFullAddress()
    {
        Console.WriteLine($"City: {City}, Street: {Street}, Building Number: {BuildingNumber}");
    }

}
