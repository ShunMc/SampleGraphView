using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

public class StringNode : SampleNode
{
	private TextField textField;
	public string Text { get { return textField.value; } }

	public StringNode() : base()
	{
		title = "String";

		var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Multi, typeof(string));
		outputContainer.Add(outputPort);

		textField = new TextField();
		mainContainer.Add(textField);
	}
}
