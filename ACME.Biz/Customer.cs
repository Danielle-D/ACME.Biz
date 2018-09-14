using ACME.Common;

namespace ACME.Biz
{
    public class Customer : ILoggable
    {
        public Customer()
        {
                
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }
      
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }

            set { _firstName = value; }
        }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string WorkAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fulllName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fulllName))
                    {
                        fulllName += ", ";
                    }
                    fulllName += LastName;
                }
                return fulllName;
            }
        }

        //public Customer Retrieve(int customerId)
        //{
        //    return new Customer();
        //}

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress;
            return logString;
        }

    }
}