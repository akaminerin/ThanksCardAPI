#nullable disable
namespace ThanksCardAPI.Models
{
    //制限テーブル
    public class Security
    {
        public long id { get; set; }
        public bool IsAdmin { get; set; }
        public string SecurityName { get; set; }
    }
}
