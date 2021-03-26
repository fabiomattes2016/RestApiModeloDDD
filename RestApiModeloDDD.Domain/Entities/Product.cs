using System;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAvailable { get; set; }
    }
}
