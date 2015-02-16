# Description

The SASS CSS pre-processor is a popular way of rationalising the crazy of hand coded CSS for front end developers.

For this kata, we're going to build the start of a CSS pre-processor, paying attention to how our code is factored for extensibility and maintainability. Be mindful that we'll not be building out a complete pre-processor, so presume your code should be extensible.

Your program would run in the following form:

    > sass2css.exe my-sass-file.scss
    > sass2css.exe c:\some\file\path

And would ouptut

    > my-sass-file.css generated
    > path.css generated

The first execution would transform a single file, the second, an entire directory.

We're going to be implementing the SASS basics from http://sass-lang.com/guide


# Story 1 - Implement support for variables in scss files!

As a developer<br/>
When I use the variable syntax to declare a variable<br/>
All usages of that variable are pre-processed

Accept
* Variables can be defined
* Variables replaced in CSS block
* Variables can be a portion of the outputted CSS
* Whitespace characters are allowed between key / value of variable
* Variable declaration terminated with ;

Example:

      $font-stack:    Helvetica, sans-serif;
      $primary-color: #333;

      body {
        font: 100% $font-stack;
        color: $primary-color;
      }

Output:

      body {
        font: 100% Helvetica, sans-serif;
        color: #333;
      }

<br/>

# Story 2 - Partials

As a developer<br/>
When I try and process an .scss file starting with an underscore<br/>
Nothing is output

Accept:
 * Files of the form _something.scss do not get converted to _something.css

<br/>

# Story 3 - Imports

As a developer<br/>
I want to be able to import another file into my CSS file
So I can re-use code

    Accept: Import statements replaced with contents of imported file.
            Relative import paths supported

Example:

    /* reset.scss */
    .class hi {
      color: red;
    }

    /* import-test.scss */
    @import 'reset';

    body {
      font: 100% Helvetica, sans-serif;
      background-color: #efefef;
    }

Output:

    .class hi {
      color: red;
    }

    body {
      font: 100% Helvetica, sans-serif;
      background-color: #efefef;
    }
