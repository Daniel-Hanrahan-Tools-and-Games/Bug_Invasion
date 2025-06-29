using Godot;
using System;

public partial class RedEnemyCollision : Area2D
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += RedCollision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void RedCollision(Node body){
		if (body.Name == "Player")
		{
			// goes to main menu
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
		else if (body.Name == "RedBullet")
		{
			// destroys bullet
			body.QueueFree();
			// destroys enemy
			QueueFree();
		}
	}
	
	
}
