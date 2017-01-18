using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMap {

    int getHeight();
    int getWidth();
    ITerrain getLocation(int x, int y);
}
