# Követelmény specifikáció

## 1. Áttekintés
Az alkalmazás célja, egy olyan butított számológép létrehozása mely képes az alap számítások elvégzésére, ezen felül rendelkezik egy külön valutaátváltó funkcióval is. C# nyelven Windows Forms alkalmazásként lesz elkészítve. A számolás eredménye egy textboxban fog megjelenni.A textboxban lévő számokhoz a USER nem fog tudni hozzáérni,csak a különböző gombokkal lehet használni majd a gépet.
## 2. A jelenlegi helyzet leírása
A megrendelő egy iskola, amely nincs megelégedve jelenlegi tanítási módszereikkel,ezért szeretnének egy butított,de hibátlan számológép alkalmzaást matematika órákra,és földrajz órákra amelyek segíthetik őtet az órái munka során. A számológépnek képesnek kell lennie valutaátváltásra is, amit főként földrajz órához szeretnének használni.
## 3. Vágyálomrendszer
A projekt célja egy olyan butított számológép,amely megkönnyíti a használók módját az egyszerű és átlátható felületével.Csak gombokkal lehet kezelni majd az alkalmazást.Az alkalmazásban alapvető számolásokat lehet végezni,egy másik fülben pedig a valutaátváltás lesz elérhető.
## 4. Jelenlegi üzleti folyamatok modellje
Manuális számolás minden órán, ami monoton a diákok és tanárok számára is.
## 5. Igényelt üzleti folyamatok modellje
Egy könnyen értelmezhető és gyors lebutított számológép biztosítása, ami felgyorsítja a számolások idejét és megkönnyíti a tanárok mindennapi munkáját.Felhasználói funkció - A felhasználó amikor igénye van rá, elindítja az alkalmazást majd a megfelelő fülbe lép. Ezután feltudja vinni gombok segítségével az adott számokat/számításokat, majd az eredmény gomb megnyomása után eredményt kap.
## 6. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| 1     | Felület       | Eredmény kiírása | Kiírja a műveletek eredményt.                                      |
| 2     | Felület       | Számok 0-9       | A felhasználó ezen gombok megnyomásával tudja bevinni a számokat   |
| 3     | Modifikáció   | Összeadás        | A felhasználó által megadott értékek összeadása.                   |
| 4     | Modifikáció   | Kivonás          | A felhasználó által megadott értékek kivonása.                     |
| 5     | Modifikáció   | Százalék         | A felhasználó álltal beírt számnak egy bizonyos százalékát írja ki |
| 6     | Modifikáció   | Euróra váltás    | A kiszámolt összeg átváltása euróra.                               |
| 7     | Modifikáció   | Dollárra váltás  | A kiszámolt összeg átváltása amerikai dollárra.                    |
| 8     | Modifikáció   | Szorzás          | A felhasználó által megadott értékek szorzása.                     |
| 9     | Modifikáció   | Osztás           | A felhasználó által megadott értékek osztása.                      |
| 10    | Modifikáció   | Reciprok         | A felhasználó által megadott szám reciprokának kiszámítása.        |
| 11    | Modifikáció   | Szinusz          | A felhasználó által megadott szám szinuszának kiszámítása.         |
| 12    | Modifikáció   | Koszinusz        | A felhasználó által megadott szám koszinuszának kiszámítása.       |
| 13    | Modifikáció   | Négyzetgyök      | A felhasználó által megadott érték négyzetgyökének kiszámítása.    |
| 14    | Modifikáció   | Négyzetre emelés | A felhasználó által megadott érték négyzetre emelése.              |
| 15    | Modifikáció   | n-edik hatvány   | A felhasználó által megadott egész szám n-edik hatványra emelése.  |
| 16    | Modifikáció   | Előjel váltás    | A felhasználó által megadott szám előjelének megváltoztatása.      |



## 7. Fogalomtár
Textbox - Szövegdoboz
USER - Felhasználó

