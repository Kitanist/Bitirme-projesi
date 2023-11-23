using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractChar : MonoBehaviour
{
    [SerializeField] private GameEvent _dialougeStarter;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _dialougeStarter.Raise();
        }
    }
}
