### IntroToCrossPlatform Assessment Documentation
-------------------------------------------------



**Files** KillPlayerBehavior.cs

**Functions:**

    Name: OnCollisionEnter(Collision collision)

    Description: If the game object is compare to tag "Player" by collision.
    It destroys the object with the tag "Player" if it collides with the game object.

    Type: private void

-------------------------------------------------------------------------------------------------

**Files** GoalBehavior.cs

**Functions:**

    Name: OnCollisionEnter(Collision collision)

    Description: If the game object is compare to tag "Player" by collision.
    Loads in scene 2.

    Type: public void

-------------------------------------------------------------------------------------------------

**Files** LevelMovementBehavior.cs

**Functions:**

    Name: Update()

    Description: Transform the position of an object's X coordinates based on the horizontal speed and time.

    Type: void

-------------------------------------------------------------------------------------------------

**Files** PlayGameBehavior.cs

**Functions:**

    Name: PlayGame()

    Description: Loads in scene 1

    Type: public void

-------------------------------------------------------------------------------------------------

**Files** QuitGameBehavior.cs

**Functions:**

    Name: QuitGame()

    Description: It quits the application

    Type: public void

-------------------------------------------------------------------------------------------------

**Files** PlayerMovementBehavior.cs

**Functions:**

    Name: Start()

    Description: Rigid body gets the component of a rigid body.

    Type: private void
    ------------

    Name: Update()

    Description: If an object is on the ground and the mouse gets press.
    It adds a jump force to rigidbody's Y coordinates.

    Type: void
    ------------

    Name: OnCollisionEnter(Collision collision)

    Description: Checks if the game object is colliding with ground.
    Its true if it is.

    Type: private void
    ------------

    Name: OnCollisionExit(Collision collision)

    Description: Checks if the game object is not colliding with the ground.
    Its not true if not.

    Type: private void

-------------------------------------------------------------------------------------------------