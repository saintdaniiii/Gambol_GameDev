using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject boostPrefab;

    private GameObject newPlat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 7) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(boostPrefab, new Vector2(Random.Range(-2, 2f), player.transform.position.y + (8 + Random.Range(1f, 1f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2, 2f), player.transform.position.y + (8 + Random.Range(1f, 1f)));
            }
        }
        else if (collision.gameObject.name.StartsWith("Boost"))
        /*{
            if (Random.Range(1, 7) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-2, 2f), player.transform.position.y + (8 + Random.Range(1f, 1f)));
            }
        }
        else */
        {
            Destroy(collision.gameObject);
            Instantiate(platformPrefab, new Vector2(Random.Range(-2, 2f), player.transform.position.y + (8 + Random.Range(1f, 1f))), Quaternion.identity);
        }
    }
}
