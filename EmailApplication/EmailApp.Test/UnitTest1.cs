using System;
using Xunit;

namespace EmailApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            //Attange-przygotowujemy nasze dane, kt�re b�dziemy testowa�
            int a = 5;
            int b = 10;
            //Act-wykonaj dzia�anie logiczne, kt�re ma zosta� przetestowane w tym te�cie jednostkowym
            int result = a + b;
            //Assert-dow�d na to, �e m�j kod dzia�a w spos�b prawid�owy 
            Assert.Equal(15, result);
        }
    }
}
