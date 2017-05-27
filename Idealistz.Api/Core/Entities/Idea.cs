using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idealistz.Api.Core.Entities
{
	public class Idea
	{
        [Key]
		public int Id { get; set; }

		public Guid GlobalId { get; set; }

        [ForeignKey("IdeaListId")]
		public int IdeaListId { get; set; }

        [Required]
        [MaxLength(200)]
		public string Title { get; set; }

        [MaxLength(50000)]
		public string Description { get; set; }

		public string User { get; set; }
		public int Status { get; set; }
		public int AccessLevel { get; set; }
		public DateTimeOffset CreateTime { get; set; }
		public DateTimeOffset EditTime { get; set; }

		public Idea() { }
	}
}