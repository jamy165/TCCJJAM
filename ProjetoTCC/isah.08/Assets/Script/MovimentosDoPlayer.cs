using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentosDoPlayer : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rb;
    public float forcaPulo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");

        float movimentoVertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(1 * movimentoHorizontal, 1 * movimentoVertical, 0)* Time.deltaTime * velocidade);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(forcaPulo * 2, forcaPulo));
        }
    }
}
