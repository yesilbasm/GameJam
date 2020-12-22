using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] gifts;
    private float forwardThrust = 300f;
    private float upThrust = 150f;
    GameObject gift;
    Rigidbody giftRb;
    
    void Start()
    {
        gift = Instantiate(gifts[Random.Range(0,3)], spawnPoint.position, Quaternion.identity);      
        gift.transform.parent = spawnPoint;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            giftRb = gift.AddComponent<Rigidbody>();
            giftRb.AddForce(transform.forward * forwardThrust);
            giftRb.AddForce(transform.up * upThrust);
            giftRb.useGravity = true;

            StartCoroutine(SpawnGift());
        }
    }

    private IEnumerator SpawnGift()
    {
        yield return new WaitForSeconds(1f);
        gift = Instantiate(gifts[Random.Range(0, 3)], spawnPoint.position, spawnPoint.rotation);
        gift.transform.parent = spawnPoint;
    }


}
