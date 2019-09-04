howMany = input("How many sequences would you like me to show you? ")
userReq = int(howMany)
x = 0
fibA = 0
fibB = 1
fibC = 0
    
while x <= userReq:
    fibA = fibB
    fibB = fibC
    fibC = (fibA + fibB)

    print(fibB)
    x = x + 1