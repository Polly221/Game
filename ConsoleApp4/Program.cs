using System.Text;
Console.Write("Введите слово: ");
string slovo = Console.ReadLine();
Console.Clear();
string ugadslovo = "";
string bukvi = "";
int sch = 0;
int kolvobukv = slovo.Length;
int procent100 = kolvobukv % 100;
int procent10 = kolvobukv % 10;

if (procent100 >= 10 && procent100 <= 20)
{
    bukvi = "букв";
}
else if (procent10 == 1)
{
    bukvi = "буква";
}
else if (procent10 >= 2 && procent10 <= 4)
{
    bukvi = "буквы";
}
else if (procent10 >= 5 && procent10 <= 9 || procent10 == 0)
{
    bukvi = "букв";
}

StringBuilder finalslovo = new StringBuilder();
for (int i = 0; i < slovo.Length; i++)
{
    finalslovo.Append('*');
}

int kolvopopitok = 7;

Console.WriteLine($"**********************************************************************************");
Console.WriteLine();
Console.WriteLine($"Попробуйте отгадать слово!\tСлово: {finalslovo}\tВ слове {kolvobukv} {bukvi}!");
Console.WriteLine();

while (kolvopopitok != 0 || Convert.ToString(finalslovo) == slovo)
{
    Console.Write($"Введите букву! ");
    ugadslovo = Console.ReadLine();

    for (int j = 0; j < slovo.Length; j++)
    {
        if (ugadslovo == Convert.ToString(slovo[j]))
        {
            if (finalslovo[j] != '*')
            {
                Console.WriteLine("Такая буква уже есть!");
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Вы отгадали {j + 1} букву!");
                Console.WriteLine();
                finalslovo[j] = slovo[j];
                Console.WriteLine(finalslovo);
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************");
                Console.WriteLine();
            }
        }

        if (ugadslovo != Convert.ToString(slovo[j]))
        {
            sch += 1;
        }

        if (sch == kolvobukv)
        {
            kolvopopitok--;
            Console.WriteLine();
            Console.WriteLine($"Вы не отгадали букву!\tУ вас осталось {kolvopopitok} попыток");
            Console.WriteLine();
            Console.WriteLine(finalslovo);
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
            }
        }    switch (kolvopopitok)
    {
        case 6:
            Console.WriteLine(
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n"
              );
            break;
        case 5:
            Console.WriteLine(
             "Г-----    \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n"
              );
            break;
        case 4:
            Console.WriteLine(
             "Г-----    \n" +
             "|     |   \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" +
             "|         \n"
              );
            break;
        case 3:
            Console.WriteLine(
             "Г-----    \n" +
             "|     |   \n" +
             "|     О   \n" +
             "|         \n" +
             "|         \n" +
             "|         \n" 
              );
            break;
        case 2:
            Console.WriteLine(
             "Г-----    \n" +
             "|     |   \n" +
             "|     О   \n" +
             "|     |   \n" +
             "|         \n" +
             "|         \n"
              );
            break;
        case 1:
            Console.WriteLine(
             "Г-----    \n" +
             "|     |   \n" +
             "|     О   \n" +
             "|    /|\\ \n" +
             "|         \n" +
             "|         \n"
              );
            break;
        case 0:
            Console.WriteLine(
             "Г-----    \n" +
             "|     |   \n" +
             "|     О   \n" +
             "|    /|\\ \n" +
             "|    / \\ \n" +
             "|         \n"
              );
            break;

    }
    sch = 0;

        if (kolvopopitok == 0)
        {
            Console.WriteLine("Game over!!!Увы, но вы его не спасли((");
            break;
        }

        if (Convert.ToString(finalslovo) == slovo)
        {
            Console.WriteLine("Вы отгадали слово!Поздравляю!!!!!Вы спасли человечка)))");
            break;
        }
    }