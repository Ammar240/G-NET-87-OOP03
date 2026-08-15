namespace OOP_session_3_Assignment;

internal class Program
{
    static void Main(string[] args)
    {
        DeliveryCenter center = new DeliveryCenter();
        Console.Write("Enter center name: ");
        center.CenterName = Console.ReadLine();

        //StandardShipment stShipment = CreateStandardShipment();
        //ExpressShipment exShipment = CreateExpressShipment();
        //InternationalShipment inShipment = CreateInternationalShipment();

        

        StandardShipment stShipment = new StandardShipment("SH001", "Laptop", 3, 80m, new DeliveryAddress("Cairo", "Abbas", 25));
        ExpressShipment exShipment = new ExpressShipment("SH002", "Phone", 2, 60m, 30m, new DeliveryAddress("Giza", "Haram st", 44));
        InternationalShipment inShipment = new InternationalShipment("SH003", "Television", 8, 120, 100, "Espain", new DeliveryAddress("Madrid", "rm", 122));

        center.AddShipment(stShipment);
        center.AddShipment(exShipment);
        center.AddShipment(inShipment);

        center.PrintAllShipments();

        Console.WriteLine("================================");
        Console.WriteLine("Sesrch shipment of cod : SH001");
        center["SH001"].PrintShipment();

        Console.WriteLine("================================");
        Console.Write("Enter shipment code to remove: ");
        string code = Console.ReadLine();
        center.RemoveShipment(code);

        Console.WriteLine("================================");
        Console.WriteLine("Print after remove");
        center.PrintAllShipments();
    }

    static StandardShipment CreateStandardShipment()
    {
        Console.WriteLine("Enter Standard Shipment Data");

        Console.Write("Tracking code: ");
        string code = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Delvivery Fee: ");
        decimal fee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("Building Number: ");
        int buildingNum = Convert.ToInt32(Console.ReadLine());
        DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
        StandardShipment stShipment = new StandardShipment(code, description, weight, fee, address);
        return stShipment;
    }

    static ExpressShipment CreateExpressShipment()
    {
        Console.WriteLine("Enter Express Shipment Data");
        Console.Write("Tracking code: ");
        string code = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Delvivery Fee: ");
        decimal fee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Delvivery Extra Fee: ");
        decimal extrafee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("Building Number: ");
        int buildingNum = Convert.ToInt32(Console.ReadLine());
        DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
        ExpressShipment exShipment = new ExpressShipment(code, description, weight, fee,extrafee, address);
        return exShipment;
    }
    static InternationalShipment CreateInternationalShipment()
    {
        Console.WriteLine("Enter International Shipment Data");

        Console.Write("Tracking code: ");
        string code = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Delvivery Fee: ");
        decimal fee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Delvivery Custom Fee: ");
        decimal customsfee = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Country: ");
        string country = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("Building Number: ");
        int buildingNum = Convert.ToInt32(Console.ReadLine());
        DeliveryAddress address = new DeliveryAddress(city, street, buildingNum);
        InternationalShipment inShipment = new InternationalShipment(code, description, weight, fee, customsfee,country,address);
        return inShipment;
    }
}
