
# Benchmarks

**EnKor's Luhn algorithm implementation is 80x faster and allocates no memory** compared to most downloaded nuget CreditValidator (867K downloads) or almost 17x to LuhnNet (39K downloads - 2nd most downloaded).


Test results of method **CalculateCheckDigit** (or respective variant in other nugets) to calculate check digit.

|                   Method |      Value |        Mean |     Error |   StdDev | Ratio | RatioSD |   Gen0 | Allocated |
|------------------------- |----------- |------------:|----------:|---------:|------:|--------:|-------:|----------:|
|               **EnKor Luhn** | 2211041771 |    12.94 ns |  0.211 ns | 0.197 ns |  1.00 |    0.00 |      - |         - |
|             LuhnNetNuget | 2211041771 |   219.22 ns |  2.528 ns | 2.365 ns | 16.95 |    0.35 | 0.0496 |     312 B |
| CreditCardValidatorNuget | 2211041771 | 1,037.18 ns | 11.154 ns | 9.887 ns | 80.09 |    1.64 | 0.2460 |    1544 B |


Test results of method **IsValid** (or respective variant in other nugets) to check validity.

|                   Method |      Value |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen0 | Allocated |
|------------------------- |----------- |------------:|----------:|----------:|------:|--------:|-------:|----------:|
|              **EnKor Luhn** | 2211041771 |    15.47 ns |  0.275 ns |  0.257 ns |  1.00 |    0.00 |      - |         - |
|             LuhnNetNuget | 2211041771 |   225.96 ns |  4.450 ns |  7.910 ns | 14.72 |    0.51 | 0.0381 |     240 B |
| CreditCardValidatorNuget | 2211041771 | 1,122.01 ns | 22.267 ns | 43.952 ns | 72.61 |    3.09 | 0.2327 |    1464 B |
