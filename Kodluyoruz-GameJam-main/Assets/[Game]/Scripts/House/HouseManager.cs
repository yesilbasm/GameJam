using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Linq;

public class HouseManager : Singleton<HouseManager>
{
    public int startingHouseCount;
    public List<House> houses;
    public List<GameObject> houseList;
    public GameObject lastObj;
    public Transform leftLine;
    public Transform rightLine;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        CreateHouse();
        if (GameManager.Instance.isGameStarted)
            MoveHouses();
        
    }

    // Movevement of Houses
    public void MoveHouses()
    {
        for (int i = 0; i < houses.Count; i++)
        {
            houses[i].transform.position += Vector3.back * GameManager.Instance.gameSpeed * Time.deltaTime; 
        }
    }
    
    // When game starts create random houses
    private void Initialize()
    {
        Instantiate(houseList[Random.Range(0, houseList.Count)], leftLine.position + Vector3.forward * 10f, Quaternion.identity);
        for (int i = 0; i < startingHouseCount; i++)
        {
            Instantiate(houseList[Random.Range(0, houseList.Count)], lastObj.transform.position + Vector3.forward * 10f, Quaternion.identity);
        }
        Instantiate(houseList[Random.Range(0, houseList.Count)], rightLine.position + Vector3.forward * 10f, Quaternion.identity);
        for (int i = 0; i < startingHouseCount; i++)
        {
            Instantiate(houseList[Random.Range(0, houseList.Count)], lastObj.transform.position + Vector3.forward * 10f, Quaternion.identity);
        }
        if (houses != null && houses.Count > 0)
        {
            houses = houses.OrderBy(r => r.transform.position.z).ToList();
        }
    }
    
    // Move the house when its out of screen
    public void CreateHouse()
    {
        float offset = Random.Range(4f, 7f);
        House movedHouse = houses[0];
        if (movedHouse.transform.position.z < -8f)
        {
            houses.Remove(movedHouse);
            float newZ = houses[houses.Count - 1].transform.position.z + offset;
            movedHouse.transform.position = new Vector3(movedHouse.transform.position.x, movedHouse.transform.position.y, newZ);
            houses.Add(movedHouse);
        }
    }


}
