using System.ComponentModel.Design;
using System.Security.AccessControl;
using System.Threading.Channels;
int proby = 0;
Console.WriteLine("==REJESTRACJA==");
Console.WriteLine("Podaj login:");
string login = Console.ReadLine()!;
Console.WriteLine("Podaj hasło:");
string haslo = Console.ReadLine()!;
Console.WriteLine("Rejestracja zakończona.");
Console.WriteLine("==Logowanie==");
Console.WriteLine("Prosze o ponowne wpisanie loginu i hasła:");
bool zalogowany = false;
bool programdz = true;
int wybor = 0;
while(programdz == true)
{
    while (proby < 3)
    {
        Console.WriteLine("próby" + proby);
        Console.WriteLine("Login");
        string login2 = Console.ReadLine()!;
        Console.WriteLine("hasło");
        string hasło2 = Console.ReadLine()!;
        if (login == login2 && haslo == hasło2)
        {
            Console.WriteLine("Poprawnie zalogowany");
            zalogowany = true;
            break;




        }

        else
        {
            Console.WriteLine("Nie udało ci się. ");
            proby++;

            if (proby == 3)
            {
                Console.WriteLine("Konto zablokowane!");
                break;
            }
        }

    }
    if (zalogowany == true)
    {
        while (wybor != 4 && zalogowany == true)
        {


            Console.WriteLine("===MENU UŻYTKOWNIKA===");
            Console.WriteLine("1. Wyswietl nazwe użytkownika");
            Console.WriteLine("2. Zmień hasło");
            Console.WriteLine("3. Wyloguj się");
            Console.WriteLine("4. Zakończ program");
            Console.WriteLine("wybierz opcje");
            int.TryParse(Console.ReadLine(), out wybor);
            switch (wybor)
            {
                default:
                    Console.WriteLine("to nie jest liczba");
                    break;
                case 1:
                    Console.WriteLine(login);
                    break;
                case 2:
                    Console.WriteLine("Podaj stare hasło");
                    string starehaslo = Console.ReadLine()!;
                    if (starehaslo == haslo)
                    {
                        Console.WriteLine("Poprawne");
                        Console.WriteLine("Podaj nowe hasło");
                        haslo = Console.ReadLine()!;
                        Console.WriteLine("hasło zostało zmienione poprawnie");
                    }
                    else
                    {
                        Console.WriteLine("źle wpisane hasło");
                    }

                    break;
                case 3:
                    Console.WriteLine("Pomyślnie wylogowany");
                    zalogowany = false;
                    break;
                case 4:
                    proby = 0;
                    programdz = false;

                    break;
            }
        }
    }

}