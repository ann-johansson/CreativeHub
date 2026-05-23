using System;
using System.Collections.Generic;
using System.Text;

namespace CreativeHub.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;

        public ICollection<Work> Works { get; set; } = new List<Work>();
    }
}
