using System;
using Xunit;
using HerosLib;

namespace HerosTest
{
    public class HerosTest
    {
        Hero testHero = new Hero();
        [Theory]
        [InlineData("Unit testing god")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowerShouldAddSuperPower(string superPower)
        {
            
            //Act (Do the things you wanna test)
            testHero.AddSuperPower(superPower);

            //Assert
            Assert.Equal(superPower, Hero.superPowers.Peek());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArgumentException(string superPower)
        {
            //Catching exceptions in unit tests, act and assert are the same
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
