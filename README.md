# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
(u redak iznad navedite kratki proizvoljni naziv projekta prikladan akademskoj zajednici, a ovaj tekst obrišite)

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Dominik Faletar|dfaletar@foi.hr|0016139082|dfaleta
Martin Ferenđa|mferenda@foi.hr|0016135452|MartinFerenda
Viktor Kapelina|vkapelina@foi.hr|0036463697|VKapaPI



## Opis domene
Aplikacija je zamišljena na način da omogući jednostavnije poslovanje auto kuće, prvenstveno zbog potrebe preglednijeg prikaza rada pojedinih odjela. Također, korisnik jednostavno može pregledati i zatražiti usluge odjela auto kuće kao što su ponuda automobila, servis, zamjena guma i autopraonica. Korisniku je dostupan i pregled povijesti korištenih usluga. Svrha korištenja aplikacije od strane korisnika je olakšati pregled i pronalazak usluga auto kuće, umjesto tradicionalnog kontaktiranja telefonom.
## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup dnevniku potrebnba je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... | Zlatko Stapić
F02|Pregled novih autiju|Korisnik ima pregled ponude autiju od autokoče. Nakon odabira auta prikazuje mu lokaciju gdje može kupiti ili isprobati željeni auto.|
F03|Pregled lokacija servisa|Pruža mogućnost korisniku da pronađe lokaciju blizu sebe kako bi servisirao auto|
F04|Prijava kvara|Omogućuje prijavu kvara kako bi se pružila pomoć vozaću u što kraćem roku|
F05|Dogovor termina predaje vozila|Dopušta bukiranje termina predaje vozila na servis te termina test vožnje novih vozila|
F06|Pregled stanja svojeg vozila u servisu|Uvid u stanje svojeg vozila koje je na servisu te očekivano vrijeme servisiranja|
F07|Pregled povijesti racuna|Pregled plačenih računa kod Autokuče|
F08|Pregled statistike|Prikaz statistike vezane za kupce,aute i dijelove|
F09|Zamjena guma|Omogučuje korisniku da dogovori termin zamjene guma|
F10|Skladistenje Zimskih/Ljetnih guma|Vodi evidenciju kopuaca i njihovih guma koje su na čuvanju u Autokući|
F11|Azuriranje popisa novih automobila|Admin može ažurirati popis novih vozila|
F12|Azuriranje popisa auto dijelova|Admin može ažrirati i proširiti popis autodijelova|
F13|Prikaz i unos odataka o servisu|Zaposlenici ažuriraju stanje vozila kako bi kupac imao trenutne informacije o svojem vozilu.|
F14|Usluge autopraone|Pregled ponude autopraone. Pregled slobodnih termina autopraone i bukiranje istih. Prikaz skupljenih bodova radiostvarivanje pousta u autopraoni.|

## Tehnologije i oprema
Microsoft Visual Studio 2019, MS SQL Server, Visual Paradigm, Draw.io, Excel
