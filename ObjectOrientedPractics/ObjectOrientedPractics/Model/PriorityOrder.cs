using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private int _id;
        private string _createData;
        private OrderStatus _status;
        private Address _address;
        private List<Item> _items;

        //желаемая дата
        public DateTime DataTime { get; set; }
        //желаемое время 
        public TimeRange TimeRange { get; set; }

        public PriorityOrder() { }

        public PriorityOrder(int id, string createData, OrderStatus status,
                             Address address, List<Item> items, DateTime dataTime, TimeRange timeRange)
            :base(status, createData, items, address)
        {
            DataTime = dataTime;
            TimeRange= timeRange;
        }

    }
}
