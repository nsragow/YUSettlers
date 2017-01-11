
using System.Collections.Generic;

public class GameManager {
    private List<IPlayer> players;
    private int activePlayer;
    private int victoryPointMax;
    private int currentLargestVPCount;

    public GameManager(GameSettings gS, List<IPlayer> pL)
    {
        players = pL;
        victoryPointMax = gS.getMaxVPs();
    }

}
