using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_3_Assignment;

internal class DeliveryCenter
{
    public string CenterName { get; set; }
    private Shipment[] shipments = new Shipment[20];
    public Shipment this[int index]
    {
        get
        {
            if (index < 0 || index >= shipments.Length)
            {
                return default;
            }
            return shipments[index];
        }
        set
        {
            if (index < 0 || index >= shipments.Length)
            {
                return;
            }
            shipments[index] = value;
        }
    }

    public Shipment this[string code]
    {
        get
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return default;
            }
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == code)
                {
                    return shipments[i];
                }
            }
            return default;
        }

    }

    public bool AddShipment(Shipment shp)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] is null)
            {
                shipments[i] = shp;
                Console.WriteLine("Shipment added successfully");
                return true;
            }
        }
        return false;
    }
    public bool RemoveShipment(string code)
    {
        int indexToRemove = -1;
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i].TrackingCode == code)
            {
                indexToRemove = i;
                break;
            }
        }
        if (indexToRemove == -1)
        {
            Console.WriteLine("not found");
            return false;
        }

        Shipment[] newShipments = new Shipment[shipments.Length - 1];
        for (int i = 0, j = 0; i < shipments.Length; i++)
        {
            if (i == indexToRemove)
            {
                continue;                
            }
            newShipments[j] = shipments[i];
            j++;
        }
        shipments = newShipments;
        return true;
    }
    public void PrintAllShipments()
    {
        Console.WriteLine("=========================");
        Console.WriteLine($"Delivery Center : {this.CenterName}");
        Console.WriteLine("=========================");
        int i = 1;
        foreach(Shipment shp in shipments)
        {
            if (shp is null)
                continue;
            Console.WriteLine($"Shipment {i}");
            shp.PrintShipment();
            Console.WriteLine("=========================");
            i++;
        }
    }
}
