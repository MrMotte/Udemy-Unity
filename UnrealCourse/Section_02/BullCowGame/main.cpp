#include <iostream>
#include <string>


using namespace std;


void PrintIntro();
void PlayGame();
string GetGuess();
void PrintBack(string);
bool AskToPlayAgain();


int main()
{
	do {
		PrintIntro();
		PlayGame();
	} 
	while (AskToPlayAgain() != false);

	return 0;
}



void PlayGame()
{
	//loop for the number of turns asking for guesses
	constexpr int NUMBER_OF_TURNS = 5;
	for (int i = 1; i <= NUMBER_OF_TURNS; i++)
	{
		string Guess = GetGuess();
		cout << endl;
		PrintBack(Guess);
	}
}

void PrintIntro()
{
	// introduce the game
	constexpr int WORD_LENGTH = 5;
	cout << "Welcome to Bulls and Cows, a fun word game.\n";
	cout << "Can you guess the " << WORD_LENGTH << " letter isogramm I'm thinking of?" << endl << endl;
	return;
}

string GetGuess()
{
	string Guess = "";
	// get a guess from the player
	cout << "Enter your Guess: ";
	getline(cin, Guess);;
	return Guess;
}

void PrintBack(string Guess)
{
	// repeat the guess back to them
	cout << "Your Guess was: " << Guess << endl;
	return;
}

bool AskToPlayAgain()
{
	cout << "Do you want to play again (y/n)?";
	string Response = "";
	getline(cin, Response);

	return (Response[0] == 'Y') || (Response[0] == 'y');
}
