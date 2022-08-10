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


}
