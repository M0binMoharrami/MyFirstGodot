using Godot;
using System;

public partial class GamePlayer : Sprite2D
{
	private Sprite2D eatable;
	private Label Score;
	private int iScore;
	Vector2 screenSize = new Vector2(0,0);

	RandomNumberGenerator rng = new RandomNumberGenerator();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		eatable = GetNode<Sprite2D>("../Eatable");
		Score = GetNode<Label>("../Label");
		screenSize = GetViewportRect().Size;

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (GlobalPosition.DistanceTo(eatable.GlobalPosition) < 30)
		{
			iScore += 20;
			Score.Text = "Score = " + iScore;

			Vector2 randomPosition = new Vector2(
				rng.RandfRange(30, screenSize.X - 30),
				rng.RandfRange(30, screenSize.Y - 30)
			);

			eatable.GlobalPosition = randomPosition;
		}

		int Speed = 5;
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
		Vector2 pos = GlobalPosition;
		pos.X = Mathf.Clamp(Position.X, 0, screenSize.X);
		pos.Y = Mathf.Clamp(Position.Y, 0, screenSize.Y);
		GlobalPosition = pos;
	}
}
