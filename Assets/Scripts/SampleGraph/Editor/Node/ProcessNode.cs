using UnityEditor.Experimental.GraphView;

public abstract class ProcessNode : SampleNode
{
	public ProcessNode()
	{
		var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(Port));
		inputPort.portName = "In";
		inputContainer.Add(inputPort);

		var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Port));
		outputPort.portName = "Out";
		outputContainer.Add(outputPort);
	}
}
