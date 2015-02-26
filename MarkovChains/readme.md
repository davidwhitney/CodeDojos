# Origin

Derived from RubyQuiz #74 - http://rubyquiz.com/quiz74.html

# Markov Chains

A Markov chain, named after Andrey Markov, is a mathematical system that undergoes transitions from one state to another on a state space. It is a random process usually characterized as memoryless: the next state depends only on the current state and not on the sequence of events that preceded it. Markov chains have many applications as statistical models of real-world processes.

**Thanks for the science, wikipedia.**

Markov processes can also be used to generate superficially real-looking text given a sample document: they are used in a variety of recreational "parody generator" programs as well as spammers to inject real-looking hidden paragraphs into unsolicited email and post comments in an attempt to get these messages past spam filters.

To use Markov Chains, **you read some text document(s), making note of which words commonly follow other words**. Then, when generating text, you **select a word to output, based on the characters or words that came before it**.

**The number of previous words considered is called the "order" and you can adjust that to try and find a natural feel**. This means that rather than noting the words that follow one specific word, you'll be noting the words that follow a set of words.

You can find training texts on [Project Gutenberg](http://www.gutenberg.org/) and I've included two sample tests - the famously long "War and Peace" and "Alice's Adventures in Wonderland" in this repository.

### Story 1 - A markov chain for a single order

    As a user
    When I supply a word
    A story is generated

    Accept: Story is ~800 words long.

### Story 2 - Human sentences

    As a user
    When I supply a word
    The output contains sentences punctuated with full stops

    Accept: Full stops placed at average sentence length
            Preceeding words influnced by markov chain

### Story 3 - Order greater than 1

    As a user
    When I supply a word, and an order > 1
    A story is generated

    Accept: Story must consider sets of preceeding words
            Attempt to make the story "human readable"

# Example

Here is some generated text using a second order word chain derived from the Sherlock Holmes novel "The Hound of the Baskervilles" by Arthur Conan Doyle:

    The stars shone cold and bright, while a crushing weight of responsibility
    from my shoulders. Suddenly my thoughts with sadness. Then on the lady's
    face. "What can I assist you?"
