HttpClient client = new();

HttpResponseMessage respone = await client.GetAsync("http://www.apple.com/");

WriteLine($"Apple's home page has {respone.Content.Headers.ContentLength:N0} bytes.");