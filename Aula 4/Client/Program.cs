
var http = new HttpClient();

while (true)
{
    try
    {
        var response = await http.GetStringAsync(
            "http://maestro"
        );

        Console.WriteLine(response);
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Erro na requisição: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }

    await Task.Delay(1000);
}