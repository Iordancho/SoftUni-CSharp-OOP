using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        private int attackPoints;
        private int durabilityPoints;
        private int health;
        private int experience;

        [SetUp]
        public void Setup()
        {
            attackPoints = 10;
            durabilityPoints = 15;
            axe = new Axe(attackPoints, durabilityPoints);
            health = 100;
            experience = 50;
            dummy = new Dummy(health, experience);
        }

        [Test]
        public void Test_AxeConstructorShoudSetDataProperly()
        {
            Assert.AreEqual(10, axe.AttackPoints);
            Assert.AreEqual(15, axe.DurabilityPoints);
        }

        [Test]
        public void Test_AxeShoudLoseDurabilityPointsAfterEachAttack()
        {
            axe.Attack(dummy);
            Assert.AreEqual(durabilityPoints - 1, axe.DurabilityPoints);
        }

        [Test]
        public void Test_AxeShoudThrowException_WhenDurabiltyIs0()
        {
            axe = new Axe(10, 0);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }

        [Test]
        public void Test_AxeShoudThrowException_WhenDurabiltyIsNegative()
        {
            axe = new Axe(10, -5);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }

    }
}