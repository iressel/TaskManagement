using System.ComponentModel.DataAnnotations.Schema;
using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Aggregates.PersonAggregate
{
    /// <summary>
    /// Base class for all entities that represent a Person in database
    /// </summary>
    public class Person : BaseEntity
    {
        public Person()
        {
            Addresses = new List<Address>();
        }

        [Column(TypeName = "varchar(150)")]
        public string? Name { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string? Surname { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Legajo { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? DocumentNumber { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? CuitCuil { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? NationalityId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? CellPhone { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Email { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        #region Inverse Navigation Properties

        public virtual ICollection<Address> Addresses { get; set; }

        #endregion
    }
}
