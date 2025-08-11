using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class LightSkill : MonoBehaviour
{
    //ManualShooting
    [SerializeField] private InputActionReference _fire;
    public UnityEvent OnFire;

    // Update is called once per frame
    void Update()
    {
        if (_fire.action.triggered)
        {
            Fire();
        }
    }
    public void Fire() => OnFire.Invoke();
}
