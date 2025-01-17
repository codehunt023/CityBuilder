﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState
{
    protected GameManager _gameManager;

    public PlayerState(GameManager gameManager)
    {
        this._gameManager = gameManager;
    }

    public abstract void OnInputPointerDown(Vector3 position);
    public abstract void OnInputPointerChange(Vector3 position);
    public abstract void OnInputPointerUp();
    public abstract void OnInputPanChange(Vector3 panPosition);
    public abstract void OnInputPanUp();

    public virtual void EnterState()
    {
        
    }
    
    public abstract void OnCancel();
}
