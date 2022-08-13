using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MovimentoPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    Vector2 moveInput;

    public Text municao;

    public int quantMunicao;

    public Text por;

    public int quantPor;

    public float vidaInicial;

    public float vidaAtual;

    public float percVida;

    public Image barraVida;


    void Start()
    {
        vidaAtual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Time.deltaTime * moveSpeed);

        percentualVida();

        if (vidaAtual <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    public void percentualVida()
    {
        percVida = vidaAtual / vidaInicial;


        barraVida.fillAmount = percVida;



    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "inimigo")
        {
            vidaAtual -= 0.2f;

            if(vidaAtual == 0)
            {
                print("Fim de jogo");
            }
        }

    
    }
    
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "municao")
        {
            Destroy(collision.gameObject);

            quantMunicao += 1;

            municao.text = quantMunicao.ToString();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pocao")
        {
            Destroy(collision.gameObject);

            quantPor += 1;

            por.text = quantPor.ToString();
        }
    }


}
