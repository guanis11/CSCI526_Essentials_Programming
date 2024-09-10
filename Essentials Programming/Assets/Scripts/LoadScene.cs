using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load3DEssentials()
    {
        SceneManager.LoadScene("EssentialsScene");
    }

    public void LoadLavaChallenge()
    {
        SceneManager.LoadScene("FLoorIsLavaChallengeScene");
    }
}
