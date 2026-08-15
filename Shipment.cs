using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_3_Assignment;

internal class Shipment
{
    private string trackingCode;
    private string description;
    private double weight;
    private decimal deliveryFee;

    public DeliveryAddress Destination { get; set; }

    public string TrackingCode
    {
        get => trackingCode;
        private set
        {
            if (value.Equals("") || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tracking code cannot be null or empty.");
            }
            trackingCode = value;
        }
    }

    public string Description
    {
        get => description;

        set
        {
            if (value.Equals("") || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Description cannot be null");
            }
            description = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if(value < 0)
            {
                return;
            }
            weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get => deliveryFee;
        private set
        {
            if (value < 0)
            {
                return;
            }
            deliveryFee = value;
        }
    }
    
    public virtual decimal EstimatedCost
    {
        get => DeliveryFee + ((decimal)Weight * 5);
    }

    public Shipment(string trackingCode)
    {
        TrackingCode = trackingCode;
        Description = "Unkown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress();
    }
    public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        Destination = destination;
    }

    public void UpdateDeliveryFee(decimal deliveryFee)
    {
        this.DeliveryFee = deliveryFee;
    }
    
    public void PrintShipment()
    {
        
        Console.WriteLine($"""
            {"Tracking Code",-20} | {TrackingCode}
            {"Description",-20} | {Description}
            {"Weight",-20} | {Weight} KG
            {"DeliveryFee",-20} | {DeliveryFee}$
            {"Estimated Cost",-20} | {EstimatedCost}$
            """);
        Console.Write($"{"Destination",-20} | ");
        Destination.GetFullAddress();
    }
}
