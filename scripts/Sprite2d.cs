using Godot;
using System.Diagnostics;
using System;

public partial class Sprite2d : Sprite2D
{

	private Label label1;
	private Label label2;
	private Label SelectedLabel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		label1 = GetNode<Label>("../Label2");
		label2 = GetNode<Label>("../Label3");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		label1.AddThemeColorOverride("font_color", Colors.White);
		label2.AddThemeColorOverride("font_color", Colors.White);
		SelectedLabel = null;


		if(GlobalPosition.DistanceTo(label1.GlobalPosition) < 60)
		{
			label1.AddThemeColorOverride("font_color", Colors.Red);
			SelectedLabel = label1;
		}
		if(GlobalPosition.DistanceTo(label2.GlobalPosition) < 60)
		{
			label2.AddThemeColorOverride("font_color", Colors.Red);
			SelectedLabel = label2;
		}

		if(SelectedLabel != null && Input.IsKeyPressed(Key.Space))
		{
			switch (SelectedLabel.Text)
			{
				case "Quit":
					Process.GetCurrentProcess().Kill();
					break;
				case "Play":
					GetTree().ChangeSceneToFile("res://scenes/node_2d.tscn");
					break;
			}
		}

		int Speed = 20;
		if (Input.IsKeyPressed(Key.Shift))
		{
			Speed += 2 * Speed;
		}
		if (Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0, -Speed);
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, Speed);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.FlipH = false;
			this.Position += new Vector2(Speed, 0);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.FlipH = true;
			this.Position += new Vector2(-Speed, 0);
		}
	}
}
