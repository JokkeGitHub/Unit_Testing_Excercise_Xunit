using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnit_Calculator;

namespace Calculator.Test2
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_Fact_ShouldWork()
        {
            XUnit_Calculator.DataAccessExample dataAccessExample = new XUnit_Calculator.DataAccessExample();
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();

            dataAccessExample.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_Theory_ShouldFail(string firstName, string lastName, string parameter)
        {
            XUnit_Calculator.DataAccessExample dataAccessExample = new XUnit_Calculator.DataAccessExample();
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(parameter, () => dataAccessExample.AddPersonToPeopleList(people, newPerson));
        }
    }
}
