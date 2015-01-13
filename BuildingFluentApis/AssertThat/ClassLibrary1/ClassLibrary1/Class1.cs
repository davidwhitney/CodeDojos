using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class CheckTests
    {
        [Test]
        public void That_GivenStringThatIsEqual_Works()
        {
            Check.That("hi", IsTotally.EqualTo("hi"));
        }

        [Test]
        public void That_GivenStringThatIsNotEqual_Throws()
        {
            Assert.Throws<Exception>(() => Check.That("hi", IsTotally.EqualTo("hello")));
        }

        [Test]
        public void That_GivenStringThatIsNotEqual_Works()
        {
            Check.That("hi", IsTotally.Not.EqualTo("hello"));
        }
    }

    public static class IsTotally
    {
        private static readonly ComparisonRoot Root;

        static IsTotally()
        {
            Root = new ComparisonRoot();
        }

        public static IPerformAComparison EqualTo(object objB)
        {
            return Root.EqualTo(objB);
        }

        public static ComparisonRoot Not
        {
            get { return new ConditionInverter(); }
        }
    }

    public class ComparisonRoot
    {
        public virtual IPerformAComparison EqualTo(object objB)
        {
            return new CheckEquality(objB);
        }
    }

    public class ConditionInverter : ComparisonRoot
    {
        public override IPerformAComparison EqualTo(object objB)
        {
            return new Invert(base.EqualTo(objB));
        }

        private class Invert : IPerformAComparison
        {
            private readonly IPerformAComparison _regular;

            public Invert(IPerformAComparison regular)
            {
                _regular = regular;
            }

            public bool Execute(object objA)
            {
                return !_regular.Execute(objA);
            }

            public Exception GenerateError(object objA)
            {
                return _regular.GenerateError(objA);
            }
        }
    }


    public static class Check
    {
        public static void That(object objA, IPerformAComparison comparison)
        {
            var success = comparison.Execute(objA);
            if (!success)
            {
                throw comparison.GenerateError(objA);
            }
        }
    }

    public interface IPerformAComparison
    {
        bool Execute(object objA);
        Exception GenerateError(object objA);
    }

    public class CheckEquality : IPerformAComparison
    {
        public object ObjB { get; set; }

        public CheckEquality(object objB)
        {
            ObjB = objB;
        }
        
        public bool Execute(object objA)
        {
            return objA == ObjB;
        }

        public Exception GenerateError(object objA)
        {
            return new Exception("objA doesn't match objB");
        }
    }
}
