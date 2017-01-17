
using System;
using System.Collections.Generic;

public class GameManager {
    private List<IPlayer> players;
    private int activePlayerIndex;
    private int victoryPointMax;
    private int currentLargestVPCount;

    public GameManager(IGameSettings gS, List<IPlayer> pL)
    {
        players = pL;
        victoryPointMax = gS.getMaxVPs();
    }

    public void startGame()
    {
        while(!checkWinCondition())
        {
            nextPlayersTurn();
        }
        endGame();
    }

    //wraps up what needs to be wrapped up at the end of the game
    private void endGame()
    {
        throw new NotImplementedException();
    }

    private void nextPlayersTurn()
    {
        IPlayer currentPlayer = players[activePlayerIndex];
        while (currentPlayer.takingTurn())
        {
            EInstruction inst = currentPlayer.getNextInstruction();
            processInstruction(inst);
            if (checkWinCondition()) break;
        }
        incrementActivePlayerIndex();
    }

    //checks to see if any win condition is met.
    //@return true if win condition met
    private bool checkWinCondition()
    {
        if (currentLargestVPCount >= victoryPointMax) return true;
        else return false;
    }

    //increases the index by one, or resets to zero if it reaches the maximum
    private void incrementActivePlayerIndex()
    {
        activePlayerIndex++;
        activePlayerIndex %= players.Count;
    }

    private void processInstruction(EInstruction inst)
    {
        throw new NotImplementedException();
    }
}
