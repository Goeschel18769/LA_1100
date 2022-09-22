# Projekt-Dokumentation


Haldimann Joel

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 08.09.2022| 0.0.1| Die App kann jetzt Zahlen generieren und man kann Zahlen raten. |
| 08.09.2022| 0.0.2 | Die App sagt nun ob die eingegebene Zahl grösser oder kleiner als die gesuchte Zahl ist. |
| 15.09.2022|0.1.3| Die App kann jetzt mit fehlereingaben umgehen. |
| 15.09.2022|0.2.3| Das Spiel kann jetzt mehrfach nacheinander gespielt werden. |
| 15.09.2022|1.0.0| Die App antwortet jetzt auf unterschiedliche Inputs mit unterschiedlichen Faben.|

                                                            
## 1 Informieren

### 1.1 Ihr Projekt

Ich programmiere ein Zahlenratespiel.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Funktional | muss | Als ein Computer möchte ich eine zufällige Zahl zwischen 1 und 100 generieren, damit der Speieler diese erraten kann |
| 2    | Funktional | muss | Als ein Spieler möchte ich eine Zahl raten können, damit ich die gesuchte zahl finden kann. |
| 3    | Qualität | kann | Als Speieler möchte ich wissen ob meine Zahl kleiner als die gesuchte Zahl ist, um sie einfacher zu finden. |
| 4    | Qualität | kann | Als Speieler möchte ich wissen ob meine Zahl grösser als die gesuchte Zahl ist, um sie einfacher zu finden. |
| 5    | Funktional| muss | Als Spieler möchte ich wissen ob ich die Zahl erraten habe, damit ich weiss ob das Spiel vorbei ist. |
| 6    | Qualität | kann | Als Spieler möchte ich wissen wie viele Versuche ich hatte, damit ich weiss wie gut ich war.|
| 7    | Funktionl | muss | Als Computer möchte ich mit Fehleingaben ungehen können, damit das Spiel weitergehen kann. |
| 8    | Qualität  | kann | Als Spieler möchte ich das Spiel mehrfach spielen können |
| 9    | Qualität  | kann | Als Spieler möchte ich farbige Texts haben, da es das Spiel schöner macht. |
## 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1. |Ich habe den Code für die Zahlengeneation geschreiebn| Console.Write(GeheimeZahl)| Eine zufällig generierte Zahl.|
| 2. | Ich habe den Code für das Erraten der Zahlen| Eine Zahl in das Feld eingeben. | Man kann die Zahl in das Feld schreiben. |
| 3.| Ich habe den Code für das Erkennen ob die geratene Zahl kleiner als die gesuchte Zahl ist. | Ich gebe eine Zahl unter 0 ein| Das Programm sagt mir das meine  Zahl zu tief war. |
| 4. | Ich habe den Code für das Erkennen ob die geratene Zahl grösser als die gesuchte Zahl ist. | Ich gebe eine Zahl die grösser als 100 ist ein| Das Programm sagt mir, dass meine Zahl zu gross ist. |
| 5. |Ich habe den Code um herauszufinden ob meine Zahl die gesuchte Zahl ist.| Ich gebe eine Zahl ein. | Die Antowrt wird als Richtig angezeigt oder die Zahl wird als falsch angezeigt. |
| 6. | Ich habe den Code um zu wissen wie viel Versuch ich hatte. | Ich gebe eine Antwort. | Der Coutner erhöt sich um 1.|
| 7. | Ich habe den Code damit der Computer mit fehleingaben umgehen kann| Ich gebe ein Wort ein. | Die Eingabe wird gelöscht und nicht als Versuch gespeichert. |
| 8. | Ich habe den Code geschrieben, dass man das Spiel mehrfach am Stück spielen kann. | Am Ende die Frage ob man nochmal spielen will mit True beantworten. | Das spiel startet wieder von vorne.
| 9.| Ich habe den Code für die unterschiedlichen Textfarben | Ich spiele das Spiel | Die Schriftfarbe ändert sich bein unterschiedlichen Antworten. |



### 1.4 Diagramme

<img width="437" alt="Pap" src="https://user-images.githubusercontent.com/111045600/186599808-eaae3af1-f4f7-4ebe-a90a-7b48aac18cbf.png">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.   | 2.09.22 | Joel | Zahlen generieren können | 1 Lektionen|
| 2.   | 9.09.22 | Joel | Zahlen raten können| 3 Lektionen|
| 3.   | 9.09.22 | Joel | Wissen ob Zahl zu klein ist | 1 Lektionen |
| 4.   | 15.09.22 | Joel | Wissen ob Zahl zu gross ist| 1 Lektionen |
| 5.   | 15.09.22 | Joel | Wissen ob Zahl richtig ist | 1 Lektion |
| 6.   | 15.09.22 | Joel | Wissen wie viele Versuche man hatte | 2 Lektionen |
| 7.   | 22.09.22 | Joel | Mit Fehlanzeigen umgehen können | 3 Lektionen |
| 8.   | 22.09.22 | Joel | Das Spiel mehrfach nacheinander Spielen können. | 1 Lektionen |
| 9.   | 22.09.22 | Joel | Textfarben bei Antworten anpassen| 2 Lektionen |


Total: 15 Lektionen

## 3 Entscheiden

Ich habe mich dazu entschieden die Textfarben zu ändern, da so das Spiel viel schöner aussiet.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1  | 1.09.2022 | Joel Haldimann | 45min.| 15min. |
| 2  |1.09.2022| Joel Haldimann | 135min. | 105min.|
| 3  |1.09.2022 | Joel Haldimann | 45min. | 20min. |
| 4  |1.09.2022 | Joel Haldimann| 45min. | 5min. |
| 5  |1.09.2022 | Joel Haldimann| 45min. | 5min. |
| 6  |8.08.2022 | Joel Haldimann| 90min. | 40min. |
| 7  |8.08.2022 | Joel Haldimann | 135min. | 140min. |
| 8  |15.09.2022| Joel Haldimann | 90min.  | 85min. |
| 9  |15.09.2022| Joel Haldimann | 90min.  | 75min. |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 2.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 3.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 4.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 5.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 6.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 7.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 8.1  | 22.09.2022 | Funktioniert | Joel Haldimann |
| 9.1  | 22.09.2022 | Funktioniert | Joel Haldimann |

Fazit: Ich konnte alles so umsetzen wie ich es wollte und es funktioniert alles.


## 6 Auswerten


