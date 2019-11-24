using System.Linq;
using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class LogNode : ProcessNode
{
	private Port inputString;

	public LogNode() : base()
	{
		title = "Log";

		inputString = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(string));
		inputContainer.Add(inputString);
	}

	public override void Execute()
	{
		var edge = inputString.connections.FirstOrDefault();
		var node = edge.output.node as StringNode;

		if (node == null) return;

		Debug.Log(node.Text);
	}
}
