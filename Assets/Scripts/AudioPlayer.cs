using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPlayer : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
            Destroy(this);
    }
}
