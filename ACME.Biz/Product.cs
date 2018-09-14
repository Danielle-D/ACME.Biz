using System;
using ACME.Common;

namespace ACME.Biz
{
    public class Product : ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
        /// <summary>
        /// Saves the current Product.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                                 this.ProductName + ": " +
                                 "Detail: " + this.ProductDescription;
            return logString;
        }

    }
}