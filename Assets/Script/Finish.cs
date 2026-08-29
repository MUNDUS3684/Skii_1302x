using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        UIManager.instance.ShowNotiText($"You WIN!!!\npoint: {p.Point}");
    }
}
