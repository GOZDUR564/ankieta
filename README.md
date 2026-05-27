# Ankieta Motoryzacyjna - WPF

Aplikacja WPF do przeprowadzania ankiety na temat motoryzacji.

## 🚗 Funkcjonalności

✅ **Ankieta motoryzacyjna** z 7 sekcjami  
✅ **Formatowanie** - piękne kolory, marginesy, style  
✅ **Pola formularza**:
- TextBox (imię, email, rok produkcji)
- ComboBox (marka samochodu)
- RadioButton (typ paliwa)
- CheckBox (wyposażenie bezpieczeństwa)
- Slider (ocena zadowolenia 1-10)
- DatePicker (data przeglądu)

✅ **Przycisk "Wyczyść"** - kasuje całą zawartość (czerwony)  
✅ **Przycisk "Zatwierdź"** - walidacja i wyświetlenie wyników (zielony)  
✅ **Okno wyników** - podsumowanie z przyciskiem kopiowania  
✅ **Responsywne** - ScrollViewer dla dużych ekranów  

## 📋 Struktura projektu

```
ankieta/
├── ankieta.csproj
├── App.xaml
├── App.xaml.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── ResultWindow.xaml
├── ResultWindow.xaml.cs
└── README.md
```

## 🚀 Jak uruchomić

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/GOZDUR564/ankieta.git
   cd ankieta
   ```

2. Otwórz projekt w Visual Studio

3. Skompiluj i uruchom (F5)

## 📝 Wymagania

- .NET 6.0 lub wyżej
- Visual Studio 2022 (lub Visual Studio Code z rozszerzeniem C#)

## 🎨 Funkcjonalności przycisków

### Wyczyść
- Kasuje zawartość wszystkich pól
- Resetuje CheckBoxy, RadioButtony i Slider
- Wyświetla potwierdzenie

### Zatwierdź
- Waliduje pola obowiązkowe
- Wyświetla podsumowanie wyborów
- Pozwala skopiować wyniki do schowka

## 📧 Kontakt

Projekt stworzony dla GOZDUR564