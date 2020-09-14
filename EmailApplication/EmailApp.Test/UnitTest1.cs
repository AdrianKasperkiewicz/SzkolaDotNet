using System;
using Xunit;

namespace EmailApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //Attange-przygotowujemy nasze dane, które bêdziemy testowaæ
            int a = 5;
            int b = 10;
            //Act-wykonaj dzia³anie logiczne, które ma zostaæ przetestowane w tym teœcie jednostkowym
            int result = a + b;
            //Assert-dowód na to, ¿e mój kod dzia³a w sposób prawid³owy 
            Assert.Equal(15, result);
        }
    }
}
