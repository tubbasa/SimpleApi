using System;

namespace Simple_API.Domain.SimpleAPIAggregate
{
    public interface IDevice
    {
        public Guid Id { get;}
        public string DeviceName { get; set; }
    }
}