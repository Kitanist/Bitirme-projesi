using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractBasic : MonoBehaviour
{
    [SerializeField] private GameEvent _dialougeStarter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _dialougeStarter.Raise();
    }
}
