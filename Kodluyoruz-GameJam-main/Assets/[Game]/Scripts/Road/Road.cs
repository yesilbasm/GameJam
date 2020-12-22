using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    private void OnEnable()
    {
        RoadManager.Instance.roads.Add(this.gameObject);
    }
    private void OnDisable()
    {
        if (Managers.Instance == null)
        {
            return;
        }
        RoadManager.Instance.roads.Remove(this.gameObject);
    }
}
