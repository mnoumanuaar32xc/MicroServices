# MicroServices
**MicroServices** is a type of software architecture that is composed of loosely coupled services that are independently deployable and manageable. Each service is responsible for a single, specific purpose and works together with other services to fulfill a larger business goal. It is designed to allow for scalability and flexibility, allowing businesses to quickly adopt new technologies and respond to changing customer needs. MicroServices are typically deployed in containers, such as Docker, making them portable and easy to scale.

MicroServices are composed of small, independent services which communicate with each other to accomplish a task. This architecture allows for creating complex applications that are resilient, maintainable, and scalable. It is a popular approach for developing cloud-native applications, and can be used in combination with other approaches such as DevOps and continuous delivery


The **Ocelot** **Gateway** is an open source API Gateway developed by Steeltoe. It is built on top of the ASP.NET Core framework and is designed to help developers quickly create secure, reliable and scalable API gateways for their applications. Ocelot Gateway provides a number of features including rate limiting, authentication and authorization, logging, caching, and metrics. It also provides support for various cloud providers, including Microsoft Azure, Amazon Web Services (AWS), and Google Cloud Platform.


{
  "GlobalConfiguration": {
    "BaseUrl": "https://localhost:5206"
  },
  "Routes": [
    {
      "UpstreamPathTemplate": "/gateway/product",
      "UpstreamHttpMethod": [ "Get" ],
      "DownstreamPathTemplate": "/api/product",
      "DownstreamScheme": "https",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7214
        }
      ]
    },
  ]
}
