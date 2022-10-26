//Michelle Malfabon
//Aug 10, 2022

//---------Mini Challenge 3 ------------//

//Description: Declared the variables and printed the questions. User input saved into variables. 
//Converted string into integer
//Name and time were printed using string interpolation. 

//Peer reviewed by: Angelica
//Date: 10/25/22
//Comment: game works well and allows me to replay the game. 

int time;
string wakeUp;
string name;
int playAgain;

void PlayGame()
{
Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("What time did you wake up?");
wakeUp = Console.ReadLine();
time= Convert.ToInt32(wakeUp);
Console.WriteLine($"{name} woke up at {time} o'clock.");
Console.WriteLine("Enter 0 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain == 0)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}
PlayGame();