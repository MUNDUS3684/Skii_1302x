using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text notitext;
    [SerializeField] TMP_Text pointText;

    public static UIManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void ShowNotiText(string s)
    {
        notitext.text = s;
    }

    public void UpdatePoint(int point)
    {
        pointText.text = $"Point: {point}";
    }
}