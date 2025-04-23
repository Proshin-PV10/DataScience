
using Test1;

var sampleData = new MLModel1.ModelInput()
{
    Col1 = @"Hello,Mike
",
};
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.PredictedLabel);