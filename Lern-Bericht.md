# Lern-Bericht
Joel Haldimann

## Einleitung

Wir mussten ein Zahlenratespiel programmieren.

## Was habe ich gelernt?

Ich habe gelernt wie und wo man try/catch einsetzt.

## Beschreibung

Mit Try/Catch kann man das Abstürzen eines Programmes verhindern,
z.B. wenn man statt einer Zahl Buchstaben eingibt würde das Programm normalerweise abstürtzen,
aber mit Try/Catch kann dies verhindert werden und es kann etwas anderes ausgegeben werden um
den Benutzer über seine Fehleingabe zu informieren.

Zum Verständnis hier ein kleines Besipiel
```csharp
int Zahl;
            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein");
                Zahl = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe");
            }
  ```
  Mit diesem Code kann man die das Abstürzen verhindern, wenn man eine Zahl eingibt funktonioniert der Code normal. 
  Aber wenn man Buchstaben eingibt würde dass das Programm zum Abstürzen bringen doch mit Try/Catch passiert das nicht.

Wenn der Code ausgeführt wird sieht das dann so aus.

https://user-images.githubusercontent.com/111045600/191689448-ee9b197e-6f79-4a4b-a57e-848b4129c8ec.mp4

## Verifikation

Man sieht wie Try/Catch funktioniert, wann es zum einsatz kommt, wie man es einsetzen könnte und welchen Code man dafür braucht.

# Reflektion zum Arbeitsprozess
#### Was gut lief.
Das Arbeiten von Zuhause lief sehr gut da ich dort einfacher konzentrieren konnte. Ich war Zuhause viel produktiver, da ich mich weniger ablenken lies.

#### Was schlecht lief

Als ich mit dem Grundgerüst des Codes fertig war, wusste ich nicht mehr genau wo ich weiterarbeiten sollte, da mir der Code eigentlich fertig schien.

**VBV**: 

Ich sollte meine Projektplanung das nächste mal genauer schreiben um zu verhindern, dass wenn ich mit einem Arbeitspaket fertig bin ich nicht mehr genau weiss wo ich jetzt weiterarbeiten soll.
