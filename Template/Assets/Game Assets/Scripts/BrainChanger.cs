using UnityEngine;

public class BrainChanger : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    public DialogueLine[] centralBrainLines; //1
    public DialogueLine[] neuronLines; //2
    public DialogueLine[] topBrainLines;
    public DialogueLine[] tasteLines;
    public DialogueLine[] angleBrainLines;
    public GameObject[] brainPartsToGlow;

    public void ChangeBrainModel(int val)
    {
        switch (val)
        {
            case 0:
                
                break;

            case 1:
                
                dialogue.dialogueLines = centralBrainLines;
                dialogue.currentLine = 0;
                dialogue.StartDialogue();
                break;

            case 2:
                
                dialogue.dialogueLines = neuronLines;
                dialogue.currentLine = 0;
                dialogue.StartDialogue();
                break;
            case 3:

                dialogue.dialogueLines = topBrainLines;
                dialogue.currentLine = 0;
                dialogue.StartDialogue();
                break;
            case 4:

                dialogue.dialogueLines = tasteLines;
                dialogue.currentLine = 0;
                dialogue.StartDialogue();
                break;
            case 5:

                dialogue.dialogueLines = angleBrainLines;
                dialogue.currentLine = 0;
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