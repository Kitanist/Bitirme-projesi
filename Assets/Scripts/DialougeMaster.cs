using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystemWithText;

public class DialougeMaster : MonoSingeleton<DialougeMaster>
{
    [SerializeField] DialogueUIController diyalogController;
  
    [SerializeField]  private PlayerMovement Player;
    void Start()
    {
        diyalogController.ShowDialogueUI();
    }

   public void StopToDialogueEnd()
    {
        Player.CanMove = false;
    }
    public void DialogueEnd()
    {
        Player.CanMove = true;
    }
   
}
