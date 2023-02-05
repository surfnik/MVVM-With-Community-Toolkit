# MVVVM With Community Toolkit

Hier ist mein Versuch die [Tutorials von 42Entwickler](https://www.youtube.com/watch?v=JWCudlf5c4Q&list=PLM9HRfTbb2uuAL82jbSpoQA_rj6f61DY2) unter Verwendung des [CommunityToolkit.Mvvm](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/) umzusetzen.

Ein guter Einstieg zum CommunityToolkit ist [dieses Viedeo von Tech-Nick](https://www.youtube.com/watch?v=onYKewd9b0c&t=9s)
und [dieses hier von Kevin Bost](https://www.youtube.com/watch?v=uVIzK2snugk)

Übersicht der einzelnen Teile:

01. Model - View - Viev-Model Theorie (kein Code)
02. Datenbindung\
*[ObservableObject] [ObservableProperty]*
03. Benachrichtigung (ProprtyChanged)\
*[ObservableProperty] [NotifyPropertyChangedFor(nameof(...))]*
04. Commands und ihre Bindung\
*[RelayCommand(CanExecute = nameof(...))]*
05. CommandParameter / Taschenrechner\
*CommandParameter (im XAML)*
06. ValueConverter
07. Listen binden\
*ObservableCollection*
08. CustomLayout List (bereits in 07 eingebaut)
09. Selektiertes Element (bereits in 07 eingebaut)
10. View Logik vs VievModel\
*MessageBox im Code behind*
11. Styles\
*Styles in der View und in der App.xaml*
12. Styles wiederverwenden\
*Styles in einem ResourceDictionary*
13. Animationen und Styles Trigger
14. Code Wiederverwenden - Linked Files vs. DLLs (kein Code)
15. Auto vs. Stern und virtuelle Pixel (kein Code)
16. Synchron vs. Asynchorn vs. Parallele Programmierung mit C#, WPF und MVVM
17. CSV Datei Laden im Hintergrund und IDisposable mit .net6
18. Animationen - Double vs KeyFrame + Easing Funktionen
19. Listen Filtern/Suchfunktion in WPF bei Tastendruck
20. Ressourcen sparen - Datenbindung verzögern (ist schon in 19 eingearbeitet)
21. Arbeiten mit Fenstern
22. Fenster im View oder im ViewModel öffnen? (kein Code)
23. MessageBoxen / Dialoge mit Rückgabewert (ist schon in der 21 eingebaut)
24. UserControls
25. UserControls Dependency Properties (irgendwas ist bei mir mit dem Binding falsch 🙁. Felersuche erstmal vertagt.)
26. WPF Value Converter - Deep Dive
27. WPF - DataGrid
28. DataGrid & Contextmenu

... More to come
