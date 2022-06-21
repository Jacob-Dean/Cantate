using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpell : MonoBehaviour
{
    public GameObject gameObj;
    public float speed = 20f;
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.forward);
        //Debug.Log(GameObject.Find("Drey").GetComponent<Transform>().forward);
        //GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime;
        Destroy(gameObj,3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Target")
        {
            Debug.Log("collided with player");
            Destroy(gameObj);
            col.gameObject.GetComponent<HealthManager>().remainingHealth -= 20;
        }
        //Destroy(gameObj);
    }
}
