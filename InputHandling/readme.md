# Input Handling

One of the most common things in software is to accept user input on a command line - however generally the built in mechanism to do so is remarkably low level.

Todays challenge is to write a high-er level library or class to formalise a few common input patterns.

The output here is provided for example purposes, but you should carefully consider
the usability, extensibility and syntax of your call.

The more elegant and idiomatic to your language, with the lease noise, the better.

# Story 1 - As a user, I am asked to verify my input

* Given an input value 'input'
* You are prompted to verify the input

```
    Enter input: a
    Are you sure? Press 'y' to confirm, or any other key to cancel.
```

# Story 2 - As a user, I can enter validated input

* When asked for a specific `type` of input
* The input is validated

```
  Enter a number: 10

  Enter a number: no!
  'no!' is not a valid number.
```

# Story 3 - As a user, I can constrain my input

* When asked for an input
* Custom rules can be defined

```
Enter a number between 1-10: 6

```
# Story 4 - As a user, I am asked to retry

* When asked for an input
* And I provide an invalid value
* I am asked to retry.

```
Enter a number between 1-10: 6

Enter a number between 1-10: 11
'11' is out of range.
Enter a number between 1-10:

```

# Story 5 - As a user, I can input from a selection

* When asked for an input
* I am constrained to choices

```
    Enter 'dog' or 'cat': dog
    Enter 'dog' or 'cat': fish
    'fish' is invalid
    Enter 'dog' or 'cat':
```
