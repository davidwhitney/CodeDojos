This is derived from RubyQuiz: http://rubyquiz.com/quiz122.html

# Credit Card Validation and Detection

Before a credit card is submitted to a financial institution, it generally makes sense to run some simple reality checks on the number. The numbers are a good length and it's common to make minor transcription errors when the card is not scanned directly.

The first check people often do is to validate that the card matches a known pattern from one of the accepted card providers. Some of these patterns are:

      +============+=============+===============+
      | Card Type  | Begins With | Number Length |
      +============+=============+===============+
      | AMEX       | 34 or 37    | 15            |
      +------------+-------------+---------------+
      | Discover   | 6011        | 16            |
      +------------+-------------+---------------+
      | MasterCard | 51-55       | 16            |
      +------------+-------------+---------------+
      | Visa       | 4           | 13 or 16      |
      +------------+-------------+---------------+

Writing code to detect these card types is simple enough, but additionally, card numbers are generated so that they all validate against the `Luhn Check`.

1. Starting with the next to last digit and continuing with every other
digit going back to the beginning of the card, double the digit
2. Sum all doubled and untouched digits in the number
3. If that total is a multiple of 10, the number is valid

Valid example -

    1.  8 4 0 8 0 4 2 2 6 4 10 6 14 8 18 3
    2.  8+4+0+8+0+4+2+2+6+4+1+0+6+1+4+8+1+8+3 = 70
    3.  70 % 10 == 0

Invalid example -

    1.  8 4 2 7 2 2 6 4 10 6 14 8 18 1 2 2
    2.  8+4+2+7+2+2+6+4+1+0+6+1+4+8+1+8+1+2+2 = 69
    3.  69 % 10 != 0


Lets write some code to detect and identify card types.

## Story 1 - Detect card type

    As a user
    When I provide a card number
    The card type is detected

## Story 2 - Luhn validity

    As a user
    When I provide a card number
    It is validated against the luhn algorithm


# Notes

Pay attention to how you factor your code - is there an elegant way to express these types of validation rules?

Can you think of creative or idiomatic ways to express these kinds of requirements?

Be playful - it's a kata!
