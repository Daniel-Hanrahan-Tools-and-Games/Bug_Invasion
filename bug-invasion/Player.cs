using Godot;
using System;

public partial class Player : CharacterBody2D
{	
	// initialization for dblSpeed
	public const float dblSpeed = 200f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Vector2 vel = Velocity;
		
		// if statements for movement
		if (Input.IsActionPressed("Right"))
		{
			// move to right
			vel.X = dblSpeed;
		}
		else if (Input.IsActionPressed("Left"))
		{
			// move to left
			vel.X = -dblSpeed;
		}
		else if (Input.IsActionPressed("Up"))
		{
			// move up
			vel.Y = -dblSpeed;
		}
		else if (Input.IsActionPressed("Down"))
		{
			// move down
			vel.Y = dblSpeed;
		}
		else
		{
			// stops player
			vel.X = 0;
			vel.Y = 0;
		}
		// neccessary movement code
		Velocity = vel;
		MoveAndSlide();
		
	}
}
