using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermovement : MonoBehaviour
{
    public CharacterController2D ctrl;
    public Animator anim;
    public KeyCode attackBind = KeyCode.None;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool isAttacking = false;

    // Update is called once per frame
    void Update ()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        anim.SetFloat("playerspeed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetBool("inair", true);
        }

        if (Input.GetKeyDown(attackBind))
        {
            isAttacking = true;
            anim.SetBool("attack", true);
        }else if(Input.GetKeyUp(attackBind))
        {
            isAttacking = false;
            anim.SetBool("attack", false);
        }
    }

    void FixedUpdate ()
    {
        ctrl.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
        anim.SetBool("inair", false);
    }
}
