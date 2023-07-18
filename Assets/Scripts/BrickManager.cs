using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrickManager : MonoBehaviour
{
    public int health = 3;
    TextMeshPro healthtext;

    //public GameObject healthtext;
    // Start is called before the first frame update
    void Start()
    {
        health = Random.Range(1, 12);
        healthtext = GetComponentInChildren<TextMeshPro>();
        Displayhealth();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Displayhealth()
    {
        // string healthStr = string.Format();
        healthtext.SetText(health.ToString());
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            health--;
            Displayhealth();
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
