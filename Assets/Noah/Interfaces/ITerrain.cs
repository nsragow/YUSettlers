using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITerrain : IContainsImage
{ 
    bool alreadyBuilt();
    bool moreUnitRoom();
    void addUnit(IUnit unit);
    IUnit[] getUnitArray();
    IBuilding getBuilding();
    void buildOnTerrain(IBuilding building);
    IResource produce(int labor);

}
