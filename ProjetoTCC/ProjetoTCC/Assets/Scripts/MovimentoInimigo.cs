using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject player;
    bool isAlive = true;
    public float distance;
    
    public Transform playerTransform;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    
        
        Ataque();
    }
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("municao"))
        {
            isAlive = false;
            Destroy(gameObject);
        }
        
    }

    public void Ataque()
    {
        distance = Vector2.Distance(transform.position, playerTransform.position);

        if (distance <= 3f)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }
  

    }

}
