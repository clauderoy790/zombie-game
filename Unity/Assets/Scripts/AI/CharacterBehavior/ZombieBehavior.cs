/*
*   This script has been auto-generated by the Behavior Tree Editor. Altering the script may cause issues.
*/

public class ZombieBehavior : BehaviorTree
{

	public ZombieBehavior(Zombie aCharacter) : base(aCharacter)
	{
		InitializeTree ();
	}

	protected override void InitializeTree ()
	{
		mRoot.AddChild(new GoToTarget(mCharacter));
		mRoot.AddChild(new RoamingAction(mCharacter));
	}
}
