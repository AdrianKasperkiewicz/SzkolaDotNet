using System;
using System.Reflection.Metadata;
using Email.App.Abstract;
using Email.App.Concrete;
using Email.App.Managers;
using EmailApplication.Domain.Entity;
using FluentAssertions;
using Moq;
using Xunit;

namespace EmailApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange - przygotowujemy nasze dane, kt�re b�dziemy testowa�
            User user=new User("Adrian", "Kasper","adrian@wp.pl",2);
            var mock=new Mock<IService<User>>();
            mock.Setup(a => a.GetUserById(2)).Returns(user);

            var manager = new AdminManager(new MenuActionService(), mock.Object);
            //Act - wykonaj dzia�anie logiczne, kt�re ma zosta� przetestowane

            var returnedUser=manager.GetItemById(user.Id);

            //Assert - dow�d na to, �e kod dzia�a prawid�owo
            //Assert.Equal(user, returnedUser);
            returnedUser.Should().BeOfType(typeof(User));
            returnedUser.Should().NotBeNull();
            returnedUser.Should().BeSameAs(user);
        }
        
    }
}
