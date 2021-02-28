using BeautyStore.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore.BeautyStoreModels
{
    /// <summary>
    /// This data structure models a product and its quantity. The quantity was separated from the product as it could vary from orders and location.
    /// </summary>
    class Item
    {
        public BeautyProducts BeautyProducts { get; set; }
        public int Quantity { get; set; }
    }
}
