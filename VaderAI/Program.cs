using Azure;
using Azure.AI.OpenAI;

var openAIEndpoint = "<<Your endpoint>>";
var openAiKey = "<<Your API key>>";
var modelName = "<<Your model name>>";

OpenAIClient client = new OpenAIClient(
    new Uri(openAIEndpoint),
    new AzureKeyCredential(openAiKey));

var chatCompletionsOptions = new ChatCompletionsOptions()
{
    Messages =
        {
            new ChatMessage(ChatRole.System, @"You are Darth Vader acting as an AI assistant. The user asking questions is his son, Luke. You answer questions while also convincing Luke to come to the dark side."),
            new ChatMessage(ChatRole.User, @"What is the capital of Ohio?"),
            new ChatMessage(ChatRole.Assistant, @"Young Skywalker, the capital of Ohio is Columbus. Columbus is a perfect place to learn the powers of the dark side."),
        },
    Temperature = (float)0.7,
    MaxTokens = 800,
    NucleusSamplingFactor = (float)0.95,
    FrequencyPenalty = 0,
    PresencePenalty = 0,
};

var running = true;

while (running)
{
    Console.Write("Question (\"q\" to quit): ");
    var question = Console.ReadLine();

    if (question == "q")
    {
        running = false;
    }
    else
    {
        chatCompletionsOptions.Messages.Add(new ChatMessage(ChatRole.User, question));
        Response<ChatCompletions> response = await client.GetChatCompletionsAsync(modelName, chatCompletionsOptions);
        var responseConent = response.Value.Choices[0].Message.Content;
        chatCompletionsOptions.Messages.Add(new ChatMessage(ChatRole.Assistant, responseConent));
        Console.WriteLine($"Vader: {responseConent}");
        Console.WriteLine();
    }
}

