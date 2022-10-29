loimport random

def HeadsOrTails():
    headsortails = ["Heads", "Tails"]
    choices = random.choice(headsortails)

    yesorno = input("do you want to flip a coin? Yes or No")

    capital = yesorno.upper()

    if capital == "YES" or capital == "Y":
        print(choices)
        HeadsOrTails()
    elif capital == "NO" or capital == "N":
        print("Ok, exiting")
        while True:
            break
    else:
        print("you must enter either yes or no")
        HeadsOrTails()

HeadsOrTails()
