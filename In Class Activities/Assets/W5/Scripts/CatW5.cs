using UnityEngine;

public class CatW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        // STEP 1: Move forwards and backwards with W and S
        Vector3 translation = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            translation += Vector3.forward;   // vector addition
        }
        if (Input.GetKey(KeyCode.S))
        {
            translation += Vector3.back;      // vector addition
        }

        // STEP 2: Flip the controls if _flipWSControls is true
        if (_flipWSControls)
        {
            translation *= -1;                // scalar * vector
        }

        transform.Translate(translation * _moveSpeed * Time.deltaTime);

        // Turning (already given)
        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Walking animation (already given)
        if (translation.magnitude != 0.0f || rotation != 0.0f)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
}