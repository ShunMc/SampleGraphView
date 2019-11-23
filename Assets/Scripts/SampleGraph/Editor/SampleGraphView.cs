using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

public class SampleGraphView : GraphView
{
	public SampleGraphView() : base()
	{
		this.AddManipulator(new SelectionDragger());

		nodeCreationRequest += context =>
		{
			AddElement(new SampleNode());
		};
	}

	public override List<Port> GetCompatiblePorts(Port startAnchor, NodeAdapter nodeAdapter)
	{
		return ports.ToList();
	}
}
