using UnityEngine;

public class BlockTrigger : MonoBehaviour
{
    [SerializeField]GameObject block;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        block.SetActive(false);
        Score.instance.AddScore();
    }
}
