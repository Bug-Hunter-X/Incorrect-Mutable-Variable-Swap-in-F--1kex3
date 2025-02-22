# F# Mutable Variable Swap Bug

This example demonstrates a common error when working with mutable variables in F#.  The `swap` function attempts to exchange the values of `x` and `y`, but due to how mutable variables are handled, it doesn't work as expected.  The solution provides the correct implementation using a tuple return for swapping values.