using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Human {
    private const int _attackValue = 3;
    private const string _imagePath = "TEST IMAGE PATH";
    private const int _laborValue = 1;
    private const int _maxHealth = 5;
    private const int _movementValue = 1;
    private const int _restValue = 1;
    public Warrior()
    {
        
    }

    public override int attackValue
    {
        get
        {
            return _attackValue;
        }
    }

    public override string imagePath
    {
        get
        {
            return _imagePath;
        }
    }

    public override int laborValue
    {
        get
        {
            return _laborValue;
        }
    }

    public override int maxHealth
    {
        get
        {
            return _maxHealth;
        }
    }

    public override int movementValue
    {
        get
        {
             throw new NotImplementedException();
        }
    }

    public override int restValue
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}
