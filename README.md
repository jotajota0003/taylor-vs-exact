# Taylor vs Error

A MATLAB tool for visualizing and comparing Taylor series approximations against exact function values, with comprehensive error analysis.

## Overview

This project provides an interactive MATLAB function that allows users to explore how well Taylor series approximations represent mathematical functions. It generates side-by-side visualizations of the Taylor series approximation versus the exact function, along with detailed error metrics.

## Features

- **Interactive Function Input**: Enter any MATLAB-compatible mathematical function
- **Customizable Taylor Series**: Specify the number of terms for approximation accuracy
- **Flexible Approximation Point**: Choose any center point (x₀) for the Taylor expansion
- **Dual Visualization**:
  - Comparison plot of Taylor approximation vs. exact function
  - Error analysis plot showing percentage error across the domain
- **Error Metrics**: Calculates Mean Absolute Error (MAE) and True Relative Error (TRE)

## Requirements

- MATLAB (with Symbolic Math Toolbox)
- Required toolboxes:
  - Symbolic Math Toolbox

## Usage

1. Run the function in MATLAB:
   ```matlab
   taylorVsExact()
   ```

2. Follow the interactive prompts:
   - **Enter a function**: e.g., `sin(x)`, `exp(-x)`, `log(x)` for ln(x), `log10(x)` for log base 10
   - **Number of terms**: Specify how many terms to include in the Taylor series (higher = more accurate)
   - **Approximation point (x₀)**: Choose the center point for the Taylor expansion

3. View the generated plots:
   - **TaylorVsExact**: Shows the Taylor approximation (red dashed) vs. exact function (black solid)
   - **Error**: Displays percentage error across the x-range

## Example

```matlab
>> taylorVsExact()
Please enter an acceptable function (ex. sin(x), exp(-x)), also for ln(x) use log(x) and for normal log(x) use log10(x): sin(x)
Please enter the Number of Terms for the Taylor Series: 5
Please enter Approximate Point, x0: 0
```

This will generate plots comparing a 5-term Taylor series for sin(x) centered at x=0 against the exact sine function over the range [0, 6].

## How It Works

The program:
1. Converts the input string to a symbolic function
2. Computes derivatives up to the nth order
3. Evaluates the Taylor series at 50 points across [0, 6]
4. Calculates exact function values for comparison
5. Computes error metrics (MAE and TRE as percentages)
6. Generates two publication-quality figures with grid and legend

## Mathematical Background

The Taylor series expansion of a function f(x) around point x₀ is:

```
f(x) ≈ f(x₀) + f'(x₀)(x-x₀) + f''(x₀)(x-x₀)²/2! + ... + f⁽ⁿ⁾(x₀)(x-x₀)ⁿ/n!
```

This program implements this expansion and visualizes how well it approximates the true function.

## Error Analysis

The program calculates:
- **MAE (Mean Absolute Error)**: `|exact - approximation|`
- **TRE (True Relative Error)**: `(exact - approximation) / exact × 100%`

## Supported Functions

Any MATLAB-compatible function including:
- Trigonometric: `sin(x)`, `cos(x)`, `tan(x)`
- Exponential: `exp(x)`, `exp(-x)`
- Logarithmic: `log(x)` (natural log), `log10(x)` (base 10)
- Polynomial: `x^2`, `x^3 + 2*x`
- Combinations: `sin(x)*exp(-x)`

## Limitations

- Plotting range is fixed at [0, 6]
- Number of plotting points is fixed at 50
- Functions must be valid MATLAB symbolic expressions
- Function must be differentiable n times at the chosen x₀

## Contributing

Feel free to fork this repository and submit pull requests for improvements such as:
- Customizable plotting ranges
- Additional error metrics
- Animation of convergence with increasing terms
- Support for multivariable functions

## License

This project is open source and available for educational and research purposes.

## Author

Rebanta-Gupta

---

*This tool was created to help students and educators visualize numerical approximation concepts in calculus and numerical analysis.*
