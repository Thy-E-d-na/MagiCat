using UnityEngine;

public class visuallRotation : MonoBehaviour
{
    [SerializeField] private Transform _ring1;
    [SerializeField] private Transform _ring2;
    [SerializeField] private Transform _ring3;
    [SerializeField] private float speed;
    private void Update()
    {
        _ring1.Rotate(Vector3.forward * speed);
        _ring2.Rotate(Vector3.right * speed);
        _ring3.Rotate(Vector3.up * -speed);
    }
}