# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

I wrote a devlog

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
- 1.Becuase these are continuous decimals between 0.0 to 1.0.
- 2.Because it can only be natural numbers that counts the total times of bouncing.   
- 3.This line is broken because there is no ";" at the end of the statement, so it does not compile.

### w3
1. The return type of the method should be a string because we want an output of text; the parameter should be an int for friendship level which is a continuous whole number variable and a boolean for the knowing of secret which is a yes-or-no status. 
2. A class is a blueprint of a component. The methods are the actual disigned functions of the component and the member variables are the specific states of each component, which can vary among each other.
3. Because it gets faster everytime it bounces.

### w4
1. (Table#13) _isGrounded is a member variable and its type is bool. _rigidBody is a component. Line 30 is calling a method "AddForce", and its parameters are two floats. I added rigidbody to the cat and the ball, and the ball I checked was trigger on. I had to change the variable types because my unity could not change ints to floats or strings implicitly. 

### w5
1. The question that why we should use transform instead of vector 3 for the object to move towards another object. The answer is that there has already been NavMeshAgent which can get the transform of the object directly and we will not have to maintain the rotation and the position ourselves. 
2. Our plan is to input a target object in the SterializeField to provide a target position, and use the NavMeshAgent component to make the deer move towards the direction. In order to make the deer head to the direction all the time, we need to update the position of the target object every frame using Update(). 

### w6
1. other tools: https://docs.google.com/document/u/0/d/1wrY73yJ_km0ig2SehlUSuSx3rOOu84QnORwQ0mV305o/mobilebasic
2. I added the float speed variable that controls the speed of the chasing of the bats. I built it in the batManager. Aside of that, I did not add any other member variables. The class only needs a chase() method to be called in the batManager. 

### w7
The code in Step 2 changes the player character's position on the world axis but not on the local axis. The correct code is Translate().

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 