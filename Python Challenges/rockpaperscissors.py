import random

display = ["""
    _________
___/   ______)
      (_______)
      (________)
___   (_______)
   |__(______)

""", """
    _________
___/   ______)
       ________)
       __________)
___    ________)
   |_________)

""", """
    _________
___/   ______)___
      ___________)
      ____________)
___   (________)
   |__(______)
        
"""]

def Game():
    userchoice = input("What do you choose? Type 0 for Rock, 1 for Paper, 2 for Scissors: ")
    computer = random.randint(0,2)
    #When the user chooses rock
    if userchoice == "0" and computer == 0:
        print("Computer chose")
        print(display[0])
        print("YOU DRAW")
    elif userchoice == "0" and computer == 1:
        print("Computer chose")
        print(display[1])
        print("YOU LOSE")
    elif userchoice == "0" and computer ==2:
        print("Compubter chose")
        print(display[2])
        print("YOU WIN")
        
    #When the user chooses paper
    elif userchoice == "1" and computer == 0:
        print("Computer chose")
        print(display[0])
        print("YOU WIN")
    elif userchoice == "1" and computer == 1:
        print("Computer chose")
        print(display[1])
        print("YOU DRAW")
    elif userchoice == "1" and computer ==2:
        print("Compubter chose")
        print(display[2])
        print("YOU LOSE")
        
    #When the user chooses paper
    elif userchoice == "2" and computer == 0:
        print("Computer chose")
        print(display[0])
        print("YOU LOSE")
    elif userchoice == "2" and computer == 1:
        print("Computer chose")
        print(display[1])
        print("YOU WIN")
    elif userchoice == "2" and computer == 2:
        print("Compubter chose")
        print(display[2])
        print("YOU DRAW")
    else:
        print("Please either input 0 for Rock, 1 for Paper or 2 for Scissors")
        Game()
        

def Main():
    while True:
        Game()

Main()
