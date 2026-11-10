# in-class-activities
## Devlogs
### W1
I added the Player component to the cat, linked its Animator, increased its movement and turn speeds, moved it from OriginalStart to the green NewStart platform, and placed the camera at cat eye level for a first-person view. If the camera is removed from the Cat hierarchy, it stays at its scene position while the cat moves, so the view no longer follows the cat. Play the WebGL build: https://menghanchen0502-star.itch.io/w1-in-class-activity

### W2
1. The r, g, b variables are floats because Unity color channels are continuous values from 0 to 1, so they need decimals like 0.5. Ints can only store whole numbers, bools only store true or false, and strings store text, so none of them can represent a shade of color. In my Console logs, the color values looked like 0.358 and 0.742, which confirms they need to be decimals.
2. The _bounce variable is an int because it counts how many times the ball has bounced, and a bounce count is always a whole number. A float would allow values like 2.5 bounces, a bool could only say whether it bounced, and a string is text, which can't be counted or incremented properly.
3. The error message after Step 4 of Part 2 showed the script name, the exact line number, and a description of the problem, which told me which line of code was broken and why. It was useful because it pointed me straight to the mistake, so I could fix that line instead of guessing, and after the fix the game ran without errors.

### W3
Table #13
1. GetResponse should take an int for the friendship level and a bool for whether the player knows the secret, and return a string, since the output is the character's text response: string GetResponse(int friendshipLevel, bool knowsSecret).
2. SetLightDimness should take a float for the sanity level (0 to 100%), since sanity can have decimals, and return void, because it changes the light directly and doesn't need any output: void SetLightDimness(float sanity).
3. DidPlayerHitBeat should take a float for the time the player pressed the key and return a bool, because the answer is just yes or no: bool DidPlayerHitBeat(float pressTime).
4. Our metaphor: a class is like a job description, and a Component is an employee hired from that description and assigned to a specific store, which is the GameObject. One job description can be used to hire many employees for different stores. Member variables are each employee's traits, like their name or work speed, which can be different for each employee, just like values tuned in the Inspector. Methods are the tasks the employee can do, like ringing up customers or restocking shelves.
5. The balls get extremely bright because every time a ball bounces fast enough, its color is multiplied by 1.5, and there is no maximum limit. Color values normally go from 0 to 1, but multiplying again and again makes them grow quickly past 1 (0.5, 0.75, 1.13, 1.69, 2.53...). Since Step 1 also makes the balls faster with every bounce, they soon stay above the speed threshold and get brighter on every bounce. The cat gets brighter too because it copies the color of the ball that hits it.

### W4

#### Activity 1
Table 17

Q1: We added Rigidbodies to the Cat and the SoccerBall, because both of them need to move with physics, the cat kicks the ball, and both need to bounce off the wall. We checked Is Trigger only on the Goal, because the ball needs to pass through it while still detecting that it entered the goal area. The Goal doesn't move, so it doesn't need a Rigidbody.

Q2: It worked the first time we tested it.

### W5

#### Activity 1

Q1: The class needs two member variables. One is a Transform called target, which is the object the deer walks to. It is set in the Inspector. The other is a NavMeshAgent called agent, which stores the NavMeshAgent component on the Deer.

Q2: It only needs Start(), which Unity provides. We only need to tell the deer where to go once, when the game begins, so we don't need Update().

Q3: In Start(), we use GetComponent<NavMeshAgent>() to get the agent from the Deer. Then we call agent.SetDestination(target.position) so the deer walks to the target on the NavMesh.

### W7

#### Activity 1

Table: 10

My category assignment: Unity engine and Other tools.

Shared Google Doc: https://docs.google.com/document/d/1Fn9TGFlxzcsuaW2vjqgng_0IyirIMh9iUS6c1-b-k7M/edit?tab=t.0

#### Activity 2

Q1: The BatW6 class needs three member variables. A public float called speed, so we can tune how fast the bat moves in the Inspector. A bool called _isChasing, which stores whether the bat is chasing right now. A Transform called _cat, which stores the player so the bat knows where to move.

Q2: It needs Awake() and Update(), which Unity provides, and StartChasing() and StopChasing(), which we write. Awake() finds the Cat once when the game loads, and Update() runs every frame so the bat can keep moving. StartChasing() and StopChasing() are public so the BatManager can call them.

Q3: Awake() uses GameObject.Find("Cat") to get the player's Transform. Update() only moves the bat if _isChasing is true, using Vector3.MoveTowards with speed * Time.deltaTime so the speed is the same on every computer. StartChasing() sets _isChasing to true, and StopChasing() sets it to false.

Part 1: We added a temporary Start() that calls StartChasing(), so all of the bats chased the cat as soon as the game loaded.

Part 2: We removed Start() so the bats stay still by default. In BatManager, a for loop checks the distance between each bat and the cat with Vector3.Distance. If the distance is less than _interactDistance, the bat chases the cat, otherwise it stops. If the distance is less than _overlapDistance, the bat shows a random message from the _messages array. I used GetComponentsInChildren<BatW6>() in Start() to fill the _bats array automatically, instead of dragging all 10 bats into the Inspector. In my final code, EnableChase() and DisableChase() are named StartChasing() and StopChasing(), and they use an _isChasing bool instead of enabling and disabling the component.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

