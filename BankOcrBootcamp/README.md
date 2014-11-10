# Original Description

This is derived from a code kata presented at XP2006 by EmmanuelGaillot and ChristopheThibaut see: http://www.codingdojo.org/cgi-bin/wiki.pl?KataBankOCR

## Problem Description

You work for a bank, which has recently purchased an ingenious machine to assist in reading letters and faxes sent in by branch offices. The machine scans the paper documents, and produces a file with a number of entries which each look like this:

<pre>
    _  _     _  _  _  _  _
  | _| _||_||_ |_   ||_||_|
  ||_  _|  | _||_|  ||_| _|
</pre>

Each entry is 4 lines long, and each line has 27 characters. The first 3 lines of each entry contain an account number written using pipes and underscores, and the fourth line is blank. Each account number should have 9 digits, all of which should be in the range 0-9. A normal file contains around 500 entries.

Your first task is to write a program that can take this file and parse it into actual account numbers.

### Story 1

Parsing the output file.

    As a user
    When I parse a file with a single set of digits
    The correct numbers are returned

### Story 2

Handling unknown characters

    As a developer
    When the parser encounters a pattern it doesn't recognise
    It throws an exception

## Clues

I recommend finding a way to write out 3x3 cells on 3 lines in your
code, so they form an identifiable digits. Even if your code actually
doesn't represent them like that internally. I'd much rather read

<pre>
"   " +
"|_|" +
"  |"
</pre>

than

<pre>
"   |_|  |"
</pre>

anyday.

## Suggested Test Cases

If you want to just copy and paste these test cases into your editor,
I suggest first clicking "edit this page" so you can see the source.
Then you can be sure to copy across all the whitespace necessary. Just
don't save any changes by mistake.

<pre>
 _  _  _  _  _  _  _  _  _
| || || || || || || || || |
|_||_||_||_||_||_||_||_||_|

=> 000000000

  |  |  |  |  |  |  |  |  |
  |  |  |  |  |  |  |  |  |

=> 111111111
 _  _  _  _  _  _  _  _  _
 _| _| _| _| _| _| _| _| _|
|_ |_ |_ |_ |_ |_ |_ |_ |_

=> 222222222
 _  _  _  _  _  _  _  _  _
 _| _| _| _| _| _| _| _| _|
 _| _| _| _| _| _| _| _| _|

=> 333333333

|_||_||_||_||_||_||_||_||_|
  |  |  |  |  |  |  |  |  |

=> 444444444
 _  _  _  _  _  _  _  _  _
|_ |_ |_ |_ |_ |_ |_ |_ |_
 _| _| _| _| _| _| _| _| _|

=> 555555555
 _  _  _  _  _  _  _  _  _
|_ |_ |_ |_ |_ |_ |_ |_ |_
|_||_||_||_||_||_||_||_||_|

=> 666666666
 _  _  _  _  _  _  _  _  _
  |  |  |  |  |  |  |  |  |
  |  |  |  |  |  |  |  |  |

=> 777777777
 _  _  _  _  _  _  _  _  _
|_||_||_||_||_||_||_||_||_|
|_||_||_||_||_||_||_||_||_|

=> 888888888
 _  _  _  _  _  _  _  _  _
|_||_||_||_||_||_||_||_||_|
 _| _| _| _| _| _| _| _| _|

=> 999999999
    _  _     _  _  _  _  _
  | _| _||_||_ |_   ||_||_|
  ||_  _|  | _||_|  ||_| _|

=> 123456789
</pre>
