figlet = """     _            _   _                   _     __ ____  
    | |          | | | |                 | |   /_ |___ \ 
  __| | ___  __ _| |_| |__   ___ ___   __| | ___| | __) |
 / _` |/ _ \/ _` | __| '_ \ / __/ _ \ / _` |/ _ \ ||__ < 
| (_| |  __/ (_| | |_| | | | (_| (_) | (_| |  __/ |___) |
 \__,_|\___|\__,_|\__|_| |_|\___\___/ \__,_|\___|_|____/ 
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