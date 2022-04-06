/*--------------------VARIABILI--------------------*/
int numeroPartecipanti = 10;
string[] nomi = new string[numeroPartecipanti];
string[] cognomi = new string[numeroPartecipanti]; 
int[] eta = new int[numeroPartecipanti];

/*--------------------FUNZIONI--------------------*/
void StampaArrayDiStringhe(string[] arrayDiStringhe)
{
    Console.Write("[");
    for (int i = 0; i < arrayDiStringhe.Length - 1 ; i++)
    {
        Console.Write(arrayDiStringhe[i] + ", ");
    }
    Console.WriteLine(arrayDiStringhe[arrayDiStringhe.Length - 1] + "]");
}

void StampaEtaAlunni(int[] arrayDiInteri)
{
    Console.Write("[");
    for (int i = 0; i < arrayDiInteri.Length - 1; i++)
    {
        Console.Write(arrayDiInteri[i] + ", ");
    }
    Console.WriteLine(arrayDiInteri[arrayDiInteri.Length - 1] + "]");
}
