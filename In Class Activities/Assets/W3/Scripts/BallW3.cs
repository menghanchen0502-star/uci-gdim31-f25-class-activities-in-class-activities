using TMPro;
using UnityEngine;

public class BallW3 : MonoBehaviour
{
    public SpriteRenderer ballRenderer;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speedMultiplier = 1.0f;
    [SerializeField] private float _speedThreshold = 10.0f;

    // ---------------------------------------------------------------
    // This method is called by Unity whenever the ball hits something.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // STEP 1 ---------------------------------------------------
        _rigidbody.linearVelocity *= _speedMultiplier;
        // STEP 1 ---------------------------------------------------

        // STEP 9 ---------------------------------------------------
        ballRenderer.color *= GetColorMultiplier(Mathf.Abs(_rigidbody.linearVelocity.x), Mathf.Abs(_rigidbody.linearVelocity.y));
        // STEP 9 ---------------------------------------------------
    }

    // STEP 8 -------------------------------------------------------
    // Input: X speed and Y speed of the ball
    // Output: a multiplier number (with decimals)
    private float GetColorMultiplier(float xSpeed, float ySpeed)
    {
        float averageSpeed = (xSpeed + ySpeed) / 2f;

        if (averageSpeed > _speedThreshold)
        {
            return 1.5f;
        }
        else
        {
            return 1.0f;
        }
    }
    // STEP 8 -------------------------------------------------------
}