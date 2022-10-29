yearinput = float(input("Which year do you want to check? "))

yearinputdivide4 = yearinput/4
yearinputdivide100 = yearinput/100
yearinputdivide400 = yearinput/400

if yearinputdivide4.is_integer():
    if yearinputdivide100.is_integer():
        if yearinputdivide400.is_integer():
            print("4This year is a leap year")
        else:
            print("3This year is not a leap year")
    else:
        print("2This year is a leap year")
else:
    print("1This year is not a leap year")
    
