using UnityEditor.Experimental.GraphView;

public abstract class ProcessNode : SampleNode
{
	public Port InputPort;
	public Port OutputPort;

	public ProcessNode()
	{
		InputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(Port));
		InputPort.portName = "In";
		inputContainer.Add(InputPort);

		OutputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Port));
		OutputPort.portName = "Out";
		outputContainer.Add(OutputPort);
	}

	public abstract void Execute();
}
