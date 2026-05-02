using DesignPatterns_CSharp.Behavioral.ChainOfResponsibility;
using DesignPatterns_CSharp.Behavioral.Command;
using DesignPatterns_CSharp.Behavioral.Command.Editor;
using DesignPatterns_CSharp.Behavioral.Command.Fx;
using DesignPatterns_CSharp.Behavioral.Mediator;
using DesignPatterns_CSharp.Behavioral.Mediator.UsingObserver;
using DesignPatterns_CSharp.Behavioral.Observer;
using DesignPatterns_CSharp.Behavioral.TemplateMethod;
using DesignPatterns_CSharp.Behavioral.Visitor;
using DesignPatterns_CSharp.Structural.Adapter.AvaFilters;
using DesignPatterns_CSharp.Structural.Adapter.Problem;
using DesignPatterns_CSharp.Structural.Composite.Problem;
using DesignPatterns_CSharp.Structural.Composite.Solution;
using Visitor = DesignPatterns_CSharp.Behavioral.Visitor;


// Behavioral

#region Behavioral Patterns

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

//ImageStore.Store("image", new PngCompressor(), new BlackAndWhiteFilter());

//ImageStore.Store("image", new JpegCompressor(), new BlackAndWhiteFilter());

#endregion


#region Template Method

//var transferMoney1 = new TransferMoneyTask();
//transferMoney1.Execute();

//var generateReport1 = new GenerateReportTask();
//generateReport1.Execute();



#endregion


#region Command

//var customerService = new CustomerService();

//var addCustomerCommand = new AddCustomerCommand(customerService);

//var button = new Button(addCustomerCommand);


// composite commands

//var compositeCommands = new CompositeCommand();

//compositeCommands.Add(new ResizeCommand());
//compositeCommands.Add(new BlackAndWhiteCommand());

//compositeCommands.Execute();

// Undoable

//var history = new History();
//var document = new HtmlDocument();
//document.Content = "hellllo";

//var boldCommand = new BoldCommand(document,history);

//boldCommand.Execute();
//Console.WriteLine(document.Content);

//var undoCommand = new UndoCommand(history);

//undoCommand.Execute();

//Console.WriteLine(document.Content);


#endregion



#region Observer
// push style

//var datasource = new DataSource();
//var sheet1 = new SpreadSheet();
//var sheet2 = new SpreadSheet();
//var chart = new Chart();

//datasource.AddObserver(sheet1);
//datasource.AddObserver(chart);

//datasource.Value = 10;
//datasource.AddObserver(sheet2);

//datasource.Value = 20;

// pull style

//var datasource = new DataSource();
//var sheet1 = new SpreadSheet(datasource);
//var sheet2 = new SpreadSheet(datasource);
//var chart = new Chart(datasource);

//datasource.AddObserver(sheet1);
//datasource.AddObserver(chart);

//datasource.Value = 10;
//datasource.AddObserver(sheet2);

//datasource.Value = 20;


#endregion


#region Mediator

//var articleDialogBox = new ArticlesDialogBox();

//articleDialogBox.SimulateChanges();


// using observer 

//var LevelsDialogBox = new LevelsDialogBox();

//LevelsDialogBox.SimulateChanges();


#endregion


#region Chain Of Responsibility

//var compressor = new Compressor(null);
//var logger = new Logger(compressor);
//var authenticator= new Authenticator(logger);

//var webserver = new WebServer(authenticator);
//webserver.Handle(new HttpRequest() { UserName = "admin", Password = "1234" });

#endregion


#region Visitor

//var htmlDocument = new Visitor.HtmlDocument();

//htmlDocument.Add(new AnchorNode());
//htmlDocument.Add(new HeadingNode());

//htmlDocument.Execute(new HighlightOperation());
//htmlDocument.Execute(new PlainTextOperation());

#endregion 

#endregion


#region Structural


#region Composite

//var group1 = new Group();
//group1.Add(new Shape());
//group1.Add(new Shape());

//var group2 = new Group();
//group2.Add(new Shape());
//group2.Add(new Shape());

//var group = new Group();
//group.Add(group1);
//group.Add(group2);
//group.Add(new Shape());

//group.Render();
//group.Move();

#endregion


#endregion

#region Adapter

var imageView = new ImageViewP(new ImageP());

imageView.Apply(new VividFilterP());

//imageView.Apply(new AvaCaremel()); AvaCaremel doesn't match what we want 

#endregion
