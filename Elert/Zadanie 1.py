tab=[]
n=input("Proszę podać ile ma być liczb: ")
n=int(n)
k=input("Proszę podać krok: ")
k=int(k)
el = input("Proszę podać pierwszy element: ")
el = int(el)
i = 1
tab.append(el)

for i in range(n):
    tmp = tab[i-1]*k
    tab.append(tmp)
    i+=1
i=1
for i in range(n):
    print("Dla liczby {i} ciąg wynosi {licz}".format(i=i,licz=tab[i]))


