using FormulaApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaApp.UnitTests.Fixtures
{
    public class FansFixtures
    {
        public static List<Fan> GetFans() => new()
        {
            new Fan
            {
                Id = 1,
                Name = "Test",
                Email = "Test@gmail.com",
            },
            new Fan
            {
                Id = 2,
                Name = "Donald",
                Email = "donald@gmail.com",
            }
        };
    }
}
