using UnityEngine;

public class BatW6 : MonoBehaviour
{
    public float speed = 2f;
    private bool _isChasing = false;
    private Transform _cat;

    private void Awake()
    {
        GameObject catObject = GameObject.Find("Cat");
        if (catObject != null)
        {
            _cat = catObject.transform;
        }
        else
        {
            Debug.LogError("BatW6: Cannot find a GameObject named 'Cat'.");
        }
    }

    private void Update()
    {
        if (_isChasing && _cat != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _cat.position,
                speed * Time.deltaTime);
        }
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}