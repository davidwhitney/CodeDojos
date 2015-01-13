using System;
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
        public void That_GivenStringThatIsNotNotEqual_Throws()
        {
            Assert.Throws<Exception>(() => Check.That("hi", IsTotally.Not.Not.EqualTo("hello")));
        }

        [Test]
        public void That_GivenStringThatIsNotEqual_Works()
        {
            Check.That("hi", IsTotally.Not.EqualTo("hello"));
        }

        [Test]
        public void That_GivenStringThatIsNotNotEqual_Works()
        {
            Check.That("hi", IsTotally.Not.Not.EqualTo("hi"));
        }
    }

    public static class IsTotally
    {
        private static readonly IAssertionRoot Default = new IsTotallyInstance(ComparisonSettings.Regular);

        public static IPerformAComparison EqualTo(object objB)
        {
            return Default.EqualTo(objB);
        }

        public static IAssertionRoot Not
        {
            get { return new IsTotallyInstance(ComparisonSettings.Negated); }
        }
    }

    public class ComparisonSettings
    {
        public static ComparisonSettings Regular = new ComparisonSettings();
        public static ComparisonSettings Negated = new ComparisonSettings();

        public ComparisonSettings GetOther()
        {
            return this == Regular ? Negated : Regular;
        }
    }

    public class IsTotallyInstance : IAssertionRoot
    {
        private readonly ComparisonSettings _comparisonSettings;

        public IsTotallyInstance(ComparisonSettings comparisonSettings)
        {
            _comparisonSettings = comparisonSettings;
        }

        public IPerformAComparison EqualTo(object objB)
        {
            return Shim(new CheckEquality(objB));
        }

        public IAssertionRoot Not
        {
            get { return new IsTotallyInstance(_comparisonSettings.GetOther()); }
        }

        public IPerformAComparison Shim(IPerformAComparison comparison)
        {
            return _comparisonSettings == ComparisonSettings.Negated
                ? new Invert(comparison)
                : comparison;
        }
    }

    public interface IAssertionRoot
    {
        IPerformAComparison EqualTo(object objB);
        IAssertionRoot Not { get; }
    }

    public class Invert : IPerformAComparison
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
