using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystemWithText;


public class DialougeMaster : MonoSingeleton<DialougeMaster>
{
    [SerializeField] DialogueUIController diyalogController;
    public CameraSmoother MainCamFollow;
    public GameObject MainCam,pos1,pos2,pos3;
    [SerializeField]  private PlayerMovement Player;
    void Start()
    {
        LeanTween.move(MainCam, pos1.transform, 20f);
        Invoke(nameof(Loop),20f);
    }
    public void Loop()
    {
        LeanTween.move(MainCam, pos2.transform, 20f);
        Invoke(nameof(Loop2), 20f);
    }
    public void Loop2()
    {
        LeanTween.move(MainCam, pos3.transform, 20f);

        Invoke(nameof(StartDialouge), 20f);
        Invoke(nameof(StartCamFollow), 20f);
    }
    
    public void StartDialouge()
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
    public void StopCamFollow()
    {
        MainCamFollow.enabled = false;
    }
    public void StartCamFollow()
    {
        MainCamFollow.enabled = true;
    }
   
}
