using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework1.Models {
    internal sealed class Configuration : DbMigrationsConfiguration<BooksDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = " SampleEntityFramework1.Models.BookDbContext";
        }
    }
}
