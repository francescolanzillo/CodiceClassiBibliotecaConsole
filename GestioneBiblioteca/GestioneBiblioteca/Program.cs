// See https://aka.ms/new-console-template for more information
using GestioneBiblioteca;

Console.WriteLine("Gesione biblioteca");

Console.WriteLine("Inserimento libri");

Console.Write("inserisci il titolo:");

Libro[] biblioteca = new Libro[500];
int indice = 0;

bool continua= true;
while(continua )
{

    //sintassi di creazione di un oggetto 
    //da una classe
Libro oggettoLibro = new Libro();

    oggettoLibro.Titolo=Console.ReadLine();
    Console.Write("inserisci l'autore");
    oggettoLibro.Autore =Console.ReadLine();
    Console.Write("inserisci il numero di pagine:");
    oggettoLibro.Pagine= int.Parse(Console.ReadLine());
    Console.Write("inserisci il prezzo");
    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());
    Console.WriteLine("il prezzo in dollari sarà:" + oggettoLibro.PrezzoInDollari());

    biblioteca[indice] = oggettoLibro;
    indice++;

    Console.WriteLine("Vuoi inserire un altro libro (S/N)?");
    string risposta= Console.ReadLine();
    if (risposta == "N")
    {
        continua = false;
    }
}


