using BenchmarkDotNet.Attributes;

namespace Casting;


[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Benchmark]
    public Person HardCast()
    {
        Person nickHardCast = (Person)StaticObjects.Nick;
        return nickHardCast;
    }

    [Benchmark]
    public Person SafeCast()
    {
        Person? nick = StaticObjects.Nick as Person;
        return nick!;
    }

    [Benchmark]
    public Person MatchCast()
    {
        if (StaticObjects.Nick is Person person)
        {
            return person;
        }

        return null!;
    }
}