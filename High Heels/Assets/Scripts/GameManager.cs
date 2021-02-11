using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool isFinished;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;
    [SerializeField]
    public GameObject GameWinUI;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Win()
    {
        if (!isFinished)
        {
            confetti1.Play();
            confetti2.Play();
            isFinished = true;
            PlayerController.instance.Finish();
            StartCoroutine(WinScreen());
        }
    }
    IEnumerator WinScreen()
    {
        yield return new WaitForSeconds(8f);
        GameWinUI.SetActive(true);
    }
}
