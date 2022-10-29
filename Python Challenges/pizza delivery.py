print("Welcome to Python Pizza Deliveries!")
size = input("What size pizza do you want? S, M, or L: ")
pepperoni = input("Do you want pepperoni? Y or N: ")
extraCheese = input("Do you want extra cheese? Y or N: ")

def Pizza():
    total = 0
    if size == "S" or size == "s":
        total = total + 15
    elif size == "M" or size == "m":
        total = total + 20
    elif size == "L" or size == "l":
        total = total + 25
    else:
        Pizza()
    if pepperoni == "Y" or pepperoni == "y":
        if size == "S" or size == "s":
            total = total + 2
        elif size == "M" or size == "m":
            total = total + 3
        elif size == "L" or size == "l":
            total = total + 3
    elif pepperoni == "N" or pepperoni == "n":
        total = total
    else:
        Pizza()
    if extraCheese == "Y" or extraCheese == "y":
        total = total + 1
    else:
        Pizza()


    print("Your final bill is: £", total)

Pizza()
