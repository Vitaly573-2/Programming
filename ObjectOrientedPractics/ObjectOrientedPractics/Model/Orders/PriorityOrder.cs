using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        private int _id;
        private string _createData;
        private OrderStatus _status;
        private Address _address;
        private List<Item> _items;  

        public int ID { get{ return _id; } }

        public string CreateData {  get{ return _createData; } }
        //желаемая дата
        public DateTime DataTime { get; set; }
        //желаемое время, перечисление 
        public DeliveryTime DeliveryTime { get; set; }

        public PriorityOrder() { }

        public PriorityOrder(string createData, OrderStatus status,
                             Address address, List<Item> items, double discountAmount, DateTime dataTime, DeliveryTime deliveryTime)
            :base(status, createData, items, address, discountAmount)
        {
            _id += 1;
            _createData = createData;
            DataTime = dataTime;
            DeliveryTime= deliveryTime;
        }

    }
}
