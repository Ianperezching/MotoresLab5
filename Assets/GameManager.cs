using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Audio;

    public void  AudioOpen()
    {
        Audio.SetActive(true);
    }
    public void Audioclose()
    {
        Audio.SetActive(false);
    }
}
