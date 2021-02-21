using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{
    public Text Lose;

    public void LoseText()
    {
        Lose.text = "You Lose" + "\nPress Enter to restart";
    }
}
