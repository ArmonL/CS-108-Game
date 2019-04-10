using UnityEngine;
using System.Collections;

public class SpawnPart : MonoBehaviour
{

    public Transform[] partSpawns;
    public GameObject part;

    // Use this for initialization
    void Start()
    {

        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < partSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 2);
            if (coinFlip > 0)
                Instantiate(part, partSpawns[i].position, Quaternion.identity);
        }
    }

    

}