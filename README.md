*Program itself is in Czech, but code and comments there are in English. Below is programmers' documentation in English.* 

# DBioPhoto - Uživatelé

Jednoduchý Winforms program, který umožňuje vytvořit lokální databázový soubor,
do něj uložit fotky s popisky a organismy/lidmi nacházejícími se na fotce a následně v databázi 
vyhledávat. Všechna textová pole mají jednoduché napovídání.

## Vytvoření databáze
Databázi lze vytvořit přímo v programu na zvoleném místě. Používán je soubor `.mdf` 
spolu s `.ldf` logem.

## Ukládání do databáze
### Ukládání fotek
Při pridávání fotek je možné zvolit složku ve stejném adresáři jako je databázový 
soubor, nebo v nějakém z podadresářu. Všechny fotky `.jpg`, `.jpeg` a `.png` jsou
zobrazeny. Při kliknutí na fotku je zobrazena ve větším spolu s údaji, zda již je v databázi, 
absolutní i relativní cesta k ní a datum pořízení. Je možnost doplnit Kategorii, Místo pořízení 
a Poznámku (ani jedno není povinné). Fotku společně s tětmito údaji lze následně uložit 
do databáze. Pokud fotka již v databázi je, uložení údaje u ní aktualizuje.

Do databáze není uložena přímo fotka, ale pouze relativní cesta k ní, ze které jde fotku 
při hledání znovu načíst. Díky tomu, že je uložena jen relativní cesta (a ne absolutní), lze 
celou složku, ve které je databázový soubor, přesunout do jiného umístění (případně na jiný 
počítač), a databáze se neporuší.

Dále je možnost k fotce v databázi přiřadit organismy a lidi. Tyto musí před přiřazením k fotce 
již být v databázi a je potřeba je zvolit z napovídaných možností. Cokoliv přidaného k fotce je 
zobrazeno a je možno to od fotky odebrat.

### Přidávání organismů do databáze
Ve speciálním okně. Je nutno zvolit typ organismu a vyplnit český a latinský rodový název. 
Vyplnění druhových názvů je dobrovolné, avšak očekávané.

### Přidávání lidí do databáze
Ve speciálním okně. Je nutno vyplnit jméno a příjmení, vyplnění přezdívky je dobrovolné.

## Vyhledávání v databázi
Při vyhledávání je nutno zvolit časový úsek, ve kterém měly být fotky pořízeny (ale může být libovolně 
dlouhý, tedy může zobrazit všechny fotky). Následně je hledat dle Kategorie fotky, Místa a Poznámky.
Dále je možno zvolit jednu z možností Český/Latinský název organismu, Jméno osoby nebo Typ a barva 
organismu. Budou vyhledány jen fotky, ke kterým je přiřazen hledaný organismus/osoba/typ organismu dané 
barvy. U organismů je při hledání požadován rodový název (druhový je dobrovolný), u osob jméno a příjmení 
(přezdívka je dobrovolná). V případě zvolení možnosti Typ a barva organismu je nutno zvolit typ i barvu.


# DBioPhoto - programmers

Main frameworks used are `Winforms`, `Entity Framework Core` and `Linq`.

## DBioPhoto.Domain
This project was intended for models, in the end contains a single namespace `Models`.

### DBioPhoto.Domain.Models
In `Models` are three main classes - `Photo`, `Organism` and `Person` with all neccessary properties.

## DBioPhoto.DataAccess
This project is for the creation and communication with the database.

### DBioPhoto.DataAccess.Data
Contains a single class `DBioPhotoContext`, which inherits from `DbContext`. This class creates 
the context for communication with the database. At the beginning the database tables are
created through this context using the `Models`.

### DBioPhoto.DataAccess.Services
Functions for communication with the database using the `DbContext`. Two main folders are `Adding` 
and `Filtering`. All the functions use `DbContext` and `Linq` to make queries on it, returning the result
(if the operation was successfull) when adding, and queried objects when searching.

## DBioPhoto.Frontend
There are all the forms and the main executable program in this project. In the main program are 
two "global variables" `RootFolder` and `DbFilePath` which all the forms need. 

When loading images, `Backgroundworkers` are used to load them asynchronously (because it's I/O 
heavy operation), so the UI doesn't freeze. When creating the "folder-like" view of the pictures, 
only thumbnails 120x90 are loaded into the RAM and the high resolution image is loaded only 
when viewing that particular photo.

Each form creates a few `DbContexts` for its need and disposes them on closing. Whenever the form 
communicates with the database, the function is called in `Task.Run()` to submit the task into the 
threadpool, where other thread can resolve it, again leaving the main thread for the UI. The particular used
`DbContext` is always locked, so no other thread could use it at the same time (`DbContexts` support 
only one operation at once and are not thread safe). These tasks sometimes `Invoke()` other function 
on the main thread again, because the form controls can't be accessed from thread different than created them.

All the `TextBoxes`in forms support autocomplete function in `Suggest` mode. The collection of strings 
is loaded from the database on `KeyUp` event when there are three characters in given `TextBox`. 
Unfortunately when the collection is updated, the suggestions aren't showed, so they appear only after 
typing another character (or deleting one).
