ISBN Validator
===============

This is a reformatted kata from [reddit.com/r/dailyprogrammer](http://www.reddit.com/r/dailyprogrammer/comments/2s7ezp/20150112_challenge_197_easy_isbn_validator/)

ISBN's (International Standard Book Numbers) are identifiers for books. Given the correct sequence of digits, one book can be identified out of millions of others thanks to this ISBN.

But when is an ISBN not just a random slurry of digits? That's for you to find out.

# Rules

Given the following constraints of the ISBN number, you should write a function that can return True if a number is a valid ISBN and False otherwise.

An ISBN is a ten digit code which identifies a book. The first nine digits represent the book and the last digit is used to make sure the ISBN is correct.

To verify an ISBN you:

* obtain the sum of 10 times the first digit, 9 times the second digit, 8 times the third digit... all the way till you add 1 times the last digit. If the sum leaves no remainder when divided by 11 the code is a valid ISBN.

For example:

`0-7475-3269-9` is Valid because:

    (10*0) + (9*7) + (8*4) + (7*7) + (6*5) + (5*3) + (4*2) + (3*6) + (2*9) + (1*9) = 242

Which can be divided by 11 and have no remainder.

For the cases where the last digit has to equal to ten, the last digit is written as X. For example  `156881111X`.

---

### Story 1 - Validate a known good ISBN

    As a user
    When I provide a valid ISBN
    The program returns true

### Story 2 - Reject invalid ISBN

    As a user
    When I provide a junk ISBN
    The program returns false

### Story 3 - Generate a valid ISBN

    As a user
    I can generate a fresh, valid ISBN
    So that I can write a new book!
