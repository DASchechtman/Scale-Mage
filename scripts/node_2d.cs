using Godot;
using System;

public partial class node_2d : Node2D
{
	// Called when the node enters the scene tree for the first time.

	private int s = 0;
	private int x = 0;
	public override void _Ready()
	{
		GD.Print("Hello from C#!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (s == 60) {
			GD.Print($"Hello from C#! {x++}");
			s = 0;
		} else {
			s++;
		}
	}
}
