# Dziennik lekcyjny

Niniejszy program jest projektem studenckim na zaliczenie ćwiczeń z przedmiotu
"Inżynieria oprogramowania".

Wykonali: [Łukasz Węgrzynkiewicz][1], [Wojciech Nosal][2]

## Badanie problemu

Placówka dydaktyczna potrzebuje programu komputerowego, który usprawni:
 * prowadzenie zajęć lekcyjnych przez kadrę dydaktyczną
 * dostęp dla ucznów do wystawionych ocen
 * informowanie opiekunów o postępach w nauce ich podopiecznych
 * archiwizacji przeprowadzonych zajęć lekcyjnych

## Charakterystyka projektu

Program "Dziennik lekcyjny" wspiera w prowadzeniu, archiwizacji i propagowaniu
zdarzeń zachodzących podczas zajęć dydaktycznych dla uczniów klas podstawowych, 
gimnazjalnych i ponadgimnazjalnych.

## Scenariusze przypadków użycia

Zarządca:
 * Zarządza uczniami
 * Zarządza nauczycielami
 * Zarządza klasami
 * Przyporządkowuje uczniów do klas
 * Zarządza rodzicami uczniów
 * Może zalogować się do systemu za pomocą indywidualnego loginu i hasła
 * [opcjonalnie] Zarządza planem lekcji 

Uczeń:
 * Przynależy do klasy i jest o tym poinformowany
 * Posiada unikalny numer w obrębie klasy
 * Posiada wgląd do swoich ocen
 * Posiada wgląd do swoich zbliżających się sprawdzianów
 * Posiada wgląd do swoich uwag
 * Posiada wgląd do swoich obecności
 * Sprawdza średnią ocen z przedmiotu i średnią semestralną
 * Może zalogować się do systemu za pomocą indywidualnego loginu i hasła
 * [opcjonalnie] Posiada wgląd do danych nauczycieli
 * [opcjonalnie] Posiada wgląd do planu lekcji każdej klasy

Nauczyciel:
 * Posiada wgląd do danych wszystkich uczniów
 * Zarządza swoimi lekcjami
 * Zarządza swoimi uwagami
 * Odnotowuje obecność uczniów na zajęciach
 * Wystawia oceny uczniom za aktywności
 * Organizuje sprawdziany
 * Może prowadzić lekcje z wielu przedmiotów
 * Może zalogować się do systemu za pomocą indywidualnego loginu i hasła
 * [opcjonalnie] Posiada wgląd do planu lekcji każdej klasy

Rodzic:
 * Posiada dzieci(uczniów) i jest o tym poinformowany
 * Posiada wgląd do ocen swoich dzieci(uczniów)
 * Posiada wgląd do uwag swoich dzieci(uczniów)
 * Posiada wgląd do zbliżających się aktywności swoich dzieci(uczniów) 
 * Posiada wgląd do obecności swoich dzieci(uczniów) 
 * Może zalogować się do systemu za pomocą indywidualnego loginu i hasła
 * [opcjonalnie] Posiada wgląd do danych nauczycieli
  
### Relacje 

Klasa:
 * Zawiera dowolną naturalną liczbę uczniów 
 * [opcjonalnie] Posiada wychowawcę będącego nauczycielem

Przedmiot:
 * Jest unikalny

Lekcja:
 * Posiada temat lekcji
 * Posiada datę
 * Jest przypisana do nauczyciela
 * Jest przypisana do przedmiotu
 * Jest przypisana do klasy

Obecność:
 * Przyjmuje jedną wartość: obecny, nieobecny, spóźniony, usprawiedliwiony
 * Jest przypisana do ucznia
 * Jest przypisana do lekcji

Aktywność:
 * Posiada nazwę
 * Jest organizowana przez jednego nauczyciela
 * Jest przypisana do lekcji
 * Jest przypisana do klasy
    
Ocena:
 * Przyjmuje wartość od 1 do 6 włącznie
 * Jest przypisana do aktywności
 * Jest przypisana do ucznia
 * [opcjonalnie] Może zostać poprawiona
 
### Pozostałe
  
_Przez słowo "zarządza" rozumiemy: tworzenie, modyfikowanie i usuwanie._

[1]:https://github.com/wegrzynkiewicz
[2]:https://github.com/WojtekNosal