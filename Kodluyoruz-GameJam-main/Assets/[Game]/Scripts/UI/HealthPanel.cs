using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPanel : MonoBehaviour
{
    public List<Image> LifeImages;

    private void OnEnable()
    {
        
        EventManager.OnMiss.AddListener(UpdateUI);
        EventManager.OnHealUp.AddListener(UpdateUI);
    }

    private void OnDisable()
    {
        EventManager.OnMiss.RemoveListener(UpdateUI);
        EventManager.OnHealUp.RemoveListener(UpdateUI);
    }

    public void UpdateUI()
    {
        if (GameManager.Instance.playerHealth > LifeImages.Count)
        {
            return;
        }

        foreach (var image in LifeImages)
        {
            image.enabled = false;
        }

        for (int i = 0; i < GameManager.Instance.playerHealth; i++)
        {
            LifeImages[i].enabled = true;
        }
    }
}
