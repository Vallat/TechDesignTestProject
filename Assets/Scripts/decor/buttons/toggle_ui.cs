using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_ui : MonoBehaviour
{
    public GameObject ui = null;
    public AudioSource click_sound = null;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                ui.SetActive(!ui.activeSelf);
                click_sound.Play();
            }
        }
    }
}
