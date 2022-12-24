namespace BuilderPatternDemo.Model;

public class Order
{
    public CarType CarType { get;  set;}
    public Client Client { get;  set;}
    public Package Package { get;  set;}
    public bool IsSingle { get; private set;}
    public DateTime CreatedAt { get; private set; }
    public DateTime DeliveryDate { get; private set; }
    public State State { get; set; }
    public decimal Price { get; private set;}
    public Location Location { get;  set;}
    public Route Route { get; set;}
    public Delivery Delivery { get;  set;}
}

public class Package
{
}

public class State
{
}

public class Location
{
}

public class Driver
{
}

public class Route
{
    public City StartCity { get; set; }
    public City FinishCity { get; set; }
}

public class Delivery
{
    public RouteTrip RouteTrip { get; set; }
}

public class CarType
{
}

public class RouteTrip
{
    public Driver Driver { get; set; }

}

public class Client
{
}
public class City
{
}