# Rendszerterv

## 1. A rendszer célja
A rendszer célja, hogy a felhasználó fejlett iskolai között tudjon számolni,valutát átváltani. Fontos, hogy a felhasználó könnyen el tudjon igazodni a felületen, ezért minimalista felhasználói felületet kap a program. Az alkalmazás C# nyelven lesz elkészítve,Win Forms alkalmazásként.
## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters: Györkis Tamás
   * Product owner: Györkis Tamás
     
### 2.2 Projektmunkások és felelőségek:
   * Fejlesztők és tesztelők: a csapat tagjai
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (óra) | Aktuális becslés (óra) | Eltelt idő (óra) | Becsült idő (óra) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             4 |                      4 |                2 |                   2 |

### 2.4 Mérföldkövek:
   * Prototípus átadása

## 3. Üzleti folyamatok modellje

A mai világban az oktatásban nem mindenki tud magával vinni számológépet vagy elfelejti magával hozni, mivel nem használható saját telefonkészülék a tanórán és az iskolai számítógépeken elavultak a szoftverek ezért ennek érdekében csináltunk tudomáynos számológépet amihez csak a programot kell futtatni. A jelenlegi világban a fiatalok egyre kevésbé hajlandóak a "klasszikus"
módon tanulni, ezért a különböző oktatási intézmények alternatív módszereket
keresnek.

### 3.1 Üzleti szereplők
Főként a diákok de bárki használhatja

### 3.2 Üzleti folyamatok

ingyenes

## 4. Követelmények

### Funkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K1 | Adatok tárolása | Előző számítások eltárolása|
| K2 | Csoport választás | Kiválasztható, hogy milyen matematikai nyelven akar számolni |
| K3 | Működés | Webes környezeten való müködés engedélyezett |

### Nemfunkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K4 | Védelem |  A felhasználók között semmiféle kommunikáció nincsen |

### Támogatott eszközök
GDPR-nek való megfelelés

Saját gépen a programfuttatásával elérhető 

## 5. Funkcionális terv

### 5.1 Rendszerszereplők
Admin
Felhasználó

### 5.2 Menühierarchiák

MAIN MENÜ

matematikai számítás változtatása a felsoroltak közül

## 6. Fizikai környezet


● Az alkalmazás  web platformra készül
● Nincsenek megvásárolt komponenseink.
● Fejlesztői eszközök:
o Visual Studio
o Github
o Trello

### Vásárolt softwarekomponensek és külső rendszerek

### Hardver topológia

### Fizikai alrendszerek

### Fejlesztő eszközök


## 8. Architekturális terv

Mindent a saját számítógépünk tárol és semmi információra nincs szükség használat közbe a szervertől, esetleges frissítésknel elengedhetetlen az internet kapcsolat.

### Webszerver

### Adatbázis rendszer

### A program elérése, kezelése

Saját számítógépen van a program, internet nélkül is futtatható

## 9. Adatbázis terv

## 10. Implementációs terv

Web:
A felület főként C# nyelven fog készülni.
Ezeket a technológiákat amennyire csak lehet külön fájlokba írva készítjük, és úgy fogjuk egymáshoz csatolni a jobb átláthatóság, könnyebb változtathatóság,
és könnyebb bővítés érdekében.


## 11. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.

### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | ... | ... |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 12. Telepítési terv

Fizikai telepítési terv: 

Szoftver telepítési terv: Mellékelt telepítőfájl futtatása után elérhető lesz az alkalmazás az Asztalon vagy a Start menüben.

## 13. Karbantartási terv

Fontos ellenőrizni:
Az alkalmazás folyamatos üzemeltetése és karbantartása, mely
magában foglalja a programhibák elhárítását, a belső igények változása miatti
módosításokat, valamint a környezeti feltételek változása miatt felmerüló esetleges hibák hárítása.Idő elteltével új kategóriákat kell hozzáadni a számológéphez, hogy fent tartsuk az érdeklődési szintet.

Karbantartás
Corrective Maintenance: A felhasználók által felfedezett és "user reportban"
elküldött hibák kijavítása.
Adaptive Maintenance: A program naprakészen tartása és finomhangolása.
Perfective Maintenance: A szoftver hosszútávú használata érdekében végzett
módosítások, új funkciók, a szoftver teljesítményének és működési
megbízhatóságának javítása.
Preventive Maintenance: Olyan problémák elhárítása, amelyek még nem
tűnnek fontosnak, de később komoly problémákat okozhatnak.
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
