using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Human : IUnit
{
    private int _health;
    private static readonly int _maxHealth;

    public abstract int restValue
    { get; }

    public abstract string imagePath
    { get; }

    public abstract int attackValue
    { get; }

    public abstract int movementValue
    { get; }

    public abstract int maxHealth
    { get; }

    public abstract int laborValue
    { get; }

    public int health
    {
        get
        {
            return _health;
        }
    }

    public void rest()
    {
        _health += restValue;
        _health %= maxHealth;
    }

    public void fullHeal()
    {
        _health = maxHealth;
    }

    public void damageThis(int amountOfDamage)
    {
        _health -= amountOfDamage;
    }
}
