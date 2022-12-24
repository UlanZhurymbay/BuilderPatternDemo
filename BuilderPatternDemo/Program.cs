// See https://aka.ms/new-console-template for more information

using BuilderPatternDemo.Builders;
using BuilderPatternDemo.DataContext;
using BuilderPatternDemo.Model;
using Microsoft.EntityFrameworkCore;

var di = new DirectorOrderBuilder(new OrderBuilder(new OrderContext()));


OrderService orderService = new OrderService(di);
var ordersInfo = await orderService.GetAllOrderForOrderInfo();                //OrderInfoList
var orders = await orderService.GetAllOrders();                        //Orders

DeliveryService deliveryService = new DeliveryService(di);
var ordersInfo2 = await deliveryService.GetAllOrderWithRouteTrip();           //OrderInfoList2
var deliveriesInfo = await deliveryService.GetAllOrdersForDeliveryInfo();      //DeliveryInfo


public class OrderService
{
    private readonly DirectorOrderBuilder _orderBuilder;

    public OrderService(DirectorOrderBuilder orderBuilder)
    {
        _orderBuilder = orderBuilder;
    }

    public async Task<List<Order>> GetAllOrderForOrderInfo()
    {
        var orders = await _orderBuilder.IncludeOrdersInfoBuilder().ToListAsync();
        return orders;
    }
    public async Task<List<Order>> GetAllOrders()
    {
        var orders = await _orderBuilder.IncludeRouteBuilder().ToListAsync();
        return orders;
    }
}
public class DeliveryService
{
    private readonly DirectorOrderBuilder _orderBuilder;

    public DeliveryService(DirectorOrderBuilder orderBuilder)
    {
        _orderBuilder = orderBuilder;
    }

    public async Task<List<Order>> GetAllOrderWithRouteTrip()
    {
        var orders = await _orderBuilder.IncludeRouteTripBuilder().ToListAsync();
        return orders;
    }
    public async Task<List<Order>> GetAllOrdersForDeliveryInfo()
    {
        var orders = await _orderBuilder.IncludeDeliveriesInfoBuilder().ToListAsync();
        return orders;
    }
}
