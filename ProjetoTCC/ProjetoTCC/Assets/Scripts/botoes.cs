using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class botoes : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("CenaTD");

    }

    public void Comecar()
    {
        SceneManager.LoadScene("IntroJogo");
    }

      public void Instrucoes()
    {
        SceneManager.LoadScene("Instruções");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
