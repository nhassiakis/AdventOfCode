using Day_2;
using System.Collections.Generic;
using System.Xml.Linq;

string[] input = new Datalayer().ReadData();


Dictionary<char, string> Rockpaper = new Dictionary<char, string>()
{
    //Part one
    //{'A', "Rock" },
    //{'X', "Rock" },
    //{'B', "Paper" },
    //{'Y', "Paper" },
    //{'C', "Scissors" },
    //{'Z', "Scissors" },

    //part two
    {'A', "Rock" },
    {'B', "Paper" },
    {'C', "Scissors" },
    {'X', "Lose" },
    {'Y', "Draw" },
    {'Z', "Win" },
};

Dictionary<string, int> handScores = new Dictionary<string, int>()
{
    {"Rock", 1 },
    {"Paper", 2 },
    {"Scissors", 3 },
};

// Score for ROCK 1 , Score for Paper 2, Score for Scissor 3
// Score for losing 0, Score for draw 3, score for win 6



int playerScore = 0;


//Part 2
//X means you need to lose, Y means you need to end the round in a draw, and Z means you need to win.
for (int i = 0; i < input.Length; i++)
{
    string currentHands = input[i];
    //string test = Rockpaper.Where(rockPaper => rockPaper.Key.Equals(currentHands[0])).Select(rockpaper => rockpaper.Value);
    string playerOneHand = Rockpaper.GetValueOrDefault(currentHands[0]);
    string playerTwoHands = Rockpaper.GetValueOrDefault(currentHands[2]);

    if (playerTwoHands == "Lose")
    {
        if (playerOneHand == "Rock")
        {
            playerScore += 0;
            playerScore += handScores.GetValueOrDefault("Scissors");
        }
        else if (playerOneHand == "Paper")
        {
            playerScore += 0;
            playerScore += handScores.GetValueOrDefault("Rock");
        }
        else
        {
            playerScore += 0;
            playerScore += handScores.GetValueOrDefault("Paper");
        }
    }
    else if (playerTwoHands == "Win")
    {
        if (playerOneHand == "Rock")
        {
            playerScore += 6;
            playerScore += handScores.GetValueOrDefault("Paper");
        }
        else if (playerOneHand == "Paper")
        {
            playerScore += 6;
            playerScore += handScores.GetValueOrDefault("Scissors");
        }
        else
        {
            playerScore += 6;
            playerScore += handScores.GetValueOrDefault("Rock");
        }
    }
    else
    {
        playerScore += 3;
        playerScore += handScores.GetValueOrDefault(playerOneHand);

    }
}

Console.WriteLine(playerScore);




// Part One!
//for (int i = 0; i < input.Length; i++)
//{
//    string currentHands = input[i];
//    //string test = Rockpaper.Where(rockPaper => rockPaper.Key.Equals(currentHands[0])).Select(rockpaper => rockpaper.Value);
//    string playerOneHand = Rockpaper.GetValueOrDefault(currentHands[0]);
//    string playerTwoHands = Rockpaper.GetValueOrDefault(currentHands[2]);

//    if (playerOneHand == playerTwoHands)
//    {

//        playerScore += 3;
//        playerScore += handScores.GetValueOrDefault(playerTwoHands);

//    }
//    else if ((playerOneHand == "Rock" && playerTwoHands == "Paper") || (playerOneHand == "Paper" && playerTwoHands == "Scissors") || (playerOneHand == "Scissors" && playerTwoHands == "Rock"))
//    {
//        playerScore += 6;
//        playerScore += handScores.GetValueOrDefault(playerTwoHands);
//    }
//    else
//    {
//        playerScore += 0;
//        playerScore += handScores.GetValueOrDefault(playerTwoHands);
//    }
//}
//Console.WriteLine(playerScore);
