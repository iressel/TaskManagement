using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Infrastructure.Context.Entities
{
    /// <summary>
    /// Base class for all entities in the database
    /// </summary>
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        [Column("createdby", TypeName = "varchar(100)")]
        public string? CreatedBy { get; set; }

        [Required]
        [Column("creationdate")]
        public DateTime? CreationDate { get; set; }

        [Required]
        [Column("updatedby", TypeName = "varchar(100)")]
        public string? UpdatedBy { get; set; }

        [Required]
        [Column("updatedate")]
        public DateTime? UpdateDate { get; set; }

        [Required]
        [Column("flgdeleted", TypeName = "varchar(1)")]
        public string? FlgDeleted { get; set; }
    }
}
