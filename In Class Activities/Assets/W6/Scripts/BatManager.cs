using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatManager : MonoBehaviour
{
    [SerializeField] private float _overlapDistance = 1f;
    [SerializeField] private float _interactDistance = 4f;
    [SerializeField] private float _timeBetweenNewMessages = 0.5f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private TMP_Text _reactionUiPrefab;

    // STEP 1: array of all bats in the scene (collected automatically in Start if left empty)
    [SerializeField] private BatW6[] _bats;

    // STEP 3: messages the bats can say (fill in Inspector)
    [SerializeField] private string[] _messages;

    // One timer per bat
    private float[] _newTextTimers;

    private void Start()
    {
        // STEP 1 (automatic): collect every BatW6 under this object
        if (_bats == null || _bats.Length == 0)
        {
            _bats = GetComponentsInChildren<BatW6>();
        }

        // STEP 6
        _newTextTimers = new float[_bats.Length];
    }

    private void Update()
    {
        // STEP 7
        for (int i = 0; i < _newTextTimers.Length; i++)
        {
            _newTextTimers[i] += Time.deltaTime;
        }

        // STEP 2
        for (int i = 0; i < _bats.Length; i++)
        {
            BatW6 bat = _bats[i];
            float distance = Vector3.Distance(bat.transform.position, _playerTransform.position);

            if (distance < _interactDistance)
            {
                bat.StartChasing();
            }
            else
            {
                bat.StopChasing();
            }

            // STEP 4
            if (distance < _overlapDistance)
            {
                CreateReactions(bat);
            }
        }
    }

    private void CreateReactions(BatW6 bat)
    {
        // STEP 5
        if (_messages == null || _messages.Length == 0)
        {
            return;
        }

        int randomIndex = Random.Range(0, _messages.Length);
        SpawnReactionUI(bat, _messages[randomIndex]);
    }

    private void SpawnReactionUI(BatW6 bat, string message)
    {
        // STEP 8
        int index = System.Array.IndexOf(_bats, bat);

        GridLayoutGroup layout = bat.GetComponentInChildren<GridLayoutGroup>();
        if (layout != null && _newTextTimers[index] >= _timeBetweenNewMessages)
        {
            _newTextTimers[index] = 0.0f;
            TMP_Text textObj = Instantiate(_reactionUiPrefab, layout.transform);
            textObj.text = message;
        }
    }
}