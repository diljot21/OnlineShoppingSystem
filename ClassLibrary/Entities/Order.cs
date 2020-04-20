using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Order
    {
        private int _orderId;
        private int _customerId;
        private DateTime _orderDate;
        private int _orderTotal;
        private List<OrderProduct> _orderProducts;

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        public int OrderTotal
        {
            get { return _orderTotal; }
            set { _orderTotal = value; }
        }

        public List<OrderProduct> OrderProducts
        {
            get { return _orderProducts; }
        }

        public Order(int customerId, DateTime orderDate, int orderTotal, int orderId = 0)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OrderDate = orderDate;
            OrderTotal = orderTotal;
            _orderProducts = new List<OrderProduct>();
        }
    }
}
