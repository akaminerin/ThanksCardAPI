#nullable disable
namespace ThanksCardAPI.Models
{
    //Thankscardテーブル
    public class ThanksCard
    {
        public long Id { get; set; }//ThankscardID

        public long FromId { get; set; }//FROM社員ID
        public virtual User From { get; set; }

        public long ToId { get; set; }//TO社員ID
        public virtual User To { get; set; }

        public long TemplateId { get; set; }//テンプレートID
        public virtual Template Templatename { get; set; }

        public string Body { get; set; }//コメント

        public int Countiine { get; set; }//いいねcount

        public int Countkaizen { get; set; }//改善count

        public DateTime CreatedDateTime { get; set; }//日付

        public bool kidoku { get; set; } //既読

        public virtual ICollection<ThanksCardTag> ThanksCardTags { get; set; }
    }
}
