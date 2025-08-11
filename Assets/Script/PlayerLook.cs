using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform _cam;
    [SerializeField] private InputActionReference _look;
    [SerializeField] private float _lookSpeed;
    [SerializeField] private float _maxpitch,_minpitch;
    float _rotate;
    private void Start()
    {
        _rotate = _cam.transform.localEulerAngles.x;
        //goc xoay quah truc x theo do (0-360);
    }
    private void Update()
    {
        var input = _look.action.ReadValue<Vector2>();
        pitchUpdate(input.y);   
        yawUpdate(input.x);
        
    }

    private void yawUpdate(float input)
    {
        var yaw = input * _lookSpeed * Time.deltaTime;
        transform.Rotate(0, yaw, 0);
    }

    private void pitchUpdate(float input)
    {
        var pitch = -input * _lookSpeed * Time.deltaTime;
        _rotate = Mathf.Clamp(_rotate + pitch, _minpitch, _maxpitch);
        _cam.localRotation = Quaternion.Euler(_rotate, 0, 0);
    }
}
