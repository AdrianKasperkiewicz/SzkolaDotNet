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
            //Arrange - przygotowujemy nasze dane, kt�re b�dziemy testowa�
            AdminManager manager = new AdminManager();
            //Act - wykonaj dzia�anie logiczne, kt�re ma zosta� przetestowane
            //Assert - dow�d na to, �e kod dzia�a prawid�owo
        }
    }
}
