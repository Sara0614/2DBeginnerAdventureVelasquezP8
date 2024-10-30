using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        PlayerControler controller = other.GetComponent<PlayerControler>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
   
