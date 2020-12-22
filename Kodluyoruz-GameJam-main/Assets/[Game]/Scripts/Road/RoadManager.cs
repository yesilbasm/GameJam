using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadManager : Singleton<RoadManager>
{
    public List<GameObject> roads;
    private float offset = 35.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    private void Update()
    {
        CreateRoad();
        if (GameManager.Instance.isGameStarted)
            MoveRoad();
    }
    
    public void MoveRoad()
    {
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.position += Vector3.back * GameManager.Instance.gameSpeed * Time.deltaTime;
        }
    }
    public void CreateRoad()
    {
        GameObject movedRoad = roads[0];
        if (movedRoad.transform.position.z < -12f)
        {
            roads.Remove(movedRoad);
            float newZ = roads[roads.Count - 1].transform.position.z + offset;
            movedRoad.transform.position = new Vector3(0, 0, newZ);
            roads.Add(movedRoad);
        }
    }

}
