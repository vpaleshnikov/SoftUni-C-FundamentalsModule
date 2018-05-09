namespace Skeleton.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 1;
        private const int AxeDurability = 1;
        private const int DummyHealth = 20;
        private const int DummyXp = 1;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXp);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            this.axe.Attack(dummy);

            Assert.AreEqual(0, this.axe.DurabilityPoints);
        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            this.axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => this.axe.Attack(dummy));
        }
    }
}
