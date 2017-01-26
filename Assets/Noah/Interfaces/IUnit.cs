using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit : IContainsImage, IFighter, IMoveable, IKillable, ILaborer
{
   
}

public interface IFighter
{
    int attackValue { get; }
}

public interface IMoveable
{
    int movementValue { get; }
}

public interface IKillable
{
    int maxHealth { get; }
    int health { get; }
    void rest();
    void fullHeal();
    void damageThis(int amountOfDamage);
}

public interface ILaborer
{
    int laborValue { get; }
}


