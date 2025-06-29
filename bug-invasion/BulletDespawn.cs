using Godot;
using System;

public partial class BulletDespawn : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Timer DespawnTimer = GetNode<Timer>("DespawnTimer");
		DespawnTimer.Timeout += () => QueueFree();
	}
}
