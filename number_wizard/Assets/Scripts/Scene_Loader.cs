using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour {

    public void LoadNextScene() {
        int currentSeenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSeenIndex + 1);
    }
}
