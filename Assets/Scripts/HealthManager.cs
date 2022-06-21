using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] public float maxHealth = 100f;
    public float remainingHealth;
    public GameObject gameObj;


    public HealthBar healthBar;


    // Start is called before the first frame update
    void Start()
    {
        remainingHealth = maxHealth;
        healthBar.SetHealth(remainingHealth);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(remainingHealth);
        healthBar.SetHealth(remainingHealth);

        if(remainingHealth<=0)
        {
            Destroy(gameObj);
        }
    }
}
