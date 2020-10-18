using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Email.App.Abstract;
using Email.App.Concrete;
using Email.App.Managers;
using EmailApplication.Domain.Entity;
using EmailApplication.Services.Concrete;
using FluentAssertions;
using Moq;
using Xunit;

namespace EmailApp.Tests
{
    public class AdminManagerTest
    {
        [Fact]
        public AdminServices AddUserTest()
        {
            User user = new User("Adrian", "Kasper", "adrian@gmail.com", 1);
            User user2 = new User("Bożydar", "Nowak", "nowak@gmail.com", 2);
            User user3 = new User("Wojciech", "Kowalski", "kowalski@gmail.com", 3);
            User user4 = new User("Marian", "Książkiewicz", "książka@gmail.com", 4);
            User user5 = new User("Grzegorz", "Słomka", "slomka@gmail.com", 5);
            User user6 = new User("Dorota", "Jankowska", "jankowska@gmail.com", 6);

            AdminServices adminServices = new AdminServices();
            //adminServices.AddUser(user);
            //adminServices.AddUser(user);        //Add users 
            //adminServices.AddUser(user2);
            //adminServices.AddUser(user3);
            //adminServices.AddUser(user4);
            //adminServices.AddUser(user5);
            //adminServices.AddUser(user6);


            var mock = new Mock<IService<User>>();
            mock.Setup(a => a.GetUserById(2)).Returns(user);
            var manager = new AdminManager(new MenuActionService(), mock.Object);
            var returnedUser = adminServices.GetUserById(user.Id);

            returnedUser.Should().NotBeNull();
            returnedUser.Should().Be(typeof(User));
            returnedUser.Should().BeSameAs(user);
            return adminServices;

            //adminServices.Users.FirstOrDefault(x => x.Id == user.Id);   //check user exist
        }


    }
}
