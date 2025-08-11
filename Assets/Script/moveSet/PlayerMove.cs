using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private InputActionReference _move;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed;
    private void Update()
    {
        var  input = _move.action.ReadValue<Vector2>();
        var movePos = transform.forward * input.y + transform.right * input.x;
        var velocity = movePos * _speed;
        _characterController.Move(velocity * Time.deltaTime);
    }
}
