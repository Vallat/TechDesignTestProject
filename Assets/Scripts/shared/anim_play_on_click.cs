using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_play_on_click : MonoBehaviour
{
    private Animator anim = null;
    public string anim_name = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if ( !anim )
            {
                return;
            }
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (GetComponent<Collider2D>().OverlapPoint(mousePosition))
            {
                anim.enabled = true;
                anim.Update(0f);
                anim.Play(anim_name, 0, 0);
            }
        }
    }
}
