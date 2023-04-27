
using static RestaurantViolations.RestaurantViolationsPrediction;

// Create sample data
ModelInput input = new ModelInput
{
    InspectionType = "Complaint",
    ViolationDescription = "Inadequate sewage or wastewater disposal"
};

// Make prediction
ModelOutput result = Predict(input);

// Print Prediction
Console.WriteLine($"Inspection type: {input.InspectionType}");
Console.WriteLine($"Violation description: {input.ViolationDescription}");
Console.WriteLine($"Predicted risk category: {result.PredictedLabel}");
Console.ReadKey();
