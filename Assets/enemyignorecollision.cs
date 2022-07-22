using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyignorecollision : MonoBehaviour
{

    public Transform playerInQuestion;

    // Start is called before the first frame update
    void Start()
    {
        var playerSprite = Instantiate(playerInQuestion) as Transform;
        Physics2D.IgnoreCollision(playerSprite.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
