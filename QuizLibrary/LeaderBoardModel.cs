using System;

public class LeaderBoardModel
{
	/// <summary>
	/// Name of the person that hit the LeaderBoard.
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// The Score of the Name (person).
	/// </summary>
	public int Score { get; set; }
	/// <summary>
	/// Number of questions asked in the Quiz for the Name (person).
	/// </summary>
	public int NumberOfQuestions { get; set; }

	public LeaderBoardModel()
	{
	}
}
