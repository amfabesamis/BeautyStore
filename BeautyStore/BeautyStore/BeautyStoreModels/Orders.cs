using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore.BeautyStoreModels
{
    /// <summary>
    /// This class contains all the fileds and properties that define a customer order.
    /// </summary>
    class Orders
    {
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public double Total { get; set; }

        //TODO: add a property for the order items
    }
}
