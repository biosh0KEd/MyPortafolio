## Making a Chat with WhatsApp API to give to give a better customer service

<hr>

During my time working in "R&C Soluciones" I had the opportunity to renew the old customer support system.

We used it to create support tickets, to manage our client's data and everything related with customer support.

And in that process we came across a problem, with our main communication channel, WhatsApp. So we decided to create a chat system that would allow us to manage our customer support through WhatsApp and add everything else we needed.

<img class="main-img" src="images/posts/panel-soporte-chat.jpeg" alt="chat-page-image" width="100%"/>

<br>
<br>

### Technologies

<hr>

- ASP.NET Core SignalR
  - I added SignalR to update the chat in real time:
  - [Tutorial: Get started with ASP.NET Core SignalR](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-7.0&tabs=visual-studio)
- DevExpress
  - Most of the devexpress ASP.NET Core controls create the UI:
  - [Devexpress ASP.NET Core Controls](https://demos.devexpress.com/aspnetcore/)
- Twilio
  - I also used the Twilio API to send and receive messages from WhatsApp:
  - [Twilio API for WhatsApp](https://www.twilio.com/whatsapp)
- Azure Blob storage
  - With Azure Blob storage I added support for file sharing, and used the MediaStream Recording API to record audio:
  - [MediaStream Recording API](https://developer.mozilla.org/en-US/docs/Web/API/MediaStream_Recording_API/Using_the_MediaStream_Recording_API)
