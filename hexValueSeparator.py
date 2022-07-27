figlet = """     _     _            _ _____ 
 ___| |__ (_)_   ____ _/ |___ / 
/ __| '_ \| \ \ / / _` | | |_ \ 
\__ \ | | | |\ V / (_| | |___) |
|___/_| |_|_| \_/ \__,_|_|____/ 
                                """
print(figlet)

while True:
    hexValue = input("hex value >> ")
    print()
    newHexValue = ""
    i = 0
    while i < len(hexValue):
        if i % 2 != 0 and i > 0:
            newHexValue =  newHexValue + hexValue[i - 1] + hexValue[i] + " "
        i = i + 1
    print(newHexValue)
    print()