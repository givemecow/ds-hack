using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Me"))
        {
            Destroy(gameObject);
            PlayerScript.k = PlayerScript.k + 5;
            Debug.Log(PlayerScript.k);
        }
    }
}
