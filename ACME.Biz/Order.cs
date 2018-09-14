using System;
using ACME.Common;

namespace ACME.Biz
{
    public class Order : ILoggable
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset OrderDate { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public string Log()
        {
            var logString = this.OrderId + ": " +
                            "Date: " + this.OrderDate.Date;
            return logString;
        }
    }
}
