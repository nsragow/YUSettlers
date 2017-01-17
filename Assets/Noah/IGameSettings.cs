using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameSettings {

    int getMaxVPs();/*return the desired amount of Victory Points to win*/
    bool isPlayerTimeLimit();/*Are players turns forced to end if they take too long?*/
}
