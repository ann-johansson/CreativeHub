using CreativeHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace CreativeHub.Domain.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public WorkType Type { get; set; }
        public string Description {  get; set; } = string.Empty;
        public string? MediaUrl { get; set; }
        public string? ExternalLink { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int? CharacterId { get; set; }
        public Character? Character { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
