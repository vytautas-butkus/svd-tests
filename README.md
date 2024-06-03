# svd-tests

## Structure

References to external libraries are shown by dashed lines.

```mermaid
flowchart TD
MATHNET[MathNet.Numerics] -.-> TESTS
CORE --> TESTS[HarpiaCalc.Tests]
MATHNET -.-> CORE
CORE[HarpiaCalc.Core ] --> CLI[HarpiaCalc.CLI]
CORE --> GUI[HarpiaCalc.WpfApp]
SCICHART[SciChart] -.-> GUI
```

### 1. `HarpiaCalc.Core` (.NET 8 Class library)
All calculations are done here

**Includes**: all necessary libraries, does not include references to other projects

### 2. `HarpiaCalc.CLI` (.NET 8 Console application)
Console application for testing and command-line interface

**Includes**: `HarpiaCalc.Core`

### 3. `HarpiaCalc.WpfApp` (.NET 8 WPF application)
Application with GUI for more complex function testing, that is not comfortable with CLI

**Includes**: `HarpiaCal.Core`, additional GUI/plotting libraries

### 4. `HarpiaCalc.Tests` (Unit tests)

**Includes**: `HarpiaCal.Core`, `MathNet.Numerics`