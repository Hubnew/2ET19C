def dodaj(a,b,c):
    if((a>0) and (b>0)and(c>0)and (a+b>c)and(b+c>a)and(a+c>b)and((a==b) or(a==c)or(b==c)or(b==a)or(c==b)or(c==a))):
        return 1
    else:
        return 0
def pot(a,n):
    potega=int(1)
    i=int(1)
    for i in range(n):
        potega=potega*a
    return potega
odp="T"
while (odp == "T" or odp == "t"):
    print("Proszę podać numer")
    print("1.Sprawdzenie trójkąta równobocznego")
    print("2.Potęga")
    print("3.Zakończ")
    opcja=input("")
    opcja=int(opcja)
    if(opcja == 1):
        a=input("proszę podać bok1: ")
        a=int(a)
        b=input("Proszę podać bok2: ")
        b=int(b)
        c=input("Proszę podać bok3: ")
        c=int(c)
        dodaj(a,b,c)
        if(dodaj(a,b,c)):
            print(f"Parametry {a},{b} oraz {c} spełniają wymagania trójkąta równobocznego")
        else:
            print(f"Parametry {a},{b} oraz {c} nie spełniają wymagania trójkąta równobocznego")
    if(opcja == 2):
        a=input("proszę podać liczbę: ")
        a = int(a)
        n=input("proszę podać potęgę: ")
        n=int(n)
        potega = pot(a,n)
        print(potega)
    if(opcja == 3):
        odp = "N"
print("koniec")
