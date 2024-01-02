using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Domain.Common
{
    /// <summary>
    /// Base class for all entities database
    /// </summary>
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            IsDeleted = "0";
        }

        public Guid Id { get; set; }

        [Required]
        [Column("createdby", TypeName = "varchar(100)")]
        public string? CreatedBy { get; set; }

        [Required]
        [Column("createddate")]
        public DateTime? CreatedDate { get; set; }

        [Required]
        [Column("updatedby", TypeName = "varchar(100)")]
        public string? UpdatedBy { get; set; }

        [Required]
        [Column("updateddate")]
        public DateTime? UpdatedDate { get; set; }

        [Required]
        [Column("isdeleted", TypeName = "varchar(1)")]
        public string? IsDeleted { get; set; }
    }
}
