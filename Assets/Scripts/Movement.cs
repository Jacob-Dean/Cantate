using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=CxI2OBdhLno&ab_channel=RoyalSkies

public class Movement : MonoBehaviour
{
    Animator animator;
    public Vector2 turn;
    public float angle;
    [SerializeField] public float speed = 0.5f;
    [SerializeField] public float sensitivity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (transform.eulerAngles.y>0)
        {
            angle = 360 - transform.eulerAngles.y;
        }
        else
        {
            angle = -transform.eulerAngles.y;
        }


        Debug.Log(new Vector2(-speed * Mathf.Sin(angle * Mathf.Deg2Rad), speed * Mathf.Cos(angle * Mathf.Deg2Rad)));
        */
        turn.x += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(0, turn.x * sensitivity, 0);
        if (Input.GetKey(KeyCode.Space))
        {
            //transform.Translate(-speed*Mathf.Sin(angle*Mathf.Deg2Rad),0,speed*Mathf.Cos(angle*Mathf.Deg2Rad));
            //float newZ = transform.localPosition.z + speed*Time.deltaTime;
            //transform.localPosition=new Vector3(transform.localPosition.x, transform.localPosition.y,newZ);

            animator.SetBool("isWalking", true);
            transform.position+=transform.forward*Time.deltaTime*speed;
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
