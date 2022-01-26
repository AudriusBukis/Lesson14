using Lesson14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson14.UnitTests
{
    public class DeluxBurgerTest
    {
        [Fact]
        public void Test_Or_Function_ItemizeHamburger_Gives_Corect_Answer()
        {
            DeluxeBurger db = new DeluxeBurger();
            db.AddHamburgerAddition1("Tomato", 0.27);
            

            Assert.Equal(19.1, db.ItemizeHamburger());
        }
    }
}
