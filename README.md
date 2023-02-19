# Aplikacja internetowa eGameShop 

Sklep internetowy umożliwiający zakup gier dla użytkowników kórzy posiadają konto. Administrator aplikacji posiada możliwość dodawania nowych gier, zmieniana parametrów już istniejących oraz dodawania/usuwania/zmieniana istniejących obiektów w bazie danych, między innymi: Producentów, Platform, Wydawców.

Aplikacja napisana w języku C# (ASP.NET MVC). 

**Użyte pakiety:**

![image](https://user-images.githubusercontent.com/91788789/219944004-f25d2c69-d1b9-443d-a32c-1ac2a5c23677.png)

# Instalacja i uruchomienie aplkacji

1) Ściągnąć repozytorium:  https://github.com/pawelmajkut/eGameShop.git
2) Uruchomić w Visual Studio - skompilować. (Visual Studio użyty do stworzenia projektu: Visual Studio 2022 (64-bitowy)) 
3) W plikach projektu zmienić "nakierowanie" na bazę (edycja pliku appsettings.json): 

![image](https://user-images.githubusercontent.com/91788789/219944162-663cf37b-d005-4590-a351-738db3a3618c.png)

**"DefaultConnectionString": " Data Source=NAZWA_KOMPUTERA\\SQLEXPRESS;Initial Catalog=eGameShop;TrustServerCertificate=True;Integrated Security=True;Pooling=False"**

# Zaimplementowane funkcjonalności:
- dodawanie kont użytkowników
- przegląd gier bez logowania 
- logowanie użytkownika oraz admina 
- możliwość zakupu gier użytkownikowi zalogowanemu 
- podsumowanie zrealizowanych zamówień 
- przegląd użytkowników/kont dla admina




