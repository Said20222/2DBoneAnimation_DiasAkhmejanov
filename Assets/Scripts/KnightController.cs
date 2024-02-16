using UnityEngine;

public class KnightController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            _animator.SetTrigger("jumpTrigger");
        }
    }
}
