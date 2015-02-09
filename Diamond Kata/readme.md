### Origin

This kata is based on a post by Seb Rose here: http://claysnow.co.uk/recycling-tests-in-tdd/

### Problem

Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
      A

    > diamond.exe B
       A
      B B
       A

    > diamond.exe C
        A
       B B
      C   C
       B B
        A

It may be helpful visualise the whitespace in your rendering like this:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _
