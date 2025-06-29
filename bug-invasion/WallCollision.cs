using Godot;
using System;

public partial class WallCollision : Area2D
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// signal prep
		BodyEntered += Collision;	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void Collision(Node2D Player){
		// goes to main menu
		GetTree().ChangeSceneToFile("res://MainMenu.tscn");
	}
	}
