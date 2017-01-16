
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
        nextPlayersTurn(); 
      
    }

    private void nextPlayersTurn()
    {
        IPlayer players[activePlayerIndex]
        while (takingTurn)
        {

        }
    }
}
