import random

## letters[25] = z
##letters[34] = end of symbols
allsymbols = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z", "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z", "!","£","$","%",",","^","&","*","(",")","_","+","{","}","@","~",":","<",">","?","[","]",";","'","#","/",".",",","|","`","¬","/","*","-","+"]
password = []

numberOfLetters = int(input("How many letters would you like in your password? "))
numberOfSymbols = int(input("How many symbols would you like in your password? "))
final = ""
shuffled = ""

totalLength = numberOfLetters+numberOfSymbols
appendchoice = random.choice(allsymbols)
print(allsymbols[0:26])
print(allsymbols[27:61])
print(len(allsymbols))
x = 0
for x in range(x, totalLength):
    appendchoice = random.choice(allsymbols)
    
    if numberOfSymbols == 0:
        password.append(random.choice(allsymbols[0:52]))
    elif numberOfLetters == 0:
        password.append(random.choice(allsymbols[53:87]))
    elif numberOfSymbols != 0 and numberOfLetters != 0:
        if appendchoice in allsymbols[0:26]:
            password.append(appendchoice)
            numberOfLetters = numberOfLetters - 1
        elif appendchoice in allsymbols[27:61]:
            password.append(appendchoice)
            numberOfSymbols = numberOfSymbols - 1

print("".join(password))
