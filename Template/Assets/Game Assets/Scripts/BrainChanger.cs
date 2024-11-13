using UnityEngine;

public class BrainChanger : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    public DialogueLine[] brainLines; //1
    public DialogueLine[] neuronLines; //2
    public GameObject[] brainPartsToGlow;

    public void ChangeBrainModel(int val)
    {
        switch (val)
        {
            case 0:
                
                break;

            case 1:
                
                dialogue.dialogueLines = brainLines;
                dialogue.StartDialogue();
                break;

            case 2:
                
                dialogue.dialogueLines = neuronLines;
                dialogue.StartDialogue();
                break;
        }
        for (int i = 0; i < brainPartsToGlow.Length; i++)
        {
            if (i == val - 1) brainPartsToGlow[i].GetComponent<Outline>().enabled = true;
            else brainPartsToGlow[i].GetComponent<Outline>().enabled = false;
        }
    }
}