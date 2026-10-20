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

Q1: We added Rigidbodies to the Cat and the SoccerBall, because both of them need to move with physics — the cat kicks the ball, and both need to bounce off the wall. We checked Is Trigger only on the Goal, because the ball needs to pass through it while still detecting that it entered the goal area. The Goal doesn't move, so it doesn't need a Rigidbody.

Q2: It worked the first time we tested it.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

