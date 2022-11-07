
# Benchmarks

**EnKor's Luhn algorithm implementation is 60x more performant** compared to most downloaded nuget CreditValidator (867K downloads) or 12.4x to LuhnNet (39K downloads), **and allocates no memory**.


Test results of method CalculateCheckDigit (or respective varian in other nugets) to calculate check digit.

|                   Method |      Value |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------- |----------- |------------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|           EnKorLuhnNuget | 2211041771 |    14.07 ns |  0.270 ns |  0.289 ns |  1.00 |    0.00 |      - |         - |          NA |
|             LuhnNetNuget | 2211041771 |   267.02 ns |  5.188 ns |  9.355 ns | 19.25 |    0.76 | 0.0496 |     312 B |          NA |
| CreditCardValidatorNuget | 2211041771 | 1,216.29 ns | 19.241 ns | 16.067 ns | 86.19 |    1.98 | 0.2460 |    1544 B |          NA |


Test results of method IsValid (or respective varian in other nugets) to check validity.

|                   Method |      Value |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|------------------------- |----------- |------------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
|              **EnKor Luhn** | 2211041771 |    15.47 ns |  0.275 ns |  0.257 ns |  1.00 |    0.00 |      - |         - |          NA |
|             LuhnNetNuget | 2211041771 |   225.96 ns |  4.450 ns |  7.910 ns | 14.72 |    0.51 | 0.0381 |     240 B |          NA |
| CreditCardValidatorNuget | 2211041771 | 1,122.01 ns | 22.267 ns | 43.952 ns | 72.61 |    3.09 | 0.2327 |    1464 B |          NA |
