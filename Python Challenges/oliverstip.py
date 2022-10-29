
total = int(input("What is the total bill? "))
split = int(input("How many is the bill split between? "))

def Main():
    percent = int(input("What percentage tip would you like to give? 10, 12 or 15? "))
    if percent == 10 or 12 or 15:
        actualpercent = (percent/100)+1
        payperperson = (total*actualpercent)/split
        print(payperperson)
    else:
        Main()

Main()
