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


