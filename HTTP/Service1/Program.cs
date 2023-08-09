// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 
HttpClient client = new HttpClient();
HttpResponseMessage message =await client.GetAsync("http://localhost:5143/api/Values");
if (message.IsSuccessStatusCode)
{
    Console.WriteLine(await message.Content.ReadAsStringAsync());
}