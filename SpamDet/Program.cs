//Load sample data
using SpamDet;

//Load sample data
var sampleData = new SD.ModelInput()
{
    Content = @"I HAVE A DATE ON SUNDAY WITH WILL!!",
};

//Load model and predict output
var result = SD.Predict(sampleData);

Console.WriteLine(result.PredictedLabel);
