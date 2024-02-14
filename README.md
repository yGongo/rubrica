###Rubrica Telefonica App
Cos'è questa roba?
Questa è una piccola app di rubrica telefonica che ho creato per tenermi organizzato. Sai, per tenere traccia dei numeri e delle persone a cui chiamare. È scritta in C# e fa uso del WPF (Windows Presentation Foundation).

Come farla funzionare
Prima di tutto, assicurati di avere i file Persone.csv e Contatti.csv nella stessa cartella dell'app. Quindi, avvia l'applicazione e vedrai apparire una bella tabella con i tuoi contatti. Seleziona uno di loro e vedrai apparire una seconda tabella con tutte le persone associate a quel contatto.

Che casino c'è nel codice?
Il cuore pulsante di questa roba si trova nel file MainWindow.xaml.cs. È lì che ho messo insieme il codice per caricare i dati dai file CSV, gestire i cambiamenti nelle righe delle tabelle e filtrare le persone associate ai contatti.

Che roba è nei file CSV?
Ah, i file CSV! Sono quei file che contengono tutti i dati dei tuoi contatti. Nel file Persone.csv, ogni riga ha l'ID della persona, il ruolo e il nome. Nel file Contatti.csv, ogni riga ha il numero di telefono, il tipo e il nome del contatto.

Cos'altro devo sapere?
Niente di particolare! L'app non ha bisogno di nient'altro se non il buon vecchio .NET Framework per funzionare.
