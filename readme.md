
# Benchmarks

**EnKor's Luhn algorithm implementation is 60x more performant** compared to most downloaded nuget CreditValidator (867K downloads) or 12.4x to LuhnNet (39K downloads), **and allocates no memory**.


Test results of method CalculateCheckDigit to calculate check digit.

|                   Method |       Code |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated |
|------------------------- |----------- |------------:|----------:|----------:|------:|--------:|-------:|----------:|
|               **EnKor.Luhn** | 2211041771 |    22.87 ns |  0.467 ns |  0.479 ns |  1.00 |    0.00 |      - |         - |
|             LuhnNetNuget | 2211041771 |   301.44 ns |  8.912 ns | 26.138 ns | 12.44 |    1.64 | 0.0496 |     312 B |
| CreditCardValidatorNuget | 2211041771 | 1,370.67 ns | 30.663 ns | 88.468 ns | 60.03 |    4.10 | 0.2460 |    1544 B |
