using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Giftbox : MonoBehaviour
{
    public float downSpeed;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }
    void Start()
    {
        transform.Rotate(new Vector3(-90, 0, 0));
        float gravityY = Physics.gravity.y;
        Rigidbody.velocity = new Vector3(0, gravityY, -GameManager.Instance.gameSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Chimney chimney = other.GetComponent<Chimney>();
        if (chimney != null)
        {
            ScoreManager.Instance.ScoreUp();
            EventManager.OnScore.Invoke();
            Destroy(gameObject);
        }
        else
        {
            GameManager.Instance.LoseHealth();
            ScoreManager.Instance.ScoreDown();
            EventManager.OnMiss.Invoke();
            Destroy(gameObject);
        }
    }
}
