#nullable disable
namespace ThanksCardAPI.Models
{
    public class ThanksCard
    {
        public long ThanksCardid { get; set; }
        public string ThanksCardtitle { get; set; }
        public string Body { get; set; }
        public long FromId { get; set; }
        public virtual User From { get; set; }
        public long ToId { get; set; }
        public virtual User To { get; set; }
        public long TitleiD { get; set; }
        public virtual Template Templateame { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int Countiine { get; set; }
        public int Countkaizen { get; set; }

        public virtual ICollection<ThanksCardTag> ThanksCardTags { get; set; }
    }
}
