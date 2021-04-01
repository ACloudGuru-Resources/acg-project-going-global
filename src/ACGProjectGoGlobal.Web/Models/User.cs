using System;

namespace ACGProjectGoGlobal.Web.Models
{
    public class User
    {
        public Guid id { get; }

        public string Name { get; set; }

        public string Profession { get; set; }

        public decimal Budget { get; set; }

        public int ContractID { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string ImagePath { get; set; }

        public User()
        {
            id = Guid.NewGuid();
        }
    }
}
