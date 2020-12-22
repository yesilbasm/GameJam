using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : CollectableBase
{
    public override void Collect()
    {
        base.Collect();
    }
    public override void Use()
    {
        GameManager.Instance.HealUp();
        EventManager.OnHealUp.Invoke();
    }
}
