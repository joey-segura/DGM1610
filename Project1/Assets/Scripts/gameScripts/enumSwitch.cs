using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enumSwitch : MonoBehaviour
{
    public enum States
    {
        Start,
        Playing,
        End
    }

    public States currentState;

    public UnityEvent onStartEvent, onPlayingEvent, onEndEvent;
    void Update()
    {
        switch (currentState)
        {
            case States.Start:
                onStartEvent.Invoke();
                break;
            case States.Playing:
                onPlayingEvent.Invoke();
                break;
            case States.End:
                onEndEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
} 
