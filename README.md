# Aplikacja internetowa eGameShop 

Sklep internetowy umożliwiający zakup gier dla użytkowników kórzy posiadają konto. Administrator aplikacji posiada możliwość dodawania nowych gier, zmieniana parametrów już istniejących oraz dodawania/usuwania/zmieniana istniejących obiektów w bazie danych, m.in.: Producentów, Platform, Wydawców.

Aplikacja napisana w języku C# (ASP.NET MVC). 

**Użyte pakiety:**

![image](https://user-images.githubusercontent.com/91788789/219944004-f25d2c69-d1b9-443d-a32c-1ac2a5c23677.png)

# Instalacja i uruchomienie aplkacji

1) Ściągnąć repozytorium:  https://github.com/pawelmajkut/eGameShop.git
2) Uruchomić w Visual Studio - skompilować. (Visual Studio użyty do stworzenia projektu: Visual Studio 2022 (64-bitowy)) 
3) W plikach projektu zmienić "nakierowanie" na bazę (edycja pliku appsettings.json): 

![image](https://user-images.githubusercontent.com/91788789/219944162-663cf37b-d005-4590-a351-738db3a3618c.png)

**"DefaultConnectionString": " Data Source=NAZWA_KOMPUTERA\\SQLEXPRESS;Initial Catalog=eGameShop;TrustServerCertificate=True;Integrated Security=True;Pooling=False"**

4) Stworzeni użytkownicy:

Administrator aplikacji: 

LOGIN: admin@game.com

PASSWORD: Game123!@

Uzytkownik standardowy aplikacji: 

LOGIN: user@game.com

PASSWORD: Game123!@


# Zaimplementowane funkcjonalności:
- dodawanie kont użytkowników
- przeglądanie gier bez logowania 
- logowanie użytkownika standardowego i uprzywilejowanego (admina)
- możliwość zakupu gier użytkownikowi zalogowanemu 
- podsumowanie zrealizowanych zamówień 
- przegląd użytkowników/kont dla admina
- wyszukiwanie po słowach kluczowych w opisach oraz po tytułach i kategoriach gry
- zależność pomiędzy statusem gry a możliwością zakupu (tylko gry ze statusem AVAILABE mogą zostać dodane do koszyka)
- dokonanie zamównia/płatność

# Baza danych aplikacji: 

Najważniejsze tabele:

1) **Games** - tabela zawierająca informacje o danej grze oferowanej w sklepie: nazwa, kategoria, cena, opis itp.
2) **Publishers** - tabela zawierająca informacje o wydawcy gry: nazwa, logo, opis
3) **Producers** - tabela zawierająca informacje o producencie gry: nazwa, logo, opis
4) **Platforms** - tabela zawierająca informacje o plaformie na jaką jest dedykowana gra: nazwa, logo, opis
5) **DistributionPlatforms** -tabela zawierająca informacje o platformie która dystrybuuje grę : nazwa, logo, opis
6) **ShoppingCartItems** - tabela zawierająca dane o produktach umieszczonych w koszyku klienta,
7) **Orders** - tabela zawierająca informacje o użytkowniku składającym zamówienie, 
8) **OrdersItems** - tabela zawierająca informacje o złożonych zamówieniach, czyli identyfikator zamówionej gry, ilość kopii, 


![image](https://user-images.githubusercontent.com/91788789/219945354-bf5d3108-f272-43eb-9cc4-17382304a17b.png)



# Wygląd aplikacji:

**Wygląd uruchomionej aplikacji - widok administratora:**

![image](https://user-images.githubusercontent.com/91788789/219944791-26064e46-0ad2-444d-b696-23e46ebb4a80.png)

**Sczegóły wybranej gry:**

![image](https://user-images.githubusercontent.com/91788789/219945039-778931f2-271a-4a30-a5d7-920e734830e2.png)

**Wyszukiwanie gry po nazwie:**

![image](https://user-images.githubusercontent.com/91788789/219945060-ac9357f6-eb3e-4e92-920c-35ad37301123.png)




