using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathPanel : MonoBehaviour
{
    CanvasGroup deathPanelCanvas;
    public CanvasGroup DeathPanelCanvas { get { return (deathPanelCanvas == null) ? deathPanelCanvas = GetComponent<CanvasGroup>() : deathPanelCanvas; } }

    private void OnEnable()
    {
        EventManager.OnGameOver.AddListener(ShowPanel);
    }

    private void OnDisable()
    {
        EventManager.OnGameOver.RemoveListener(ShowPanel);
    }

    [Button]
    private void ShowPanel()
    {
        DeathPanelCanvas.alpha = 1;
        DeathPanelCanvas.interactable = true;
        DeathPanelCanvas.blocksRaycasts = true;
    }

    [Button]
    private void HidePanel()
    {
        DeathPanelCanvas.alpha = 0;
        DeathPanelCanvas.interactable = false;
        DeathPanelCanvas.blocksRaycasts = false;
    }
}
