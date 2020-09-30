using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectP.Core.DTO
{
    public class Property
    {
        public Guid Id { get; set; }
        public PropertyType Type { get; set; }
        public PropertyDataType DataType { get; set; }
        public string Value { get; set; }
    }
}