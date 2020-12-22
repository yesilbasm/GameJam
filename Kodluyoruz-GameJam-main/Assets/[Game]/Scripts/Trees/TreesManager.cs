using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class TreesManager : Singleton<TreesManager>
{
    public List<Tree> trees;

    private void Start()
    {
        if (trees != null && trees.Count > 0)
        {
            trees = trees.OrderBy(r => r.transform.position.z).ToList();
        }
    }
    void Update()
    {
        if (trees.Count > 0)
        {
            CreateTrees();
            if (GameManager.Instance.isGameStarted)
                MoveTrees();
        }
    }

    private void MoveTrees()
    {
        for (int i = 0; i < trees.Count; i++)
        {
            trees[i].transform.position += Vector3.back * (GameManager.Instance.gameSpeed) * Time.deltaTime;
        }
    }

    private void CreateTrees()
    {
        float offset = Random.Range(2f, 4f);
        Tree movedTree = trees[0];
        if (movedTree.transform.position.z < -9f)
        {
            trees.Remove(movedTree);
            float newZ = trees[trees.Count - 1].transform.position.z + offset + 20f;
            movedTree.transform.position = new Vector3(movedTree.transform.position.x, movedTree.transform.position.y, newZ);
            trees.Add(movedTree);
        }
    }
}
