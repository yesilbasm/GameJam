using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollectableBase : MonoBehaviour, ICollectable
{
    public virtual void Collect()
    {
        Use();
        Dispose();
    }

    public virtual void Dispose()
    {
        Destroy(gameObject);
    }

    public abstract void Use();
}
