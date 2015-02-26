# Origin

This kata is reformatted from http://codekata.com/kata/kata19-word-chains/

# Word Chains

There's a type of puzzle where the challenge is to build a chain of words, starting with one particular word and ending with another.

Successive entries in the chain must all be real words, and each can differ from the previous word by just one letter. For example, you can get from “cat” to “dog” using the following chain.

    cat
    cot
    cog
    dog

The objective of this kata is to write a program that accepts start and end words and, using words from the dictionary, builds a word chain between them.

# Story 1 - A simple chain

    As a user
    When I input two words
    A word chain is generated and output

# Story 2 - Return the shortest chain

    As a user
    When I input two words
    The shortest possible chain is generated and output
