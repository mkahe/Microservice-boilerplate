# Microservice-boilerplate

Add RabbitMQ via docker
````
sudo docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.10-management
````

## to run projects
````
$> cd src/MeKa.Api
$> dotnet run --urls "http://*:5000"

$> cd src/MeKa.Services.Activities
$> dotnet run --urls "http://*:5001"

$> cd src/MeKa.Services.Identity
$> dotnet run --urls "http://*:5002"
````

RabbitMq monitoring pannel: `http://localhost:15672/`

CURL send a request via post to acitivities controller
````
curl --location --request POST 'http://localhost:5000/activities' \
--header 'Content-Type: application/json' \
--data-raw '{
    "category":"test",
    "name": "test"
}'
````

Running mongo:
````
docker run -d -p 27017:27017 mongo
````

Graphical tool: https://studio3t.com/download-studio3t-free

##Packages
dotnet add package MongoDB.Driver




