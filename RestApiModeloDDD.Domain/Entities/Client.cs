using System;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Client : Base
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
