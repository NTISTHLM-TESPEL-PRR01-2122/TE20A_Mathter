
Mathter();

static void Mathter()
{
  int correctNum = 7;
  int points = 0;
  Console.WriteLine("x * 6 = 42");
  Console.WriteLine("Vad är x?");

  int num = 0;
  bool success = false;

  while (success == false)
  {
    string numGuess = Console.ReadLine();
    success = int.TryParse(numGuess, out num);

    if (success == false)
    {
      Console.WriteLine("Nuh uh uh!");
    }
  }

  if (num != correctNum)
  {
    Console.WriteLine($"Nej, {num} * 6 blir {num * 6}!");

    if (num < correctNum)
    {
      Console.WriteLine("Du gissade för lågt! Klantarsel!");
    }
    else if (num > correctNum)
    {
      Console.WriteLine("Du gissade för högt! DUMMER!");
    }
  }
  if (num == correctNum)
  {
    Console.WriteLine("YESSSSS");
    points++;
  }

  // Console.WriteLine(num * 2);


  Console.ReadLine();

}