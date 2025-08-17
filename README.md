# SportsWeb

## Dev Setup
- For version control download SourceTree for preferred OS: https://www.sourcetreeapp.com/
- Download Node.js from https://nodejs.org/en/download/.
- Download WebStorm from https://www.jetbrains.com/webstorm/promo/?source=google&medium=cpc&campaign=AMER_en_US-CST_WebStorm_Branded&term=webstorm&content=717267885243&gad_source=1&gad_campaignid=9641686287&gbraid=0AAAAADloJzjM8YwGuomM1PAAElS0TYUtX&gclid=Cj0KCQjw2IDFBhDCARIsABDKOJ6ZAX4ejAlVLQhNXvOmGcZ6rUg8tSvULOMdTD4DFZLUPnMA5E5bJkIaAmStEALw_wcB. Suggested that you use the non-commercial version for the time being.
- Download IDE for C# development. Preferred is Visual Studio or Rider.
- Navigate to the SportsWebApi directory in your terminal and enter the following command to install nswag dependencies:
    ```
        dotnet tool install --global NSwag.ConsoleCore
    ```
- Run the following command to ensure nswag has been installed successfully:
	```
		nswag --version
	```

## Running the Front End
- In your terminal, `cd sports-web-app` and enter `npm run start`. (For bryce use the command prompt in windows)

## Developer Information
- We want to be able to have our typescript to be able to automatically know what the requests/responses look like for web app so it'll be easier to send requests and receive responses.
  - To do so, we will use Swagger Generation will build our objects (requests, responses, etc.) in our SportsWebAPI and output them to our `SportsWebApi.ts` file so we can use them in our web application.
  - To make updates to objects, all we need to do is update them in our backend web API and build the web API. Once the web api finishes building, all we need to do is refresh our sports-web app to pickup changes.
  - For now the location of where to build the swagger will be located in the SportWebAPI's Open API specs. It is currently hardcoded, but I recommend that gets changed.


## Documentation
- For the video I used to help start this project: https://www.youtube.com/watch?v=dFIfZBEyZ90&t=1209s
- For setting up the endpoints and basis for talking to frontend to backend: https://fast-endpoints.com/docs/get-started
