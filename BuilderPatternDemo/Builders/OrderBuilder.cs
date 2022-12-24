using BuilderPatternDemo.DataContext;
using BuilderPatternDemo.Interfaces;
using BuilderPatternDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace BuilderPatternDemo.Builders;

public class OrderBuilder : IOrderBuilder
{
    private IQueryable<Order> _orders;
    private readonly OrderContext _orderContext;

    public OrderBuilder(OrderContext orderContext)
    {
        _orderContext = orderContext;
        _orders = orderContext.Orders;
    }


    public IOrderBuilder IncludeRoute()
    {
        _orders.Include(o => o.Route.StartCity)
            .Include(o => o.Route.FinishCity);
        return this;
    }

    public IOrderBuilder IncludeOrdersInfo()
    {
        _orders.Include(o => o.State)
            .Include(o => o.Package)
            .Include(o => o.CarType)
            .Include(o => o.Location)
            .Include(o => o.Client);
        return this;
    }

    public IOrderBuilder IncludeRouteTrip()
    {
        _orders.Include(o => o.Delivery.RouteTrip);
        return this;
    }

    public IOrderBuilder IncludeDeliveriesInfo()
    {
        _orders.Include(o => o.Delivery)
            .Include(o => o.Delivery.RouteTrip.Driver);
        return this;
    }

    public IQueryable<Order> Build()
    {
        var orders = _orders;
        _orders = _orderContext.Orders;
        return orders;
    }
}