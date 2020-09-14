using System;
using System.Reflection.Metadata;
using Email.App.Managers;
using EmailApplication.Domain.Entity;
using Xunit;

namespace EmailApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange - przygotowujemy nasze dane, które bêdziemy testowaæ
            AdminManager manager = new AdminManager();
            //Act - wykonaj dzia³anie logiczne, które ma zostaæ przetestowane
            //Assert - dowód na to, ¿e kod dzia³a prawid³owo
        }
    }
}
