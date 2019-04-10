using UnityEngine;
using System.Collections;

public class PickUpPart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    public int score;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(gameObject);

        if (other.tag == "Coin")
        {
            score += 10;
            Destroy(other.gameObject); // Or whatever way you want to remove the coin.
        }
    }

    
}
