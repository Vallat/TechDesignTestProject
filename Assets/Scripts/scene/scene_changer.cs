using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    public void change_scene(string scene_to_load)
    {
        SceneManager.LoadScene(scene_to_load);
    }
}
