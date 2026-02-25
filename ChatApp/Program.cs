using System.Text;
using System.Text.Json;

string apiKey = "";

HttpClient client = new HttpClient();

Console.WriteLine("🤖 Gemini Chat Ready");
Console.WriteLine("Type 'exit' to quit\n");


while (true)
{
    Console.Write("You: ");
    string? input = Console.ReadLine();

    if (input == null || input.ToLower() == "exit")
        break;

    var requestBody = new
    {
        contents = new[]
        {
            new
            {
                parts = new[]
                {
                    new { text = input }
                }
            }
        }
    };

    string json = JsonSerializer.Serialize(requestBody);

   var response = await client.PostAsync(
    $"https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent?key={apiKey}",
    new StringContent(json, Encoding.UTF8, "application/json")
);


    string result = await response.Content.ReadAsStringAsync();

    using JsonDocument doc = JsonDocument.Parse(result);

    if (doc.RootElement.TryGetProperty("candidates", out JsonElement candidates))
    {
        string reply = candidates[0]
            .GetProperty("content")
            .GetProperty("parts")[0]
            .GetProperty("text")
            .GetString() ?? "";

        Console.WriteLine($"\nAI: {reply}\n");
    }
    else
    {
        Console.WriteLine("\n❌ API Error:");
        Console.WriteLine(result);
        Console.WriteLine();
    }
}

