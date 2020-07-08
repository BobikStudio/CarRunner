using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public static bool foward = true;

    private Animation anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();

    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && GameOver.isGameOver == false)
        {
           if (foward && !anim.isPlaying)
            {
                anim.Play("TurnRight");
                foward = false;
            }
           else if (!anim.isPlaying)
            {
                anim.Play("TurnLeft");
                foward = true;
            }
       
        }
    }
}
