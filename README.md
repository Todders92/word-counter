# _Word Counter_

#### _A C# Console Application to count the number of times a word appears in a sentence_

#### By _**Todd Walraven**_



## Description

_This console application will have the user input a sentence, and then a word. The application will check the sentence against the inputted word and see how many times the word appears in the inputted sentence_

## Behavior Driven Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
|Users inputs a sentence|"the quick brown fox jumped over the lazy dog"|"the quick brown fox jumped over the lazy dog"|
|user inputs a word after inputting sentence|"dog"|"dog"|
|new instance of sentence object is created with input sentence, input word and a counter as fields|||
|Application compares word property to sentence property to see if there are any matches|"the quick brown fox jumped over the lazy dog" "dog"|true|
|if the comparison identifies a matching word it adds 1 to the score property|"the quick brown fox jumped over the lazy dog" "dog"|score +1|

## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone https://github.com/todders92/word-counter.git
```
3.  Enter into the new file directory
```sh
cd rock-paper-scissors
```
4.  Start the program
```sh
dotnet run
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/todders92/word-counter/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Todd Walraven_**