using BuilderPatternDemo.Model;

namespace BuilderPatternDemo.Interfaces;

public interface IOrderBuilder
{
    public IOrderBuilder IncludeRoute();
    public IOrderBuilder IncludeOrdersInfo();
    public IOrderBuilder IncludeRouteTrip();
    public IOrderBuilder IncludeDeliveriesInfo();
    public IQueryable<Order> Build();
}

