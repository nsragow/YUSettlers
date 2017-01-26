﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayer
{
    /*Tells us if the player is still making decisions, or if he is ready to give 
    his turn up to the next player*/
    bool takingTurn(); 
    Instruction getNextInstruction();
    int vPCount();
    IResource[] getResourceArray();
    
}
