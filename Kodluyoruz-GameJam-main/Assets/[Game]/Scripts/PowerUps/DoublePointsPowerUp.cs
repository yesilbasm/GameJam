using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsPowerUp : CollectableBase
{
    public override void Collect()
    {
        base.Collect();
    }
    public override void Use()
    {
        ScoreManager.Instance.DoubleScore();
    }


}
