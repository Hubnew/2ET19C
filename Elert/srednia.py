ile = input("Ile danych chcesz wprowadzić? ")
ile=int(ile)
dane=[]
for i in range(ile):
    tmp=input("proszę podać wartość: ")
    tmp=int(tmp)
    dane.append(tmp)
suma=0
for i in range(ile):
    suma=suma+dane[i]/ile
print("suma liczb: ")
for i in range(ile):
    print("dane[{i}]={dan}".format(i=i,dan=dane[i]))
print(f"Wynosi : {suma}")
