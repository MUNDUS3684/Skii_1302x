using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ESCTitle : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Title");
        }
    }
}