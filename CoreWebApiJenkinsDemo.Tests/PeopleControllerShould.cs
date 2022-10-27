using CoreWebApiJenkinsDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CoreWebApiJenkinsDemo.Tests
{
    public class PeopleControllerShould
    {
        private readonly PeopleController _peopleController;
        public PeopleControllerShould()
        {
            _peopleController = new PeopleController();
        }
        [Fact]
        public void People_InputIsString_ReturnTrue()
        {
            var stringResult = _peopleController.GetName();

            Assert.IsType<string>(stringResult);
        }
    }
}
