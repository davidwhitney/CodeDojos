# Original Description

This is derived from a quiz posted on rubyquiz.com see: http://rubyquiz.com/quiz121.html

## Problem Description

Morse code is a way to encode telegraphic messages in a series of long and short sounds or visual signals. During transmission, pauses are used to group letters and words, but in written form the code can be ambiguous.

For example, using the typical dot (.) and dash (-) for a written representation of the code, the word ...---..-....- in Morse code could be an encoding of the names Sofia or Eugenia depending on where you break up the letters:

<pre>
...|---|..-.|..|.-    Sofia
.|..-|--.|.|-.|..|.-  Eugenia
</pre>

Write program that displays all possible translations for ambiguous words provided in code.

Your program will be passed a word of Morse code.
Your program should print all possible translations of the code.

Your code should print gibberish translations in case they have some meaning for the reader, but indicating which translations are in the dictionary could be a nice added feature.

We will only focus on the alphabet for this quiz to keep things simple. Here are the encodings for each letter:

<pre>
A .-            N -.
B -...          O ---
C -.-.          P .--.
D -..           Q --.-
E .             R .-.
F ..-.          S ...
G --.           T -
H ....          U ..-
I ..            V ...-
J .---          W .--
K -.-           X -..-
L .-..          Y -.--
M --            Z --..
</pre>



### Story 1

Parsing a word.

    As a user
    When I pass a known word in morse code
    The word is returned in English

### Story 2

Parsing a word with multiple options

    As a user
    When I pass morse code that could be more than one word
    Both word options are returned in English

## Clues

You might need to find a dictionary file form somewhere. Here's one I found: https://raw.githubusercontent.com/eneko/data-repository/master/data/words.txt
