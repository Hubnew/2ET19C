tab=[]
n=input("Proszę podać potęge: ")
n=int(n)
k=input("Proszę podać liczbę: ")
k=int(k)
i = 2
tab.append(i)
tab.append(k)

for i in range(i<=n):
    tmp = tab[i-1]*tab[1]
    tab.append(tmp)
    i+=1
print("Potęga stopnia {n} dla liczby {k} ciąg wynosi {licz}".format(k=k, n=n,licz=tab[-1]))


