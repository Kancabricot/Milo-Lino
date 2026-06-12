using UnityEngine;

public class ReflectFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if (_target == null) return;
        Vector3 pos = transform.position;
        pos.x = _target.position.x;
        transform.position = pos;
    }
}