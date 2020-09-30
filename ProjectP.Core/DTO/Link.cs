using System;

namespace ProjectP.Core.DTO
{
    public class Link : Base
    {
        public Guid LinkedItemId { get; set; }
        public LinkType Type { get; set; }
        public string Description { get; set; }
    }
}