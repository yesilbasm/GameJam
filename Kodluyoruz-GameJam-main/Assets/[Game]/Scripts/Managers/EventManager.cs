using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static UnityEvent OnScore = new UnityEvent();
    public static UnityEvent OnMiss = new UnityEvent();
    public static UnityEvent OnGameOver = new UnityEvent();
    public static UnityEvent OnGameStart = new UnityEvent();
    public static UnityEvent OnHealUp = new UnityEvent();

}
