using DesignPatterns_CSharp.Behavioral.Iterator;
using DesignPatterns_CSharp.Behavioral.Memento;
using DesignPatterns_CSharp.Behavioral.State;
using DesignPatterns_CSharp.Behavioral.Strategy;


// Behavioral

#region Memento

//var editor = new Editor();
//var history = new History();

//editor.Content = "a";
//history.Push(editor.CreateState()); // state a

//editor.Content = "b";
//history.Push(editor.CreateState()); // state b

//editor.Content = "c";

//editor.RestoreState(history.Pop()); // restore b 
//editor.RestoreState(history.Pop()); // restore a 

//Console.WriteLine(editor.Content);

#endregion


#region State

//var canvas = new Canvas();

//canvas.MouseDown();
//canvas.MouseUp();

//canvas.CurrentTool = new BrushTool();

//canvas.MouseDown();
//canvas.MouseUp();

#endregion


#region Iterator

//var history = new BrowseHistory();

//history.Push("first");
//history.Push("second");

//var iterator = history.CreateIterator();

//while (iterator.HasNext())
//{
//    Console.WriteLine(iterator.Current());
//    iterator.Next();
//}


#endregion



#region Strategy

ImageStore.Store("image", new PngCompressor(), new BlackAndWhiteFilter());

ImageStore.Store("image", new JpegCompressor(), new BlackAndWhiteFilter());

#endregion
