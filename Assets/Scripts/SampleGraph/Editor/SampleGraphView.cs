using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

public class SampleGraphView : GraphView
{
	private RootNode root;

	public SampleGraphView() : base()
	{
		SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);

		Insert(0, new GridBackground());

		root = new RootNode();
		AddElement(root);

		this.AddManipulator(new SelectionDragger());

		var searchWindowProvider = new SampleSearchWindowProvider();
		searchWindowProvider.Initialize(this);

		nodeCreationRequest += context =>
		{
			SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), searchWindowProvider);
		};
	}

	public override List<Port> GetCompatiblePorts(Port startAnchor, NodeAdapter nodeAdapter)
	{
		var compatiblePorts = new List<Port>();
		foreach (var port in ports.ToList())
		{
			if (startAnchor.node == port.node ||
				startAnchor.direction == port.direction ||
				startAnchor.portType != port.portType)
			{
				continue;
			}

			compatiblePorts.Add(port);
		}
		return compatiblePorts;
	}

	public void Execute()
	{
	}
}
