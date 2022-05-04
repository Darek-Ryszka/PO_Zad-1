# PO_Zadanie_1

Program do zadania w ramach przemiotu Programowanie obiektowe.

Treść zadania:

1. Do wykonania tego zadania konieczne jest wykonanie Ćwiczenie_1 i Ćwiczenie_1_2
2. Dodaj pole "numerRejestracyjny" do klasy "Samochod". Dobierz odpowiedni typ danych.
3. Dodaj parametr numerRejestracyjny_ (string) do konstruktora niedomyślnego klasy "Samochod"
4. Stwórz klasę "Osoba". Obiekty klasy „Osoba” mają przechowywać informacje o posiadanych samochodach w formie ich numerów rejestracyjnych (numery te można przechowywać w tablicy).
Proszę zauważyć, że każda osoba może posiadać maksymalnie 3 samochody.
5. Dodaj pola imie, nazwisko, adresZamieszkania i iloscSamochodow = 0 do klasy "Samochod". Dobierz odpowiednie typy danych.
6. Stwórz konstruktor domyślny który będzie przypisywał wartości "nieznany"/"nieznana" dla łancuchów tekstowych i 0 dla liczb.
7. Stwórz konstruktor przyjmujący jako parametry imie_, nazwisko_, adres_, iloscSamochodow_ i przypisujący wartości do pól.
8. Stwórz metodę "DodajSamochod" która będzie przyjmować nrRejestracyjny (string) jako parametr i nie będzie zwracać żadnej wartości.
Metoda ma dodawać numer rejestracyjny do kolekcji numerów rejestracyjnych (tabeli) w obiekcie typu „Osoba”.
Przy wywołaniu tej metody należy pamiętać o sprawdzeniu czy osoba może posiadać kolejny samochód oraz o zwiększeniu licznika posiadanych samochodów po dodaniu numeru rejestracyjnego.
9. Stwórz metodę "UsunSamochod" która będzie przyjmować nrRejestracyjny (string) jako parametr i nie będzie zwracać żadnej wartości.
Metoda ma usuwać numer rejestracyjny podany jako parametr z kolekcji numerów rejestracyjnych (tabeli) w obiekcie typu „Osoba”.
Operację tę można zaimplementować z wykorzystaniem pętli „for”. Usuwanie ma polegać na przyporządkowaniu danej pozycji w kolekcji wartości „null”.
Przy wywołaniu tej metody należy pamiętać o zmniejszeniu licznika posiadanych samochodów po usunięciu numeru rejestracyjnego
10. Stwórz metodę "WypiszInfo" która nie będzie przyjmować żadnych parametrów i zwracać wartości.
Metoda ma wypisywać informacje o osobie oraz numery rejestracyjne posiadanych przez nią samochodów.
11. Zabronuj kod testujący nową klasę
