using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void OnEnable()
    {
        TreesManager.Instance.trees.Add(this);
    }
    private void OnDisable()
    {
        if (Managers.Instance == null)
        {
            return;
        }
        TreesManager.Instance.trees.Remove(this);
    }
}
