import random 

#11 guesses needed to end game
word_list = ['apple','banana','cherry','dates','etc'] 
word_choice = random.choice(word_list)
wordlist = []

wordseperated = list(word_choice)
guessed = False
wrongguesses = []
amountofwrongguesses = len(wrongguesses)
hangman = ["START", """





__________

""","""
|
|
|
|
|_________

""","""
|---------|
|         
|
|
|_________

""","""
|---------|
|/
|
|
|_________

""","""
|---------|
|/        o
|
|
|__________

""","""
|---------|
|/        o
|         |
|
|__________

""","""
|---------|
|/        o
|         |
|          |
|__________

""","""
|---------|
|/        o
|         |
|        | |
|__________

""","""
|---------|
|/        o
|        (|
|        | |
|__________

""","""
|---------|
|/        o
|        (|)
|        | |
|__________
HANGMAN

""", "","","","","",""]
def WordPresentation():
    wordshown = []
    d = 0    
    for d in range(d, len(word_choice)):
        wordshown.append(" _ ")
    print("This word is", len(word_choice), "letters long!")
    print(wordshown)


def WordCreation():
    guess = input("Guess a letter: ")
    x = 0
    if len(guess) == 1:
        for x in range (x, len(word_choice)):
            if guess in wordseperated[x]:
                x = x+1
                wordlist.append(guess)
            elif guess not in wordseperated[x]:
                wordlist.append(" _ ")
        if guess in word_choice:
            print(guess, " was found in the word!")
        elif guess not in word_choice:
            print(guess, " was not found!")
            wrongguesses.append(guess)
            amountofguesses = 1
            print(hangman[amountofguesses])
    else:
        print("You must enter one letter")
        WordCreation()
    print(wordlist, "| Incorrect: ", wrongguesses)
    amountofwrongguesses = len(wrongguesses)
    print(amountofwrongguesses)


def WordGuessing():
    guessagain = input("Guess a letter: ")
    y = 0
    if guessagain not in wrongguesses and len(guessagain) == 1 and guessagain is not int:
        for y in range(y, len(word_choice)):
            if guessagain in word_choice[y]:
                wordlist[y] = guessagain
                print(wordlist[y])
                print(wordlist)
        if guessagain in word_choice:
            print(guessagain, " was found in the word!")
        elif guessagain not in word_choice:
            print(guessagain, " was not found!")
            wrongguesses.append(guessagain)
            amountofwrongguesses = len(wrongguesses)
            print(hangman[len(wrongguesses)])
        print(wordlist, "| Incorrect: ", wrongguesses)
        if len(wrongguesses) == 10:
            print("Hangman! You did not guess the correct word! It was ", word_choice)
            Main()
        if " _ " not in wordlist:
            guessed = True
            print("You have guessed the word!")
            Main()
    else:
        print("You must enter one letter")

    
def Main():
    WordPresentation()
    WordCreation()
    while guessed == False:
        WordGuessing()

Main()
