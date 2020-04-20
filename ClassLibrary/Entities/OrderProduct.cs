using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class OrderProduct
    {
        private int _orderId;
        private int _productId;
        private int _quantity;

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set {
                if (value > 0) _quantity = value;
                else throw new Exception("Quantity should be greater than 0");
            }
        }

        public OrderProduct(int orderId, int productId, int quantity)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
