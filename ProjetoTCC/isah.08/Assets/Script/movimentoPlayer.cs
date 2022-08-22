using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoPlayer : MonoBehaviour
{
    public float speed;
    private Rigidbody2D playerRb;
    private Animator anim;
    public float forcapulo;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoH = Input.GetAxisRaw("Horizontal");
        anim.SetInteger("Movimento", (int)movimentoH);
        transform.Translate(new Vector2(movimentoH, 0) * speed * Time.deltaTime);

        

        if (Input.GetButtonDown("Jump"))
        {
            playerRb.AddForce(new Vector2(0, 100 * forcapulo));
        }
    }
}
