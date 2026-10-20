using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoccerBall : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private ParticleSystem _goalVFX;

    // STEP 5: member variable to keep track of points
    private int _points = 0;

    // STEP 6: member variable to keep track of time since last goal
    private float _timeSinceLastGoal = 0f;

    // STEP 6: Update is called by Unity every frame
    private void Update()
    {
        _timeSinceLastGoal += Time.deltaTime;
        _timeText.text = "time since last goal: " + ((int)_timeSinceLastGoal).ToString("00");
    }

    // STEP 1: called by Unity when this object hits a collider with Is Trigger checked
    private void OnTriggerEnter(Collider other)
    {
        // STEP 2: only react if the object we hit is tagged "Goal"
        if (other.gameObject.tag.Equals("Goal"))
        {
            MadeGoal();
        }
    }

    // STEP 3: returns nothing, has no input
    private void MadeGoal()
    {
        Debug.Log("SoccerBall detected a collision with a trigger collider!");

        // STEP 4: play the celebration VFX
        _goalVFX.Play();

        // STEP 5: add a point and update the points text
        _points++;
        _pointsText.text = "points: " + _points;

        // STEP 6: reset the timer
        _timeSinceLastGoal = 0f;
    }
}