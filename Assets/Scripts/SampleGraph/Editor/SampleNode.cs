using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

public class SampleNode : Node
{
	public SampleNode()
	{
		title = "Sample";

		var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(Port));
		inputContainer.Add(inputPort);

		var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Port));
		outputContainer.Add(outputPort);
	}
}
