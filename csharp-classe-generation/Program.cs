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
