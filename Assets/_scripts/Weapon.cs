using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Killable kill;
    public Player player;
    public float timeLimit, currTime, transitionTime;
    public bool attacking;

    private void Start()
    {
        player = this.GetComponentInParent<Player>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        try
        {
            kill = collision.gameObject.GetComponent<Killable>();
            if(kill != null)
                kill.Killed(player);
        }
        finally
        {

        }
    }

    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //transform.Rotate(new Vector3(0f, 0f, 1.0f), 90f);
            transform.RotateAround(player.transform.position, new Vector3(0f, 0f, 1.0f), -70f);
            
        }
        if(Input.GetButtonUp("Fire1"))
        {
            transform.RotateAround(player.transform.position, new Vector3(0f, 0f, 1.0f), 70f);
        }
    }
}
