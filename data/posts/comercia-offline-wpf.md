## Creating some offline features of an ERP using WPF
<hr>

During my time working in "R&C Soluciones" we had a problem with an Azure App Service, 
it was a problem related to the [SNAT](https://learn.microsoft.com/en-us/azure/load-balancer/load-balancer-outbound-connections) port exhaustion, 
and it caused a lot of problems during a period of high demand, 
so we decided to create an offline desktop version of the web app, and I was in charge of creating it.

<img class="main-img" src="images/posts/comercia-offline-wpf.jpeg" alt="wpf-page-image" width="100%"/>

<br>
<br>

##### Technologies

<hr>

- LiteDB
  - I used as a database an embedded NoSQL database for .NET called [LiteDB](https://www.litedb.org/).
- DevExpress
  - I used [DevExpress WPF controls](https://docs.devexpress.com/WPF/7875/wpf-controls) to create the UI.

I used the [MVVM pattern](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) for the structure of the project.

