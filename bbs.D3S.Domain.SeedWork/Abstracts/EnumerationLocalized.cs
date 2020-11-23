using System.ComponentModel.DataAnnotations;

namespace bbs.D3S.Domain.SeedWork
{
    public class EnumerationLocalized
    {
        [Key] public virtual int ID { get; set; }
        public virtual int EnID { get; set; }
        [MaxLength(5)] public virtual string CultureCode { get; set; }
        public virtual string LocalValue { get; set; }
    }
}
