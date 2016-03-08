# Roman Numerals

The Romans were a clever bunch. 

They conquered most of Europe and ruled it for hundreds of years. They invented concrete and straight roads and even bikinis. 

One thing they never discovered though was the number zero. This made writing and dating extensive histories of their exploits slightly more challenging, but the system of numbers they came up with is still in use today.

The Romans wrote numbers using letters:

    I = 1
    V = 5
    X = 10
    L = 50
    C = 100
    D = 500
    M = 1000

You can combine letters to add values, by listing them largest to smallest from left to right:

    II = 2
    VIII = 8
    XXXI = 31
    
However, you may only list three consecutive identical letters. A single lower value may proceed a larger value, to indicate subtraction. 

This rule is only used to build values not reachable by the previous rules:

    IV = 4
    CM = 900

But 15 is XV, not XVX.

## Further Hints

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 

## Examples

**1990**: 1000=M, 900=CM, 90=XC; MCMXC. 

**2008**: 2000=MM, 8=VIII; MMVIII.

## Task

Write a program that converts numbers to numerals.