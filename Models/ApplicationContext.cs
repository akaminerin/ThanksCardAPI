#nullable disable
using Microsoft.EntityFrameworkCore;

namespace ThanksCardAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        //社員テーブル
        public DbSet<User> Users { get; set; }
        //所属テーブル
        public DbSet<Department> Departments { get; set; }
        //Thankscardテーブル
        public DbSet<ThanksCard> ThanksCards { get; set; }
        //ThankscardテーブルID？TAG？
        public DbSet<Tag> Tag { get; set; }
        //テンプレートテーブル
        public DbSet<Template> Template { get; set; }
        //制限テーブル
        public DbSet<Security> Security { get; set; }


    }
}
