using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SkeletonTests
{
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            const int initialHealth = 10;
            const int attackToTake = 5;
            const int expectedHealth = 5;

            Dummy dummy = new Dummy(initialHealth, 20);

            dummy.TakeAttack(attackToTake);

            Assert.That(dummy.Health, Is.EqualTo(expectedHealth));
            //Assert.AreEqual(expectedHealth, dummy.Health); THIS GIVES THE SAME RESULTS AS THE LINE ABOVE
        }

        [Test]
        public void AttackDeadDummyShouldThrow()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.That(() => dummy.TakeAttack(5),
                Throws.InvalidOperationException
                .With.Message.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            Hero hero = new Hero("Zhuan");
            Dummy dummy = new Dummy(10, 50);

            hero.Attack(dummy);

            Assert.That(hero.Experience, Is.EqualTo(50));
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            Hero hero = new Hero("Zhuan");
            Dummy dummy = new Dummy(20, 50);

            hero.Attack(dummy);

            Assert.That(hero.Experience, Is.EqualTo(0));
        }
    }
}