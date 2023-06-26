# VaderAI

Companion tutorial here: [https://www.joshgreenwald.com/darth-vader-ai](https://www.joshgreenwald.com/darth-vader-ai)

This repo is a C# console application demonstrating how to use the Azure OpenAI
service to make a Darth Vader AI assistant. Just be warned that while the Dark Lord of the Sith 
will answer your questions, he will also try to turn you to the dark side.

## Requirements

1. An Azure subscription
2. An Azure OpenAI service resource with a deployed gpt-35-turbo or gpt-4 model
3. Visual Studio or Visual Studio Code

## Setup

Inject your endpoint, key, and model name into these variables:

```csharp
var openAIEndpoint = "<<Your Azure OpenAI Endpoint>>";
var openAiKey = "<<Your Azure OpenAI API Key>>";
var modelName = "<<Your model name>>";
```

The API key can be pasted directly into the code, but it's better to use something like 
environment variables, user secrets, or Azure Key Vault.

## Running and Debugging

Use an IDE like Visual Studio or Visual Studio Code to debug the app. 

## Disclaimer

Darth Vader and Star Wars are the intelletual property of the Disney corporation. I am not 
affiliated with Disney (other than being a big fan of the parks) nor did I train the base GPT 35 Turbo model to act like Darth Vader.
