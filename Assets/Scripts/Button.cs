using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
