# in-class-activities
## Devlogs
### W1
I added the Player component to the cat, linked its Animator, increased its movement and turn speeds, moved it from OriginalStart to the green NewStart platform, and placed the camera at cat eye level for a first-person view. If the camera is removed from the Cat hierarchy, it stays at its scene position while the cat moves, so the view no longer follows the cat. Play the WebGL build: https://menghanchen0502-star.itch.io/w1-in-class-activity

### W2
1. The r, g, b variables are floats because Unity color channels are continuous values from 0 to 1, so they need decimals like 0.5. Ints can only store whole numbers, bools only store true or false, and strings store text, so none of them can represent a shade of color. In my Console logs, the color values looked like 0.358 and 0.742, which confirms they need to be decimals.
2. The _bounce variable is an int because it counts how many times the ball has bounced, and a bounce count is always a whole number. A float would allow values like 2.5 bounces, a bool could only say whether it bounced, and a string is text, which can't be counted or incremented properly.
3. The error message after Step 4 of Part 2 showed the script name, the exact line number, and a description of the problem, which told me which line of code was broken and why. It was useful because it pointed me straight to the mistake, so I could fix that line instead of guessing, and after the fix the game ran without errors.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
