using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Test
{
    
    public class UnitTest1
    {
        ValuesController contr= new ValuesController();         
        [Fact]
        public void GetReturnByName()
        {
            //var returnvalue="viru";//contr.Get(1);
             //Assert.Equal("viru",returnvalue);
            var returnval=contr.Get(1);
            Assert.Equal("viru",returnval.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
