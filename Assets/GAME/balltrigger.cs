using UnityEngine;

public class balltrigger : MonoBehaviour
{
    public Animator animator; // 拖入要控制的 Animator（例如门）

    private void OnTriggerEnter(Collider other)
    {
        // 判断进入触发区的物体是不是 Player
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("Playernea"); // "Playernea" 必须和 Animator 参数名一致
        }
    }
}
