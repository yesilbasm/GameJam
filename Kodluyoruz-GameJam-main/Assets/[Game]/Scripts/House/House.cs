using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    private void OnEnable()
    {
        HouseManager.Instance.lastObj = this.gameObject;
        HouseManager.Instance.houses.Add(this);
    }
    private void OnDisable()
    {
        if (Managers.Instance == null)
        {
            return;
        }
        HouseManager.Instance.houses.Remove(this);
    }

   	
}
