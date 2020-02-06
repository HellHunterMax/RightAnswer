using System;
using System.Collections.Generic;

public class QuestionModel
{
	/// <summary>
	/// The Question to be asked.
	/// </summary>
	public string Question { get; set; }
	/// <summary>
	/// The Right Answer to the Question
	/// </summary>
	public string RightAnswer { get; set; }
	/// <summary>
	/// All the Wrong Answers to the Question min 1 max 3.
	/// </summary>
	public List<string> WrongAnswers { get; set; }
	public QuestionModel()
	{
	}
}
