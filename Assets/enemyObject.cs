using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode attackKey = KeyCode.None;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(attackKey))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "beatLine")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "beatLine")
        {
            canBePressed = false;
        }
    }
}
