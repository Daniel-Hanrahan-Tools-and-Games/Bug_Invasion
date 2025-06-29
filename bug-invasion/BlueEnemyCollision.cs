using Godot;
using System;

public partial class BlueEnemyCollision : Area2D
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += BlueCollision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void BlueCollision(Node body){
		if (body.Name == "Player")
		{
			// goes to main menu
			GetTree().ChangeSceneToFile("res://MainMenu.tscn");
		}
		else if (body.Name == "BlueBullet")
		{
			// destroys bullet
			body.QueueFree();
			// destroys enemy
			QueueFree();
		}
	}
	
	
}
