using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    CanvasGroup startButton;
    CanvasGroup StartButton { get { return (startButton == null) ? startButton = GetComponent<CanvasGroup>() : startButton; } }

    [Button]
    private void ShowButton()
    {
        StartButton.alpha = 1;
        StartButton.interactable = true;
        StartButton.blocksRaycasts = true;
    }

    [Button]
    private void HideButton()
    {
        StartButton.alpha = 0;
        StartButton.interactable = false;
        StartButton.blocksRaycasts = false;
    }
}
