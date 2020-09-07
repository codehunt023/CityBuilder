﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sourav.Utilities.Extensions;

public class UiController : MonoBehaviour
{
    [SerializeField] private Button _buildResidentialAreaButton;

    public Button BuildResidentialAreaButton
    {
        get { return _buildResidentialAreaButton;}
        set
        {
            _buildResidentialAreaButton = value;
        }
    }
    [SerializeField] private Button _cancelActionButton;

    public Button CancelActionButton
    {
        get { return _cancelActionButton;}
        set
        {
            _cancelActionButton = value;
        }
    }
    [SerializeField] private GameObject _cancelActionPanel;

    public GameObject CancelActionPanel
    {
        get { return _cancelActionPanel;}
        set
        {
            _cancelActionPanel = value;
        }
    }

    private Action onBuildAreaHandler;
    private Action onCancelActionHandler;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _cancelActionPanel.Hide();
        _buildResidentialAreaButton.onClick.AddListener(OnBuildAreaCallback);
        _cancelActionButton.onClick.AddListener(OnCancelActionCallback);
    }

    private void OnBuildAreaCallback()
    {
        _cancelActionPanel.Show();
        if (onBuildAreaHandler != null)
        {
            onBuildAreaHandler.Invoke();
        }
    }
    private void OnCancelActionCallback()
    {
        _cancelActionPanel.Hide();
        if (onCancelActionHandler != null)
        {
            onCancelActionHandler.Invoke();
        }
    }

    public void AddListener_OnBuildAreaEvent(Action listener)
    {
        onBuildAreaHandler += listener;
    }
    public void RemoveListener_OnBuildAreaEvent(Action listener)
    {
        onBuildAreaHandler -= listener;
    }

    public void AddListener_OnCancelActionEvent(Action listener)
    {
        onCancelActionHandler += listener;
    }
    public void RemoveListener_OnCancelActionEvent(Action listener)
    {
        onCancelActionHandler -= listener;
    }
}
