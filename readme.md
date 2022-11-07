
# Benchmarks

**EnKor's Luhn algorithm implementation is 60x more performant** compared to most downloaded nuget CreditValidator (867K downloads) or 12.4x to LuhnNet (39K downloads), **and allocates no memory**.


Test results of method CalculateCheckDigit to calculate check digit.

|              Method |       Code |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated |
|-------------------- |----------- |------------:|----------:|----------:|------:|--------:|-------:|----------:|
|          **EnKor Luhn** | 2211041771 |    22.87 ns |  0.467 ns |  0.479 ns |  1.00 |    0.00 |      - |         - |
|             LuhnNet | 2211041771 |   301.44 ns |  8.912 ns | 26.138 ns | 12.44 |    1.64 | 0.0496 |     312 B |
| CreditCardValidator | 2211041771 | 1,370.67 ns | 30.663 ns | 88.468 ns | 60.03 |    4.10 | 0.2460 |    1544 B |


Test results of method IsValid to check validity.

|                   Method |      Value |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------- |----------- |------------:|----------:|----------:|------------:|------:|--------:|-------:|----------:|------------:|
|                **EnKor Luhn** | 2211041771 |    23.34 ns |  0.845 ns |  2.465 ns |    22.91 ns |  1.00 |    0.00 |      - |         - |          NA |
|           EnKorLuhnNuget | 2211041771 |    19.07 ns |  0.602 ns |  1.727 ns |    18.23 ns |  0.83 |    0.09 |      - |         - |          NA |
|             LuhnNetNuget | 2211041771 |   318.78 ns |  8.408 ns | 24.658 ns |   310.79 ns | 13.76 |    1.37 | 0.0381 |     240 B |          NA |
| CreditCardValidatorNuget | 2211041771 | 1,516.00 ns | 30.309 ns | 31.125 ns | 1,520.62 ns | 59.71 |    5.54 | 0.2327 |    1464 B |          NA |
