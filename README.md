# Weather Console App 🌦️

Hi 👋 This is a simple .NET console app I made to learn how to fetch and display weather data using an API.

It uses the **OpenWeatherMap API** to show the current temperature and description for any city you type in. I also added safe config handling so the API key isn't hardcoded.

## 🔧 Setup & How to Run

You need:
- [.NET SDK 7+ or 9](https://dotnet.microsoft.com/download)
- A terminal (CMD, PowerShell, or VS Code terminal)

### Steps:

1. Clone this repo  
2. Run the following in the terminal:

```bash
dotnet restore
dotnet run
```

3. Type in your city and it shows the weather 🌤️

---

## 🔐 API Key Setup

To use this, you need an API key from [OpenWeatherMap](https://openweathermap.org/api).  
Create a file named **`appsettings.Development.json`** in the root of the project and add your key like this:

```json
{
  "ApiKeys": {
    "OpenWeather": "your_api_key_here"
  }
}
```

This file is **excluded from GitHub**, so your key stays private.

---

## ❓ What it does

- Sends a request to OpenWeatherMap API
- Parses the JSON response
- Shows:
  - ✅ City name
  - ✅ Temperature (°C)
  - ✅ Description (like clouds or clear sky)

If something goes wrong (like invalid city or missing key), it tells you with a friendly error message.

---

## 💡 Future ideas

- Add wind speed, humidity, or icon display
- Wrap it in a GUI (maybe WPF or MAUI)
- Add 3-day forecast
- Handle location automatically

---

Let me know if you try it out or have tips 🙃