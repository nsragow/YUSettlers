﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : IGameSettings{
    private bool timeLimitOn;
    private int victoryPointMax;

    public int getMaxVPs()
    {
        return victoryPointMax;
    }
    public bool isPlayerTimeLimit()
    {
        return timeLimitOn;
    }
     
}
