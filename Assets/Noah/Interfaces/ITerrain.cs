using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITerrain {
    string getImagePath();
    bool alreadyBuilt();
    bool moreUnitRoom();
    void addUnit(IUnit unit);
    IUnit[] getUnitArray();
    IBuilding getBuilding();
    void buildOnTerrain(IBuilding building);
}
