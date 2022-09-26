using System.ComponentModel.DataAnnotations;

namespace K220_Abstrak.Models.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
