using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueSystemWithText;

namespace DialogueSystemWithText
{
    public class DialogueDemo : MonoBehaviour
    {
        [SerializeField] private DialogueUIController _dialogueUIController;

        private void Start()
        {
          
             
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                _dialogueUIController.ShowDialogueUI();
            }
        }
    }
}
