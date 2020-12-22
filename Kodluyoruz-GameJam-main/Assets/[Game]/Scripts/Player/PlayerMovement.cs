using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public Rigidbody Rb { get { return (rb == null) ? rb = GetComponent<Rigidbody>() : rb; } }
    public float moveSpeed = 500f;
    public GameObject giftBox;

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        Rb.velocity = input * moveSpeed * Time.fixedDeltaTime;
    }

    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
            {
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        Instantiate(giftBox, transform.position + Vector3.down, Quaternion.identity);
    }

    public void StartingAnimation()
    {
        StartCoroutine(StartingAnimationCo());
    }

    public IEnumerator StartingAnimationCo()
    {
        transform.DOMoveY(30f, 2f);
        yield return new WaitForSeconds(2f);
        transform.DOMove(new Vector3(0, 10, 10), 2f);
        transform.DORotate(new Vector3(82, 0, 0), 2f);
        GameManager.Instance.isGameStarted = true;
        yield return new WaitForSeconds(2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        ICollectable icollectable = other.GetComponent<ICollectable>();
        if (icollectable != null)
        {
            icollectable.Collect();
        }
    }


}
