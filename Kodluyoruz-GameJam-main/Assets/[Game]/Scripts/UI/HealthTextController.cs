using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextController : MonoBehaviour
{
    // Start is called before the first frame update
    Text healthText;
    public Text HealthText { get { return (healthText == null) ? healthText = GetComponent<Text>() : healthText; } }
    void Start()
    {
        HealthText.text = "Health : " + GameManager.Instance.playerHealth;
    }

    private void OnEnable()
    {
        EventManager.OnMiss.AddListener(UpdateHealthText);
    }

    private void OnDisable()
    {
        EventManager.OnMiss.RemoveListener(UpdateHealthText);
    }

    private void UpdateHealthText()
    {
        HealthText.text = "Health : " + GameManager.Instance.playerHealth;
    }
}
