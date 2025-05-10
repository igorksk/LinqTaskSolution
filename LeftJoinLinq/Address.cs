using System.Collections.Generic;

namespace LeftJoinLinq
{
    public class Address
    {
        public int ID { get; set; }
        public string? AddressLine { get; set; }
        public static List<Address> GetAddress()
        {
            return
            [
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 6, AddressLine = "AddressLine6"},
            ];
        }
    }
}
