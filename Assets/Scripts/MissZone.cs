using UnityEngine;

public class MissZone : MonoBehaviour
{
    private void OnCollistionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            FindObjectOfType<GameManager>().Miss();
        }
    }
}
