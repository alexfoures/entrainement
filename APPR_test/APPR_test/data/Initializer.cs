using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using APPR_test.models;

namespace APPR_test.data
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var students = new List<Class>
            {
                new Class{FirstMidName="Foures",LastName="Alexandre",EnrollmentDate=DateTime.Parse("2021-08-01")},
                new Class{FirstMidName="Maitre",LastName="Yoda",EnrollmentDate=DateTime.Parse("2022-12-01")},
                new Class{FirstMidName="Booba",LastName="Kaaris",EnrollmentDate=DateTime.Parse("2020-12-12")}
            };
            context.SaveChanges();
        }
    }
}
