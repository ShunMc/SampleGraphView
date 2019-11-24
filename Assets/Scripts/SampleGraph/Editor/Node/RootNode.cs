using UnityEditor.Experimental.GraphView;

public class RootNode : SampleNode
{
	public Port OutputPort;

	public RootNode() : base()
	{
		title = "Root";

		capabilities -= Capabilities.Deletable;

		OutputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Port));
		OutputPort.portName = "Out";
		outputContainer.Add(OutputPort);
	}
}
