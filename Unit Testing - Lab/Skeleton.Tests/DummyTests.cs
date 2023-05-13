using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy dummy;
        private Dummy deadDummy;
        private int health;
        private int experience;

        [SetUp]
        public void Setup()
        {
            health = 100;
            experience = 50;
            dummy = new Dummy(health, experience);
            deadDummy = new Dummy(-10, experience);
        }

        [Test]
        public void Test_DummyConstructorShoudSetDataProperly()
        {
            Assert.AreEqual(100, dummy.Health);
        }

        [Test]
        public void Test_DummyLoosesHealthWhenAttacked()
        {
            dummy.TakeAttack(50);
            Assert.AreEqual(health - 50, dummy.Health);
        }

        [Test]
        public void Test_DummyShoudThrowException_WhenHealthIs0()
        {
            dummy.TakeAttack(health);
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(1);
            });
        }

        [Test]
        public void Test_DummyShoudThrowException_WhenHealthIsNegative()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                deadDummy.TakeAttack(1);
            });
        }

        [Test]
        public void Test_DummyShoudGiveExperienceWhenDead()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
            
        }
    }
}