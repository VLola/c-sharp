using Amazon.Rekognition;
using Amazon.Rekognition.Model;

String photo = "img.jpg";
String bucket = "valikbucket";

AmazonRekognitionClient rekognitionClient = new AmazonRekognitionClient("AKIA6PVL36AGMXQV32FU", "TvPsi8ZFioNPgWtKLfA5A5rOQU9KoHY9Fva5aK9n", Amazon.RegionEndpoint.USWest2);


DetectTextRequest detectTextRequest = new DetectTextRequest()
{
    Image = new Image()
    {
        S3Object = new S3Object()
        {
            Name = photo,
            Bucket = bucket
        }
    }
};

try
{
    DetectTextResponse detectTextResponse = rekognitionClient.DetectTextAsync(detectTextRequest).Result;
    Console.WriteLine("Detected lines and words for " + photo);
    foreach (TextDetection text in detectTextResponse.TextDetections)
    {
        Console.WriteLine("Detected: " + text.DetectedText);
        Console.WriteLine("Confidence: " + text.Confidence);
        Console.WriteLine("Id : " + text.Id);
        Console.WriteLine("Parent Id: " + text.ParentId);
        Console.WriteLine("Type: " + text.Type);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}