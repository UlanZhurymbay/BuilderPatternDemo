using BuilderPatternDemo.Interfaces;
using BuilderPatternDemo.Model;

namespace BuilderPatternDemo.Builders;

public class DirectorOrderBuilder
{
    private readonly IOrderBuilder _builder;

    public DirectorOrderBuilder(IOrderBuilder builder)
    {
        _builder = builder;
    }


    public IQueryable<Order> IncludeRouteBuilder() =>
        _builder.IncludeRoute()
            .Build();  
    
    public IQueryable<Order> IncludeOrdersInfoBuilder() =>
        _builder.IncludeRoute()
            .IncludeOrdersInfo()
            .Build();  
    
    public IQueryable<Order> IncludeRouteTripBuilder() =>
        _builder.IncludeRoute()
            .IncludeOrdersInfo()
            .IncludeRouteTrip()
            .Build();  
    
    public IQueryable<Order> IncludeDeliveriesInfoBuilder() =>
        _builder.IncludeRoute()
            .IncludeOrdersInfo()
            .IncludeRouteTrip()
            .IncludeDeliveriesInfo()
            .Build();

}